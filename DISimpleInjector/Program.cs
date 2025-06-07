using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace DISimpleInjector
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            var lifestyle = Lifestyle.Singleton;
            container.Register<ICart,DataAccessLayer>(lifestyle);
            var BL = container.GetInstance<BussinessLayer>();
            BL.InserttoCart();
            Console.ReadLine();
        }
    }
}
