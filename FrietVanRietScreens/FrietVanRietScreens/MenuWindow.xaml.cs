using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace FrietVanRietScreens
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            string jsonString;
            string apiUrl = "https://63c544a3f80fabd877e46625.mockapi.io/Friet";
            //https://mockapi.io/projects/63c10ff2376b9b2e64728575

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(apiUrl));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Debug.WriteLine(WebResp.StatusCode);
            Debug.WriteLine(WebResp.Server);

            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            foreach (Product product in products)
            {
                lstProductsName.Items.Add(((Product)product).Name);
                lstProductsDescription.Items.Add(((Product)product).Description);
                lstProductsPrice.Items.Add(((Product)product).Price.ToString());
                
            }

            
        }
    }
}
