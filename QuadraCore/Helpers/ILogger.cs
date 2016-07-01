using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Helpers
{
    public interface ILogger
    {
        void Info(string message);
        void Warning(string message, Exception exception);
        void Error(string message, Exception exception);
    }
}
