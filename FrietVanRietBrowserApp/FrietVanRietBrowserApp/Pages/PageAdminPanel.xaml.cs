using CefSharp.DevTools.Debugger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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

namespace FrietVanRietBrowserApp.Pages
{
    /// <summary>
    /// Interaction logic for PageAdminPanel.xaml
    /// </summary>
    public partial class PageAdminPanel : Page
    {
        List<string> _urlCollection= new List<string>();
        decimal _cycleSpeed = 1;
        

        public PageAdminPanel()
        {

            InitializeComponent();

            lblError.Content = String.Empty;
            
            if (File.Exists("WebsiteUrl.txt"))
            {
                string readFile = File.ReadAllText("WebsiteUrl.txt");

                string[] splitLine = readFile.Split('\n');
                foreach (var theLine in splitLine)
                {
                    _urlCollection.Add(theLine);
                    lblURL.Content += theLine;
                }

            }

            if (!CheckConnection("https://google.nl"))
            {
                lblError.Content = "Geen internet gedetecteerd";
            }
        }

        private bool CheckConnection(String URL)
        {
            try
            {
                if (!URL.StartsWith("https://"))
                {
                    URL = "https://" + URL;
                }
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    return true;
                else
                    return false;

            }
            catch
            {
                return false;
            }
        }

        private void btnPreview_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txbCycleSpeed.Text))
            {
                var cycleSpeed = decimal.TryParse(txbCycleSpeed.Text, out _cycleSpeed);
            }
            this.NavigationService.Navigate(new PageMenu(_urlCollection, _cycleSpeed * 1000));
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txbAddUrl.Text))
            {
                if (txbAddUrl.Text.Contains(" "))
                {
                    lblError.Content = "Links mogen geen spaties bevatten";
                    return;
                }
                _urlCollection.Add(txbAddUrl.Text);
                lblURL.Content += $"{txbAddUrl.Text}{Environment.NewLine}";
                //txbAddUrl.Text = "";
                using (StreamWriter bestand = File.AppendText("WebsiteUrl.txt"))
                {
                    bestand.WriteLine(txbAddUrl.Text);
                }
            }
        }


        private void btnClearLinks_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("WebsiteUrl.txt", String.Empty);
            lblURL.Content = String.Empty;
            _urlCollection.Clear();

        }

        private void btnScrape_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageScraper());

        }
    }
}
