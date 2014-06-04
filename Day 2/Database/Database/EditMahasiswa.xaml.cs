using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Database
{
    public partial class EditMahasiswa : PhoneApplicationPage
    {
        public EditMahasiswa()
        {
            InitializeComponent();
        }

        int id_mhs;
        MahasiswaContext db;

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            db = new MahasiswaContext("isostore:/Mahasiswa.sdf");
            Mahasiswa _mhs = (from item in db.mahasiswas
                              where item.id_mahasiswa == id_mhs
                              select item).FirstOrDefault();

            _mhs.nama_mahasiswa = txtNama.Text;
            _mhs.handphone_mahasiswa = txtHandphone.Text;
            _mhs.alamat_mahasiswa = txtAlamat.Text ;

            db.SubmitChanges();
            MessageBox.Show("Data Telah diubah");
        }

        
        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            if(NavigationContext.QueryString["id"] != null){
                int.TryParse(NavigationContext.QueryString["id"].ToString(), out id_mhs);
            }

            db = new MahasiswaContext("isostore:/Mahasiswa.sdf");
            Mahasiswa _mhs = (from item in db.mahasiswas 
                              where item.id_mahasiswa == id_mhs
                              select item ).FirstOrDefault();

            txtNama.Text = _mhs.nama_mahasiswa;
            txtHandphone.Text = _mhs.handphone_mahasiswa;
            txtAlamat.Text = _mhs.alamat_mahasiswa;
        }

        
    }
}