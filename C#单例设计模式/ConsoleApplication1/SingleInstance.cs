using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public sealed class SingleInstance
    {
        private static SingleInstance instance;
        private SingleInstance() { }
        public static SingleInstance Instance
        {
            get{
                if (null == instance)
                {
                    instance = new SingleInstance();
                }
                return instance;
            }
        }
    }
}
