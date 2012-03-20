using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopInterface;
using System.Windows.Forms;

namespace WebStoreServer
{
    [Serializable]
    class CProduct
    {
        public CProduct(string name, int price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string name
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }
        public int quantity
        {
            get;
            set;
        }
    }
    class CWebShop : MarshalByRefObject, IWebShop
    {
        private List<CProduct> productList = new List<CProduct>();
        public CWebShop()
        {
            this.productList.Add(new CProduct("macbook", 1000, 20));
            this.productList.Add(new CProduct("asus", 600, 10));
            this.productList.Add(new CProduct("iphone", 500, 15));
        }

        public bool BuyProduct (string product)
        {
            for (int i = 0; i < this.productList.Count; i++)
            {
                if (product == this.productList[i].name)
                {
                    this.productList[i].quantity--;
                    return true;
                }
            }
            return false;
        }

        public string GetProductInfo(string product)
        {
            for (int i = 0; i < this.productList.Count; i++)
            {
                if (product == this.productList[i].name)
                    return "" + this.productList[i].price.ToString() + "\n" + this.productList[i].quantity.ToString();
            }
            return "none";
        }

        public string GetProductList()
        {
            string output = "";
            for (int i = 0; i < this.productList.Count; i++)
            {
                output += this.productList[i].name + " price: "+ this.productList[i].price.ToString() + "\t quantity:"
                    + this.productList[i].quantity.ToString() + "\n";
            }

            return output;
        }

        public string GetWebshopName()
        {
            MessageBox.Show("Access");
            return "Arslan's Web Store";
        }
        
    }
}
