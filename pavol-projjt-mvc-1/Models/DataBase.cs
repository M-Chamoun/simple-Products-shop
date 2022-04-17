using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pavol_projjt_mvc_1.Models
{
    public class DataBase
    {
        public static List<Product> GetProducts() {
            // return  new List<Product>() { 
            List<Product> products = new List<Product>() {
        new Product{
        ProductID=1,
        Name="Product 1",
        Price=(Decimal)499.00
        },
                new Product{
        ProductID=2,
        Name="Product 2",
        Price=(Decimal)600.00
        },
                new Product{
        ProductID=3,
        Name="Product 3",
        Price=(Decimal)700.00
        } ,
                new Product{
        ProductID=4,
        Name="Product 4",
        Price=(Decimal)800.00
        } ,
                new Product{
        ProductID=5,
        Name="Product 5",
        Price=(Decimal)800.00
        } 
            
            };
            return products;

           }
    }
        
}

