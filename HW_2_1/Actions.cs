using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1
{
    internal class Actions
    {
        public static Result InfoAction()
        {
            return new(LogStatus.Info, "info", DateTime.Now);
        }

        public static Result WarningAction()
        {
            return new(LogStatus.Warning, "warning", DateTime.Now);
        }

        public static Result ErrorAction()
        {
            return new(LogStatus.Error, "error", DateTime.Now);
        }

    }
}
