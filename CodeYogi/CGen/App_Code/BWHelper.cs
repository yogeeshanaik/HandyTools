using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


public class BWHelper
{
    private IEnumerable<Action> toDo;
    private DateTime startTime;

    private bool isParallel = false;
    private BackgroundWorker worker;

    private ValueMonitor<int> percentageProgress = new ValueMonitor<int>(0);
    private ValueMonitor<TimeSpan> timeLeft = new ValueMonitor<TimeSpan>(TimeSpan.MaxValue);

    public void SetActionsTodo(IEnumerable<Action> toDoActions)
    {
        toDo = toDoActions;
    }

    public bool IsParallel
    {
        get { return isParallel; }
        set { isParallel = value; }
    }

    public IValueMonitor<TimeSpan> TimeLeft { get { return timeLeft; } }

    public BWHelper(BackgroundWorker aWorker)
    {
        worker = aWorker;
        worker.WorkerReportsProgress = true;
        worker.WorkerSupportsCancellation = true;
        percentageProgress.ValueChanged +=
                   new ValueChangedDelegate<int>(percentageProgress_ValueChanged);

        worker.DoWork += new DoWorkEventHandler(worker_DoWork);
    }

    public BWHelper(IEnumerable<Action> actionsToDo, BackgroundWorker aWorker) : this(aWorker)
    {
        toDo = actionsToDo;
    }

    public int Total
    {
        get
        {
            if (toDo == null) return 0;
            return toDo.Count();
        }
    }

    private void percentageProgress_ValueChanged(int oldValue, int newValue)
    {
        worker.ReportProgress(newValue);
    }

    private void worker_DoWork(object sender, DoWorkEventArgs e)
    {
        if (toDo == null)
            throw new InvalidOperationException("You must provide actions to execute");
        int total = toDo.Count();
        startTime = DateTime.Now;
        int current = 0;
        if (isParallel == false)
        {
            foreach (var next in toDo)
            {
                next();
                current++;
                if (worker.CancellationPending == true) return;
                percentageProgress.Value = (int)((double)current / (double)total * 100.0);
                double passedMs = (DateTime.Now - startTime).TotalMilliseconds;
                double oneUnitMs = passedMs / current;
                double leftMs = (total - current) * oneUnitMs;
                timeLeft.Value = TimeSpan.FromMilliseconds(leftMs);
            }
        }
        else
        {

            Parallel.For(0, total - 1,
                (index, loopstate) =>
                {

                    toDo.ElementAt(index)();
                    if (worker.CancellationPending == true) loopstate.Stop();
                    Interlocked.Increment(ref current);

                    percentageProgress.Value = (int)((double)current / (double)total * 100.0);
                    double passedMs = (DateTime.Now - startTime).TotalMilliseconds;
                    double oneUnitMs = passedMs / current;
                    double leftMs = (total - current) * oneUnitMs;
                    timeLeft.Value = TimeSpan.FromMilliseconds(leftMs);
                }
                );
        }
    }
}