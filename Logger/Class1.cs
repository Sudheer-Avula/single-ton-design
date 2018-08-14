using System;

namespace Logger
{
    public sealed class Log :ILog
    {
        private static int _counter = 0;
        //private static Log Instance = null;
        private static  readonly Lazy<Log> Instance = new Lazy<Log>();
        public static Log Getinstance
        {
            get
            {
                //if (Instance == null)
                //    Instance = new Log();
                return Instance.Value;
            }
            
        }

        private Log()
        {
            _counter++;
            Console.WriteLine("counter value " + _counter);

        }

        public void LogExcepion()
        {
            throw new NotImplementedException();
        }
    }
}
