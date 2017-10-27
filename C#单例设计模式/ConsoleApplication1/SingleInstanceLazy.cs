using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SingleInstanceLazy
    {
        private static readonly Lazy<SingleInstanceLazy> instance = new Lazy<SingleInstanceLazy>(() => new SingleInstanceLazy());
        private SingleInstanceLazy() { }
        public static SingleInstanceLazy Instance
       {
           get
           {
               return instance.Value;
           }
       }
    }
}
