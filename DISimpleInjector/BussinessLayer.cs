using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DISimpleInjector
{
    /// <summary>
    /// modelo de regra de negócios
    /// </summary>
    public class BussinessLayer
    {
        public ICart _objcart;

        public BussinessLayer (ICart objcart)
        {
            _objcart = objcart;
        }
        /// <summary>
        /// insere no carrinho
        /// </summary>
        public void InserttoCart()
        {
            _objcart.AddToCart();
        }
    }
}
