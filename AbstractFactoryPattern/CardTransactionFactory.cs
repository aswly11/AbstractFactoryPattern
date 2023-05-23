using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class CardTransactionFactory : ITransactionFactory
    {
        public IBill CreateBill()
        {
            return new SellingBill();
        }

        public IPayment CreatePaymentMethod()
        {
            return new CardPayment();
        }
    }
}
