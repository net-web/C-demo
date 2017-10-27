using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SafeSingleInstance
    {
        private static volatile SafeSingleInstance instance;
        private static readonly object obj = new object();
        private SafeSingleInstance() { }
        public static SafeSingleInstance Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)//锁
                    {
                        if (instance == null)
                        {
                            instance = new SafeSingleInstance();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
