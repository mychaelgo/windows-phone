using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace Database
{
    [Table] 
    public class Mahasiswa
    {
        [Column(IsPrimaryKey= true, IsDbGenerated= true, DbType="INT NOT NULL Identity")]
        public int id_mahasiswa{get;set;}

        [Column]
        public string nama_mahasiswa{get;set;}
        
        [Column]
        public string handphone_mahasiswa{get;set;}

        [Column]
        public string alamat_mahasiswa{get;set;}


    }

    public class MahasiswaContext : DataContext {
        public Table<Mahasiswa> mahasiswas;
        public MahasiswaContext(string connectionstring) : base(connectionstring) { }
    }
}
