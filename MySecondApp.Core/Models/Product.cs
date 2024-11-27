using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondApp.Core.Models;
public class Product
{
    public string ProductName
    {
        get; set;
    }
    public string Country
    {
        get; set;
    }
    public string City
    {
        get; set;
    }
    public double UnitPrice
    {
        get; set;
    }
    public int Quantity
    {
        get; set;
    }
    public DateTime OrderDate
    {
        get; set;
    }
}
