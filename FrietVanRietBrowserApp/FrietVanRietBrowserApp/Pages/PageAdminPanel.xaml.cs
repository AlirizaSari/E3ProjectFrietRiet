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
        public PageAdminPanel()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, RoutedEventArgs e)
        {
            string hello = "Test gelukt";

            this.NavigationService.Navigate(new PageMenu(txbAddUrl.Text));
        }
    }
}
