using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region without factory pattern

            //Generally we will get the Card Type from UI.
            //Here we are hardcoded the card type
            string cardType = "MoneyBack";
            CreditCard cardDetails = null;
            //Based of the CreditCard Type we are creating the
            //appropriate type instance using if else condition
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            #endregion without factory pattern
            Console.WriteLine("------------------------------print break--------------------------------");
            #region factoryDesignPattern
            CreditCard cardDetailsF = CreditCardFactory.GetCreditCard("Platinum");

            if (cardDetailsF != null)
            {
                Console.WriteLine("CardType : " + cardDetailsF.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetailsF.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetailsF.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            #endregion factoryDesignPattern


            Console.WriteLine("------------------------------print break--------------------------------");



            #region factory method design pattern
            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            #endregion factory method design pattern
            Console.ReadKey();
        }
    }
}
