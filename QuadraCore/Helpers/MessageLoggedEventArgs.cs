using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadra.Helpers
{
    public class MessageLoggedEventArgs : EventArgs
    {
        public MessageLoggedEventArgs(string message, Exception exception = null)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            Message = message;
            Exception = exception;
        }

        public string Message { get; private set; }
        public Exception Exception { get; private set; }
    }
}
