using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pavol_projjt_mvc_1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string   Name { get; set; }
        public Decimal Price { get; set; }
        public string Slug => Name.Replace(' ','-');
}
