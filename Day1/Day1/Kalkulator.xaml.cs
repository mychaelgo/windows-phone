using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Day1
{
    public partial class Kalkulator : PhoneApplicationPage
    {
        public Kalkulator()
        {
            InitializeComponent();
        }


        int bil1, bil2;
        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(angka1.Text , out bil1);
            int.TryParse(angka2.Text, out bil2);

            MessageBox.Show(bil1.ToString() + " + " + bil2.ToString() + " = " + (bil1+bil2).ToString());
        }

        private void btnKurang_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(angka1.Text, out bil1);
            int.TryParse(angka2.Text, out bil2);

            MessageBox.Show(bil1.ToString() + " - " + bil2.ToString() + " = " + (bil1 - bil2).ToString());
        }

        private void btnBagi_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(angka1.Text, out bil1);
            int.TryParse(angka2.Text, out bil2);

            MessageBox.Show(bil1.ToString() + " / " + bil2.ToString() + " = " + (bil1 / bil2).ToString());
        }

        private void btnKali_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(angka1.Text, out bil1);
            int.TryParse(angka2.Text, out bil2);
            
            MessageBox.Show(bil1.ToString() + " * " + bil2.ToString() + " = " + (bil1 * bil2).ToString());
        }
    }
}