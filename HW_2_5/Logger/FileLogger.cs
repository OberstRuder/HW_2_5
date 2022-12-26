using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW_2_5.Logger
{
    internal class FileLogger
    {
        private Actions _actions;

        public string Format { get; set; }

        public FileLogger(Actions actions, string format)
        {
            _actions = actions;
            Format = format;
        }

        public void CreateLog(string messege, string logLevel)
        {
            switch (logLevel)
            {
                case "Info":
                    AddLog(_actions.CreateInfo(messege));
                    break;
                case "Error":
                    AddLog(_actions.CreateError(messege));
                    break;
            }
        }

        public void AddLog(Result log)
        {
            var path = @"C:\Users\Женя Бабко\source\repos\HW_2_5\HW_2_5\Log.txt";
                var json = JsonSerializer.Serialize(log);
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.Write(json);
                }
        }

        public void ShowLog()
        {
        }
    }
}
