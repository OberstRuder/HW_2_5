using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5.Logger
{
    internal interface ILogger
    {
        public string Format { get; set; }

        public void CreateLog(string messege, string LogLevel);

        public void AddLog(Result log);

        public void ShowLog();
    }
}
