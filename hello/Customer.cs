using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainig2
{
    public  class Customer
    {
        public Customer(string customerID,string companyName )
        {
            CustomerId = customerID;
            CompanyName = companyName;
            Orders = new Order[10];

            
        }
        public string CustomerId;
        public string CompanyName;
        public string Address;
        public string City;
        public string Region;
        public string Postalcode;
        public string Country;
        public string Phone;
        public string Fax;
        public Order[] Orders;
        public override string ToString()
        {
            return $"{CustomerId},{CompanyName},{Address},{City},{Region},{Postalcode},{Country},{Phone},{Fax}";
        }


    }
    public class Order 
    {
        public Order(int orderID,DateTime orderDate,decimal total)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Total = total;
            
        }
        public int OrderID;
        public DateTime OrderDate;
        public decimal Total;
        public override string ToString() 
        {
            return $"Order id{OrderID},Date{OrderDate},total ..{Total}";
        }

    }
    public class Product : IComparable<Product>
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public Int32 UnitStocks { get; set; }
        public int CompareTo(Product? other) => UnitPrice.CompareTo(other?.UnitPrice);

        public override string ToString()
        {
            return $"Product id{ProductID},ProductName{ProductName},Category{Category}unitPrice:{UnitPrice},unit stocks:{UnitStocks}";
        }
    }
    public static class ListGenerators
    {
        public static List<Customer> Customer_List;
        public static List<Product> Product_List;

        static ListGenerators()
        {
           // Customer_List;
            Product_List = new List<Product>()
            {
                new Product {ProductID =1, ProductName ="Chail", Category ="Beverages",UnitPrice = 18.000M,UnitStocks =39},
                new Product { ProductID =2, ProductName="change",Category ="Beverages",UnitPrice =19.000M,UnitStocks =17},
                new Product{ ProductID =3, ProductName = "Anised",Category = "condiments",UnitPrice = 10.000M,UnitStocks =13},
                new Product{ ProductID =4, ProductName ="Lg",Category ="Condiments",UnitPrice =22.000M,UnitStocks = 53},
                new Product{ ProductID = 5, ProductName ="Samsong", Category = "Condiments",UnitPrice = 21.350M,UnitStocks = 0},
                new Product { ProductID = 6, ProductName = "Grandoma", Category="Condiments",UnitPrice =25.000M,UnitStocks=120},
                new Product{ProductID = 7, ProductName= "Mg",Category="produce", UnitPrice =27.000M,UnitStocks =2},
                new Product{ProductID = 8, ProductName= "Soft",Category="produce", UnitPrice =27.500M,UnitStocks =5},
                new Product{ProductID = 9, ProductName= "Done",Category="produce", UnitPrice =29.500M,UnitStocks =10},
                new Product{ProductID = 10, ProductName= "DotNet",Category="Pumb", UnitPrice =30.000M,UnitStocks =20},
            };
        }
    }
}
