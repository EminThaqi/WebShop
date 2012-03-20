using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace WebShopInterface
{
    public delegate void WebSHopDelegate(List<CProduct> product_list);
    public class IWebShop
    {
        event WebSHopDelegate event_product_sold;

        string GetWebShopName();
        string GetProductList();
        string GetProductInfo(string ProductId);
        bool BuyProduct(string ProductId);
    }

    [Serializable]
    public class CProduct
    {
        public string Ttile {get; set;}
        public int Stock {get; set;}
    }

}
