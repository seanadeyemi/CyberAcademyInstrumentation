using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CyberAcademyInstrumentation.Helpers
{
    public static class TraceHelper
    {

        public static void WriteOut(TraceLevel level, string msg)
        {
            switch (level)
            {
                
                case TraceLevel.Error:
                    Trace.TraceError(msg);

                    break;
                case TraceLevel.Warning:

                    Trace.TraceWarning(msg);
                    break;
                case TraceLevel.Info:
                    Trace.TraceInformation(msg);
                    break;
                case TraceLevel.Verbose:
                    Trace.WriteLine(msg);
                    break;
                
            }
        }

    }
}