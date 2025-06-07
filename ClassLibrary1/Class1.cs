using System;
using DISimpleInjector;

namespace ClassLibrary1
{
    public class Class1:ICart
    {
       
        public void teste()
        {
            var app = new DISimpleInjector.ICart;
            app.AddToCart();
        }

    }
}
