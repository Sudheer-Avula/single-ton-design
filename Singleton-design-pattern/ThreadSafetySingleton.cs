using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPpattern
{
    public sealed class ThreadSafetySingleton
    {
        private static int _counter = 0;
        private static ThreadSafetySingleton Instance = null;
        
        public static ThreadSafetySingleton Getinstance
        {
            get
            {
                if (Instance == null)
                    Instance =  new ThreadSafetySingleton();
                return Instance;
            }
            set { }
        }

        private ThreadSafetySingleton()
        {
            _counter++;
            Console.WriteLine("counter value " + _counter);

        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
