using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

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

            webFriet.Navigate("https://www.frietvanriet.nl/home");
        }

        private async void btnGetApi_Click(object sender, RoutedEventArgs e)
        {
            string jsonString;
            string apiUrl = "https://63c544a3f80fabd877e46625.mockapi.io/Friet";
            //https://mockapi.io/projects/63c10ff2376b9b2e64728575
            
            txbApiGoesHere.Text = "";

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

            Image myImage = new Image();
            myImage.Height = 200;
            myImage.Width = 200;
            myImage.HorizontalAlignment = HorizontalAlignment.Left;
            myImage.VerticalAlignment = VerticalAlignment.Bottom;
            myImage.Margin = new Thickness(this.Width / 2 - myImage.Width / 2 , 0, 0, this.Height / 2 - myImage.Height / 2);
            myImage.Source = new BitmapImage(new Uri("https://vrieswinkel.nl/wp-content/uploads/2021/01/FREE001-2-scaled.jpg", UriKind.Absolute));            
            mainGrid.Children.Add(myImage);

            foreach (Product product in products)
            {
                txbApiGoesHere.Text = product.Name;
                txbApiGoesHere.Text += "-";
                txbApiGoesHere.Text += product.Description;
                txbApiGoesHere.Text += "-";
                txbApiGoesHere.Text += product.Price;
                myImage.Source = new BitmapImage(new Uri(product.Image, UriKind.Absolute));
                await Task.Delay(4000);

            }

        }

        private void btnUpdateApi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGoToMenu_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Show();
        }
    }
}
