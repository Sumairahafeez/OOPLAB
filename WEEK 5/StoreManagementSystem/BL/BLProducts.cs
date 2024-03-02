using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem.BL
{
    internal class BLProducts
    {
        public string Name;
        public string Category;
        public float Price;
        public int AvailableStock;
        public int ThresholdQuantity;
         public BLProducts(string name, string category, float price, int availableStock)
        {
            Name = name;
            Category = category;
            Price = price;
            AvailableStock = availableStock;
            ThresholdQuantity = 10;
        }
        public float caluclatePrice()
        {
            if(Category == "Grocery")
            {
                Price += Price * 0.1f;
            }
            else if(Category == "Fruit")
            {
                Price += Price * 0.05f;
            }
            else
            {
                Price += Price * 0.15f;
            }
            return Price;
        }
        public bool CheckStock()
        {
            if(AvailableStock < ThresholdQuantity)
            {
                return true;
            }
            return false;
        }
    }
}
