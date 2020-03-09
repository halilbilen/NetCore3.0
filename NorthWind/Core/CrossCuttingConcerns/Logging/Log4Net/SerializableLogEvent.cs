using log4net.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class SerializableLogEvent
    {
        private LoggingEvent loggingEvent;

        public SerializableLogEvent(LoggingEvent _loggingEvent)
        {
            loggingEvent = _loggingEvent;
        }

        public object Message => loggingEvent.MessageObject;
    }
}
