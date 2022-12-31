using Chapter_9.Model.Data;
using Chapter_9.ModelView.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_9.ModelView.ModelViewData
{
    public class ModelViewProducts : IModelViewProducts
    {
        public List<ProductsData> GetproductsData()
        {
            List<ProductsData> items = new List<ProductsData>();

            items.Add(new ProductsData { Name = "Wood tools", Number = "10001" });
            items.Add(new ProductsData { Name = "Steel tools", Number = "10002" });
            items.Add(new ProductsData { Name = "Kitchen furnushed", Number = "10003" });
            items.Add(new ProductsData { Name = "Living room stuffs", Number = "10004" });
            items.Add(new ProductsData { Name = "Offices goods", Number = "10005" });

            return items;
        }

        public ProductsData productsData(string str)
        {
            throw new NotImplementedException();
        }
    }
}
