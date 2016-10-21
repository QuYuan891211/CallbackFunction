using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CallBack_And_Delegate
{
    class Program
    {
        public delegate void EatDinnercallback(string msg);
        static void Main(string[] args)
        {
            //1.约定回调函数调用的方法
            EatDinnercallback callback;
            callback = Restaurant.Notify;
            callback += TaxiCompany.CallTheTaxi;

            //2.创建餐厅的实体对象，餐厅订座成功就去个餐厅吃饭
            Restaurant McDonload = new Restaurant("McDonload");
            //3. 订座成功，收到回执
            McDonload.OrderAccpte(callback);

            System.Console.ReadKey();
        }
    }
}
