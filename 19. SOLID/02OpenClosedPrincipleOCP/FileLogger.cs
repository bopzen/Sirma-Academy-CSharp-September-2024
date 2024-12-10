using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClosedPrincipleOCP
{
    public class FileLogger : ILogger
    {
        private string _filename;

        public FileLogger(string filename)
        {
            _filename = filename;
        }

        public void Log(string message)
        {
            File.WriteAllText(_filename, message);
        }
    }
}
