using Subble.Core;
using Subble.Core.Func;
using Subble.Core.Logger;

using static Subble.Core.Logger.SubbleLog;
using static Subble.Core.Events.EventsType.Core;

namespace BasicLogger
{
    public class Logger : ILogger
    {
        private ISubbleHost _host;

        public Logger(ISubbleHost host)
        {
            this._host = host;
        }

        public void Log(LogLevel level, string source, string message)
        {
            var log = GetLog(level, message);

            _host.EmitEvent(LOG, source, log);
        }

        public void Log(LogLevel level, string source, string message, Option details)
        {
            var log = GetLog(level, message);
            log.Details = details;

            _host.EmitEvent(LOG, source, log);
        }

        public void LogDebug(string source, string message)
            => Log(LogLevel.Debug, source, message);

        public void LogDebug(string source, string message, Option details)
            => Log(LogLevel.Debug, source, message, details);

        public void LogError(string source, string message)
            => Log(LogLevel.Error, source, message);

        public void LogError(string source, string message, Option details)
            => Log(LogLevel.Error, source, message, details);

        public void LogFatal(string source, string message)
            => Log(LogLevel.Fatal, source, message);

        public void LogFatal(string source, string message, Option details)
            => Log(LogLevel.Fatal, source, message, details);

        public void LogInfo(string source, string message)
            => Log(LogLevel.Info, source, message);

        public void LogInfo(string source, string message, Option details)
            => Log(LogLevel.Info, source, message, details);

        public void LogTrace(string source, string message)
            => Log(LogLevel.Trace, source, message);

        public void LogTrace(string source, string message, Option details)
            => Log(LogLevel.Trace, source, message, details);

        public void LogWarning(string source, string message)
            => Log(LogLevel.Warning, source, message);

        public void LogWarning(string source, string message, Option details)
            => Log(LogLevel.Warning, source, message, details);
    }
}
