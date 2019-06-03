using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerDS
/// </summary>
public class CustomerDS
{
    public CustomerDS()
    {


    }
    public List<Customer> getCustomers(int startIndex, int maxRows)
    {
        using (NorthwindEntities entities = new NorthwindEntities())
        {
            return (from customer in entities.Customers select customer)
                .OrderBy(customer => customer.CustomerID)
                .Skip(startIndex)
                .Take(maxRows).ToList();
        }
    }

    public int getCustomersCount()
    {
        using (NorthwindEntities entities = new NorthwindEntities())
        {
            return entities.Customers.Count();
        }
    }
    
}