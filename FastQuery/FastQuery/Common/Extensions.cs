using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

    public static class lExtensions
    {
        public static void Invoke(this Control Control, Action Action)
        {
            Control.Invoke(Action);
        }
    
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
        }
    }
