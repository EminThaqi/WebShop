using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting; //for the RemotingConfiguration Class
using System.Runtime.Remoting.Channels; //for the ChannelServices Class
using System.Runtime.Remoting.Channels.Http; //for the HttpChannel Class
using System.Runtime.Remoting.Channels.Tcp; //for the HttpChannel Class
using WebShopInterface;
using System.Net;
using System.Net.NetworkInformation;
namespace WebShopClient
{
    public partial class Form1 : Form
    {
        IWebShop localWebShopProxy;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_getName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(localWebShopProxy.GetWebshopName());
        }

        private void btn_getInventory_Click(object sender, EventArgs e)
        {

            MessageBox.Show(localWebShopProxy.GetProductList());
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            string product = this.txtBox_itemName.Text;
            if (localWebShopProxy.BuyProduct(product))
                MessageBox.Show("Purchased: " + product + " price: $" + localWebShopProxy.GetProductInfo(product));
            else
                MessageBox.Show("No such product");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = "tcp://" + this.textBox1.Text + ":13101/shop";
            localWebShopProxy = (IWebShop)Activator.GetObject(typeof(IWebShop), address);
        }
    }
}
