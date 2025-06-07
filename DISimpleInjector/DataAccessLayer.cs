using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISimpleInjector
{
    public class DataAccessLayer : ICart
    {
        public string AddToCart()
        {
            string val = "Simple Injector é rápido qdo comparado a Ninject";
            Console.Write(val);
            return val;
        }
}
