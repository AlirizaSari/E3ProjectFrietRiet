using System;
using System.Collections.Generic;
using System.Linq;
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

            lblURL.Content = "";
        }

        private void btnPreview_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageMenu(_urlCollection, _cycleSpeed * 1000));
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txbAddUrl.Text))
            {
                _urlCollection.Add(txbAddUrl.Text);
                lblURL.Content += $"{txbAddUrl.Text}{Environment.NewLine}";
                txbAddUrl.Text = "";
            }

            if(!string.IsNullOrEmpty(txbCycleSpeed.Text))
            {
                _ = decimal.TryParse(txbCycleSpeed.Text, out _cycleSpeed);
            }
        }

        private void btnScrape_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageScraper());

        }
    }
}
