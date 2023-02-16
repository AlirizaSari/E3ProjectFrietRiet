using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
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
using CsvHelper;
using HtmlAgilityPack;

namespace FrietVanRietBrowserApp.Pages
{
    /// <summary>
    /// Interaction logic for PageScraper.xaml
    /// </summary>
    public partial class PageScraper : Page
    {
        public class Row
        {
            public string Title { get; set; }
        }

        public PageScraper()
        {
            InitializeComponent();

            lblMenuItems.Width = SystemParameters.PrimaryScreenWidth - 20;
            
        }

        private void btnGetScraper_Click(object sender, RoutedEventArgs e)
        {
            lblMenuItems.FontSize = 15;
            lblMenuItems.Content = "";

            string url = "https://frietvanriet.foodticket.nl/foodticket/cgi/bestel.cgi#menu";
            HtmlWeb web = new HtmlWeb();
            var myHtmlDoc = web.Load(url);

            var getArticle = myHtmlDoc.DocumentNode.SelectNodes("//*[@itemtype=\"http://schema.org/Product\"]/div/h4[@itemprop=\"name\"]/text()");
            var getPrice = myHtmlDoc.DocumentNode.SelectNodes("//*[@itemtype=\"http://schema.org/Offer\"]//div//span[@itemprop=\"price\"]/text()");


            int fourCounter = 0;
            int counter = 1;
            foreach(var item in getArticle )
            {

                if (item.InnerText.ToString().Contains("+"))
                {
                    continue;
                }
                else
                {
                    if (counter % 4 == 0)
                    {
                        lblMenuItems.Content += $"{Environment.NewLine}";
                        if (fourCounter < 4)
                        {
                            fourCounter++;
                        }
                        else
                        {
                            fourCounter = 0;
                        }
                    }
                    lblMenuItems.Content += $"{item.InnerText,-50}{string.Empty,10}{getPrice[counter - 1].InnerText,10}";
                    counter++;
                }


                
            }

        }

    }
}
