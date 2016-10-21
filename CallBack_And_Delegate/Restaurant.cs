using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack_And_Delegate
{
    class Restaurant
    
    {
        public string _name;

        public Restaurant(string name)
        {
            _name = name;
        }
        public static void Notify(string msg)
        {
            System.Console.WriteLine(msg);
            System.Console.WriteLine("Notify回调函数被调用");
        }

        public void OrderAccpte(Program.EatDinnercallback callback)
        {
            callback(_name + "餐厅接单啦");
        }
    }
}
