﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_5.Logger
{
    internal class Actions
    {
        public Result CreateInfo(string messege)
        {
            Result result = new Result();
            result.Status = "Info";
            result.Messege = messege;
            result.DateTime = DateTime.Now;
            return result;
        }
        public Result CreateError(string messege)
        {
            Result result = new Result();
            result.Status = "Error";
            result.Messege = messege;
            result.DateTime = DateTime.Now;
            return result;
        }
    }
}
