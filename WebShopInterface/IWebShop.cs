using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WebShopInterface
{
    public delegate void WebShopDelegate(List<CProduct> productList);
    public interface IWebShop
    {
        event WebShopDelegate event_product_sold;

        string GetWebShopName();
        string GetProductList();
        string GetProductInfo(string ProductId);
        bool BuyProduct(string ProductId);

    }

    [Serializable]
    public class CProduct
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

}
