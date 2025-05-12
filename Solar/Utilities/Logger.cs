using log4net;

namespace Solar.Utilities
{
    public static class Logger
    {
        public static readonly ILog Instance = LogManager.GetLogger(typeof(Program));
    }
}
