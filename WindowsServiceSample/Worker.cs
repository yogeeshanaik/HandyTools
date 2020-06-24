using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsServiceSample
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private IServiceScopeFactory _serviceScopeFactory;
        private SmtpClient _smtpClient;

        private string _runInterval = "01:00:00"; //hh:mm:ss
        private string _connectionString = string.Empty;
        public Worker(ILogger<Worker> logger, IServiceScopeFactory serviceScopeFactory, SmtpClient smtpClient)
        {
            _logger = logger;
            _serviceScopeFactory = serviceScopeFactory;
            _smtpClient = smtpClient;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            var configuration = _serviceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IConfiguration>();
            _runInterval = configuration["App.Configurations:RunInterval"];
            _connectionString = configuration["ConnectionStrings:SCHEDULER_DB"];
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                DoWork();
                await Task.Delay(TimeSpan.Parse(_runInterval), stoppingToken);
            }
        }

        void DoWork()
        {
            var db = new DBHelper();
            db.CreateDBObjects(_connectionString, DBHelper.DbProviders.SqlServer);
            var dsSchedules = db.GetDataSet("[dbo].[usp_get_jobschedules]", CommandType.StoredProcedure, ConnectionState.Open);
            _logger.LogInformation("{count} schedule(s) are ready to execute.", dsSchedules?.Tables[0].Rows?.Count ?? 0);
            var dtSchedules = dsSchedules?.Tables[0];

            foreach (DataRow rowSchedule in dtSchedules?.Rows)
            {
                var json = rowSchedule["additional_parameters"]?.ToString();
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                db.AddParameter("schedule_id", rowSchedule["schedule_id"]);
                var dsResults = db.GetDataSet("[dbo].[usp_start_schedule]", CommandType.StoredProcedure, ConnectionState.Open);

                // Assumption: Each step will have only one resultset for report
                foreach (DataTable dataTable in dsResults?.Tables)
                {
                    string strBody = DataTable2ExcelString(dataTable);
                    byte[] data = Encoding.ASCII.GetBytes(strBody);

                    //save the data to a memory stream
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(data);

                    var mailMessage =
                      new MailMessage()
                      {
                          Subject = jsonObj["Email"]["Subject"].ToString(),
                          Body = jsonObj["Email"]["Body"].ToString(),
                          IsBodyHtml = false,
                          //Attachments = { new Attachment(stream, $"Receipt-{receiptEmailData.Receipt.CourseName}.pdf") }
                      };

                    mailMessage.Attachments.Add(new System.Net.Mail.Attachment(ms, "example.xls", "application/vnd.ms-excel"));

                    mailMessage.From = new MailAddress(((System.Net.NetworkCredential)_smtpClient.Credentials).UserName, "");
                    foreach (string address in jsonObj["Email"]["To"].ToString().Split(';'))
                    {
                        if (address.Length > 0)
                            mailMessage.To.Add(new MailAddress(address.Trim(), ""));
                    }                    
                    _smtpClient.Send(mailMessage);
                }
            }
        }

        public static void AddOrUpdateAppSetting<T>(string key, T value)
        {
            try
            {

                var filePath = Path.Combine(AppContext.BaseDirectory, "appSettings.json");
                string json = File.ReadAllText(filePath);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                var sectionPath = key.Split(":")[0];
                if (!string.IsNullOrEmpty(sectionPath))
                {
                    var keyPath = key.Split(":")[1];
                    jsonObj[sectionPath][keyPath] = value;
                }
                else
                {
                    jsonObj[sectionPath] = value; // if no sectionpath just set the value
                }
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, output);

            }
            catch
            {
                Console.WriteLine("Error writing app settings");
            }
        }

        static string DataTable2ExcelString(System.Data.DataTable dt)
        {
            StringBuilder sbTop = new StringBuilder();
            sbTop.Append("<html xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:x=\"urn:schemas-microsoft-com:office:excel\" ");
            sbTop.Append("xmlns=\" http://www.w3.org/TR/REC-html40\"><head><meta http-equiv=Content-Type content=\"text/html; charset=windows-1252\">");
            sbTop.Append("<meta name=ProgId content=Excel.Sheet ><meta name=Generator content=\"Microsoft Excel 9\"><!--[if gte mso 9]>");
            sbTop.Append("<xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>" + dt.TableName + "</x:Name><x:WorksheetOptions>");
            sbTop.Append("<x:Selected/><x:ProtectContents>False</x:ProtectContents><x:ProtectObjects>False</x:ProtectObjects>");
            sbTop.Append("<x:ProtectScenarios>False</x:ProtectScenarios></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets>");
            sbTop.Append("<x:ProtectStructure>False</x:ProtectStructure><x:ProtectWindows>False</x:ProtectWindows></x:ExcelWorkbook></xml>");
            sbTop.Append("<![endif]-->");
            sbTop.Append("</head><body><table>");
            string bottom = "</table></body></html>";
            StringBuilder sb = new StringBuilder();
            //Header
            sb.Append("<tr>");
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append("<td>" + dt.Columns[i].ColumnName + "</td>");
            }
            sb.Append("</tr>");

            //Items
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                sb.Append("<tr>");
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sb.Append("<td>" + dt.Rows[x][i] + "</td>");
                }
                sb.Append("</tr>");
            }

            string SSxml = sbTop.ToString() + sb.ToString() + bottom;

            return SSxml;
        }
    }
}
