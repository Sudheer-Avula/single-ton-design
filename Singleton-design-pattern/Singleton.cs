using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPpattern
{
    //single Thread
    public sealed  class Singleton
    {
        private static int counter = 0;
        //private static Singleton _instance = null;
        //private  static readonly object obj= new object(); // Step 2:
        //private static readonly Singleton _instance = new Singleton(); // Step 3: eager initialiging 
        //By default Lazy is threadsafe
        private static  readonly  Lazy<Singleton> _instance=new Lazy<Singleton>(()=>new Singleton());

        public static Singleton Getinstance
        {
            get
            {
                /* // Step 1: Lazy Initialization in single thread environment (not thread safty)
                if (_instance == null)
                    _instance = new Singleton();
                    */

                /* lock ensure to only one thread enter and other will wait to complete. */
                // Step 2: Lazy Initialization in multi thread environment (thread safty)
                //if (_instance == null)
                //{
                //    lock (obj)
                //    {
                //        if (_instance == null)
                //            _instance= new Singleton();
                //    }
                //}

                // Step 3: eager initialiging 
                return _instance.Value;
            }
           
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("counter value "+ counter);

        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        //public class DerivedSingleton : Singleton
        //{
            
        //}
    }

    
}
