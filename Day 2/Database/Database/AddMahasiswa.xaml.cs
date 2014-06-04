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
    public partial class AddMahasiswa : PhoneApplicationPage
    {
        public AddMahasiswa()
        {
            InitializeComponent();
        }

        MahasiswaContext db;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db = new MahasiswaContext("isostore:/Mahasiswa.sdf");
            if(!db.DatabaseExists()){
                db.CreateDatabase();
            }

            Mahasiswa _mhs = new Mahasiswa();
            _mhs.nama_mahasiswa = txtNama.Text;
            _mhs.alamat_mahasiswa = txtAlamat.Text;
            _mhs.handphone_mahasiswa = txtHandphone.Text;

            db.mahasiswas.InsertOnSubmit(_mhs);
            db.SubmitChanges();

            MessageBox.Show("Data Telah Tersimpan");
            txtAlamat.Text = "";
            txtHandphone.Text = "";
            txtNama.Text = "";


        }
    }
}