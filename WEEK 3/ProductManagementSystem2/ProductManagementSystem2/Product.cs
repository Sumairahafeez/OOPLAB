using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem2
{
    internal class Products
    {
        public string id;
        public string name;
        public float price;
        public string category;
        public string BrandName;
        public string Country;
        public void ShowProducts(ref int productIndex)
        {
           
                Console.WriteLine(id + "\t" + name + "\t" + price + "\t" + category + "\t" + BrandName + "\t" + Country);
            
          
        }
        public float StoreWorth(ref float worth, ref int productIndex)
        {
            
                worth += price;
            
            return worth;
        }
    }
}
