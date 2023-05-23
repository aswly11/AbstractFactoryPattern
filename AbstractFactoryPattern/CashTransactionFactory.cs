using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CashTransactionFactory : ITransactionFactory

    {
        public IPayment CreatePaymentMethod()
        {
            return new CardPayment();
        }

        public IBill CreateBill()
        {
            return new PurchasingBill();
        }
    }
}
