using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack_And_Delegate
{
    class TaxiCompany
    {
        public static void CallTheTaxi(string msg)
        {
            System.Console.WriteLine("CallTheTaxi回调函数被调用,立刻约车，去吃饭");
        }
    }
}
