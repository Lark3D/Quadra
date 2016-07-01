using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuadraCore.Helpers
{
    public static class Log
    {
        public static event EventHandler<MessageLoggedEventArgs> ErrorLogged;

        public static event EventHandler<MessageLoggedEventArgs> WarningLogged;

        public static event EventHandler<MessageLoggedEventArgs> InfoLogged;

        public static ILogger Instance { get; set; }

        public static void Info(string message)
        {
            Instance?.Info(message);
            InfoLogged?.Invoke(null, new MessageLoggedEventArgs(message));
        }

        public static void Warning(string message, Exception exception = null)
        {
            Instance?.Warning(message, exception);
            WarningLogged?.Invoke(null, new MessageLoggedEventArgs(message, exception));
        }

        public static void Error(string message, Exception exception = null)
        {
            Instance?.Error(message, exception);
            ErrorLogged?.Invoke(null, new MessageLoggedEventArgs(message, exception));
        }
    }
}
