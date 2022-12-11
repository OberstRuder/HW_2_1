﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1
{
    internal class Logger
    {
        private Logger()
        {
            LogList = new List<Result>();
            LogLevel = LogStatus.Warning;
        }

        private static Logger _logger;

        public LogStatus LogLevel { get; set; }

        public List<Result> LogList { get; private set; }

        public static Logger Get()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }

        public void AddLog(Result log)
        {
            LogList.Add(log);
        }

        public void Output()
        {
            LogList.ForEach((inf) =>
            {
                if (inf.Status == LogLevel)
                    Console.WriteLine(inf);
            });
        }

    }
}
