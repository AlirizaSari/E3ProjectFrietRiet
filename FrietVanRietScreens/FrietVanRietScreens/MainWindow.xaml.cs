using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FrietVanRietScreens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetApi_Click(object sender, RoutedEventArgs e)
        {
            string apiUrl = "https://63c544a3f80fabd877e46625.mockapi.io/Friet";
            //https://mockapi.io/projects/63c10ff2376b9b2e64728575
            
            txbApiGoesHere.Text = "";

            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format(apiUrl));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Console.WriteLine(WebResp.StatusCode);
            Console.WriteLine(WebResp.Server);

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(jsonString);

            foreach (Product product in products)
            {
                txbApiGoesHere.Text += $"{product.Id}. Naam: {product.Name}\tBeschrijving: {product.Description}{Environment.NewLine}";
            }
        }
    }
}
