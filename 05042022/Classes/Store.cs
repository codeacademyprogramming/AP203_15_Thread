using Classes.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Store
    {
        private List<Product> _products = new List<Product>();
        public List<Product> Products { get; }
        public void AddProduct(Product product)
        {
            _products.Add(product); 
        }

        public List<Product> GetExpiredProducts()
        {
            return _products.FindAll(x => x.ExpDate.Date < DateTime.Now.Date);
        }
        public List<Product> GetproductsByType(ProductType type)
        {
            return _products.FindAll(x => x.Type == type);
        }

        public List<Product> FilterProductsByExpMonth(int month)
        {
            DateTime date = DateTime.Now.AddMonths(month);

            //Product product = _products.Find(x => x.No == 1);
            //var result = (product.ExpDate - DateTime.Now).Days / (365.25 / 12);

            return _products.FindAll(x => x.ExpDate.Date >= date.Date);
        }
    }
}
