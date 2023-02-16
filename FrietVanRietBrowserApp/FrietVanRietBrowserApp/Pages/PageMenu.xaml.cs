using CefSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace FrietVanRietBrowserApp.Pages
{
    /// <summary>
    /// Interaction logic for PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        List<string> _receiveMessage = new List<string>();
        decimal _cycleSpeed;


        public PageMenu(List<string> receiveMessage, decimal cycleSpeed)
        {
            InitializeComponent();

            _receiveMessage = receiveMessage;

            if (receiveMessage.Count == 0)
            {
                webFriet.Address = "https://frietvanriet.foodticket.nl/foodticket/cgi/bestel.cgi";
            }

            _cycleSpeed = cycleSpeed;

        }

        private async void webFriet_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string url in _receiveMessage)
            {
                webFriet.Address = url;
                await Task.Delay((int)_cycleSpeed);
            }
        }
    }
}
