using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEx14
{
    public enum Categories
    {
        Food,
        Tehnic
    }
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public int Price { get; set; }
        public Categories Category { get; set; }
    }
}
