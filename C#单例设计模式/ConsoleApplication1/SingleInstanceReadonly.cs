using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SingleInstanceReadonly
    {
        private static readonly SingleInstanceReadonly instance = new SingleInstanceReadonly();
        private SingleInstanceReadonly() { }
       public static SingleInstanceReadonly Instance
       {
           get
           {
               return instance;
           }
       }
    }
}
