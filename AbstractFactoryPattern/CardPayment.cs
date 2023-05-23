using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class CardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Pay with Card ");
        }
    }
}
