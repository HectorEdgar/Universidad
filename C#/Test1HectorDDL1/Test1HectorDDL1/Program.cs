using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HectorDLL;

namespace Test1HectorDDL1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new NorthwindEntities())
            {
                var custWithOrders = context.Orders
                    .Where(o => o.OrderDate > new DateTime(1998, 1, 1));

                foreach (var cust in custWithOrders)
                {
                    Console.WriteLine("{0} from {1} Ordered Item on {2}",
                        cust.Customer.CustomerID,
                        cust.Customer.CompanyName,
                        cust.OrderDate);
                }
                Console.ReadLine();
            }



        }
    }
}
