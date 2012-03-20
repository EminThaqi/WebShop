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
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels.Tcp;

namespace WebStoreServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //TcpServerChannel channel = new TcpServerChannel(13101);
            //ChannelServices.RegisterChannel(channel, false);
            //RemotingConfiguration.RegisterWellKnownServiceType(
            //typeof(CWebShop),
            //"shop.soap",
            //WellKnownObjectMode.Singleton
            //);
            RemotingConfiguration.Configure("WebStoreServer.exe.config", false);
        }
    }
}
