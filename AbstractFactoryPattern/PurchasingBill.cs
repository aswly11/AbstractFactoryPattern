using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PurchasingBill : IBill
    {
        public void Create()
        {
            Console.WriteLine("Purchasing Bill Created");
        }
    }
}
