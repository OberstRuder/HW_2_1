using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1
{
    internal class Result
    {
        public Result(LogStatus status, string message, DateTime time)
        {
            Status = status;
            Message = message;
            Time = time;
        }

        public LogStatus Status { get; init; }

        public string Message { get; init; }

        public DateTime Time { get; init; }

        public override string ToString()
        {
            return $"{Time.ToShortDateString()} {Time.ToShortTimeString()}: {Status.ToString()}: {Message}";
        }
    }
}
