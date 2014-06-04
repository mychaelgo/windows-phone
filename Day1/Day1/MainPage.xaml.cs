using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Day1.Resources;

namespace Day1
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
            //Di jalanin saat Page dibuka
            List<Contact> _contacts = new List<Contact>();
            _contacts.Add(new Contact() { nama="mychaelgo 1", alamat="alamat 1" , telp="telp 1",foto="./Images/foto1.jpg"});
            _contacts.Add(new Contact() { nama = "mychaelgo 2", alamat = "alamat 2", telp = "telp 2", foto = "./Images/foto1.jpg" });
            MainListBox.ItemsSource = _contacts;




            List<string> _words = new List<string>();
            _words.Add("Kevin");
            _words.Add("Budi");
            //myAutoComplete.itemSource = _words;

        }

        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try {
                MessageBox.Show((MainListBox.SelectedItem as Contact).nama.ToString());
                MainListBox.SelectedItem = null;
                 
            }catch{
                
            }
        }

        private void PindahHalaman(object sender, RoutedEventArgs e)
        {
            //Source luar dari internet  pke absolute
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void HalamanKalkulator(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Kalkulator.xaml", UriKind.RelativeOrAbsolute));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}