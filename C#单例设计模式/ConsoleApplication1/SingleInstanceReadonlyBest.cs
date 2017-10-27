using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SingleInstanceReadonlyBest
    {
        private static readonly SingleInstanceReadonlyBest instance = new SingleInstanceReadonlyBest();
        static SingleInstanceReadonlyBest() { }//静态构造函数
        public static SingleInstanceReadonlyBest Instance
       {
           get
           {
               return instance;
           }
       }
    }
}
