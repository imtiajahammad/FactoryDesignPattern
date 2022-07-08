using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class CreditCardMethodFactory
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
    public class MoneyBackFactory : CreditCardMethodFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new MoneyBack();
            return product;
        }
    }
    public class PlatinumFactory : CreditCardMethodFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Platinum();
            return product;
        }
    }
    public class TitaniumFactory : CreditCardMethodFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
}
