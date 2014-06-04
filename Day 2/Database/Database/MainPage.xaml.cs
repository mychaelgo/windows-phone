using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Database.Resources;

namespace Database
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

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddMahasiswa.xaml", UriKind.RelativeOrAbsolute));
        }

        MahasiswaContext db;
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();

            if(NavigationService.CanGoBack){
                while(NavigationService.RemoveBackEntry() != null){
                    NavigationService.RemoveBackEntry();
                }
            }
        }

        private void RefreshData()
        {
            db = new MahasiswaContext("isostore:/Mahasiswa.sdf");
            if (!db.DatabaseExists())
            {
                db.CreateDatabase();
            }
            MainListBox.ItemsSource = db.mahasiswas;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            int id =((sender as MenuItem).DataContext as Mahasiswa).id_mahasiswa;
            MessageBox.Show(id.ToString());

            NavigationService.Navigate(new Uri("/EditMahasiswa.xaml?id="+id.ToString(),UriKind.RelativeOrAbsolute));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            int id = ((sender as MenuItem).DataContext as Mahasiswa).id_mahasiswa;
            db = new MahasiswaContext("isostore:/Mahasiswa.sdf");
            Mahasiswa _mhs = (from item in db.mahasiswas
                              where item.id_mahasiswa == id
                              select item).FirstOrDefault();

            db.mahasiswas.DeleteOnSubmit(_mhs);
            db.SubmitChanges();
            RefreshData();

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