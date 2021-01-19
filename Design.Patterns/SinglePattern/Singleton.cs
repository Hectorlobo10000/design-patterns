using System.Collections.Generic;
using System.Text;

namespace SinglePattern
{
    public class Singleton
    {
        private static volatile Singleton _uniqueInstance;

        private Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                lock (typeof(Singleton))
                {
                    if (_uniqueInstance == null)
                    {
                        _uniqueInstance = new Singleton();
                    }
                }
            }

            return _uniqueInstance;
        }

        public string Welcome(string message)
        {
            return message;
        }
    }
}
