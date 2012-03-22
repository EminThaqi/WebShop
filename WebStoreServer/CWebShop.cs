using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShopInterface;
using System.Windows.Forms;
namespace WebStoreServer
{
    [Serializable]

    class CWebShop : MarshalByRefObject, IWebShop
    {
        public event WebShopDelegate event_product_sold;
        private List<WebShopInterface.CProduct> productList = new List<WebShopInterface.CProduct>();
        public CWebShop()
        {
            this.productList.Add(new WebShopInterface.CProduct("macbook", 1000, 20));
            this.productList.Add(new WebShopInterface.CProduct("asus", 600, 10));
            this.productList.Add(new WebShopInterface.CProduct("iphone", 500, 15));
        }

        public bool BuyProduct (string product)
        {
            for (int i = 0; i < this.productList.Count; i++)
            {
                if (product == this.productList[i].name)
                {
                    this.productList[i].quantity--;
                    if (event_product_sold != null)
                    {
                        event_product_sold(productList);
                    }
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

        public string GetWebShopName()
        {
            MessageBox.Show("Access");
            return "Arslan's Web Store";
        }
    }
}
