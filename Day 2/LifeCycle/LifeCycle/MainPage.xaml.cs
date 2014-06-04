
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LifeCycle.Resources;
using System.Windows.Media.Imaging;

namespace LifeCycle
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            TestMethod();
        }


        private async void TestMethod(){
            Uri _uri = new Uri("http://www.controltheweb.com/images/desktop-background-large/MIT.jpg");
            MyImage.Source = new BitmapImage(_uri);
        }
}
}