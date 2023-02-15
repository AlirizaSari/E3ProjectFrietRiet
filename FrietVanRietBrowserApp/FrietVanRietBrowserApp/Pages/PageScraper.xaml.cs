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

            
        }

        private void btnGetScraper_Click(object sender, RoutedEventArgs e)
        {
  //          var html =
  //      @"<TD class=texte width=""50%"">
		//	<DIV align=right>Name :<B> </B></DIV>
		//</TD>
		//<TD width=""50%"">
  //  		<INPUT class=box value=John itemscope='test' maxLength=16 size=16 name=user_name>
  //  		<INPUT class=box value=Tony itemscope='test' maxLength=16 size=16 name=user_name>
  //  		<INPUT class=box value=Jams itemscope='test' maxLength=16 size=16 name=user_name>
  //          <p itemscope='hallo'>Goedendag</p>
		//</TD>
		//<TR vAlign=center>";

  //          var htmlDoc = new HtmlDocument();
  //          htmlDoc.LoadHtml(html);

            string url = "https://frietvanriet.foodticket.nl/foodticket/cgi/bestel.cgi#menu";
            HtmlWeb web = new HtmlWeb();
            var myHtmlDoc = web.Load(url);

            var getArticle = myHtmlDoc.DocumentNode.SelectNodes("//*[@itemtype=\"http://schema.org/Product\"]");



            //string myName = htmlDoc.Text;


            //string name = htmlDoc.DocumentNode
            //                .SelectNodes("//td/p")
            //                .First()
            //                .Attributes["itemscope"].Value;

            //Console.WriteLine(name);
        }
    }
}
