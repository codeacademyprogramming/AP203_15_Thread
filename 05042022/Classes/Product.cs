using Classes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Product
    {
        private static int _totalCount;
        public Product()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No { get; }
        public double Price { get; set; }
        public string Name { get; set; }    
        public DateTime ExpDate { get; set; }
        public ProductType Type { get; set; }
    }
}
