using System;

namespace EzScript.Core.Models
{
    public class SqlObject
    {
        public string Type { get; set; }
        public string Schema { get; set; }
        public string Name { get; set; }
        public DateTime Modify_Date { get; set; }
        public DateTime Create_Date { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}].[{1}]", Schema, Name);
        }
    }
}