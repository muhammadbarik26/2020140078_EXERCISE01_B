using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _2020140078_EXERCISE01_B
{
    class Program
    {

        public SqlDataReader dataread;

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-LO9JU2EQ\\SQLEXPRESS;database=EXERCISE01;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table KARYAWAN (ID_Karyawan char(5) Primary Key NOT NULL,Nama_Karyawan varchar(50),Alamat_Karyawan varchar(25))"
                    + "create table KONSUMEN (ID_Konsumen char (5) Primary Key NOT NULL,Nama_Konsumen varchar (50) NOT NULL,Alamat_Konsumen varchar (25) NOT NULL)"
                    + "create table SUPLIER (ID_Suplier char (5) Primary Key NOT NULL,Nama_Suplier varchar (50) NOT NULL)"
                    + "create table APOTEKER (ID_Apoteker char (5) Primary Key NOT NULL,Nama_Apoteker varchar (50) NOT NULL,Alamat_Apoteker varchar (25) NOT NULL)"
                    + "create table OBAT (ID_Obat char (5) Primary Key NOT NULL,Nama_Obat varchar (20) NOT NULL,Jenis_Obat varchar (20) NOT NULL)"
                    + "create table TRANSAKSI (ID_Transaksi char (5) Primary Key NOT NULL,ID_Karyawan char (5) Foreign Key References Karyawan (ID_Karyawan) NOT NULL,ID_Konsumen char (5) Foreign Key References Konsumen (ID_Konsumen) NOT NULL,ID_Obat char (5) Foreign Key References Obat (ID_Obat) NOT NULL,Tanggal datetime,Jumlah int,Total decimal)", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel Sukses Dibuat !!!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Tabel Yang Anda Buat Gagal : (" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-LO9JU2EQ\\SQLEXPRESS;database=EXERCISE01;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Karyawan (ID_Karyawan,Nama_Karyawan,Alamat_Karyawan) values ('001','BARIK','YOGYAKARTA)"
                    + "insert into Karyawan (ID_Karyawan,Nama_Karyawan,Alamat_Karyawan) values ('002','OURA','BATAM')"
                    + "insert into Karyawan (ID_Karyawan,Nama_Karyawan,Alamat_Karyawan) values ('003','VYN','JAKARTA')"
                    + "insert into Karyawan (ID_Karyawan,Nama_Karyawan,Alamat_Karyawan) values ('004','MARSHA','JAKARTA')"
                    + "insert into Karyawan (ID_Karyawan,Nama_Karyawan,Alamat_Karyawan) values ('005','ALBERT','BALI')"
                    + "insert into Konsumen (ID_Konsumen,Nama_Konsumen,Alamat_Konsumen) values ('101','CW','JAKARTA')"
                    + "insert into Konsumen (ID_Konsumen,Nama_Konsumen,Alamat_Konsumen) values ('102','CLAY','JAKARTA')"
                    + "insert into Konsumen (ID_Konsumen,Nama_Konsumen,Alamat_Konsumen) values ('103','SKYLAR','JAKARTA')"
                    + "insert into Konsumen (ID_Konsumen,Nama_Konsumen,Alamat_Konsumen) values ('104','AETHER','JAKARTA')"
                    + "insert into Konsumen (ID_Konsumen,Nama_Konsumen,Alamat_Konsumen) values ('105','VIOLENCE','JAKARTA')"
                    + "insert into Suplier (ID_Suplier,Nama_Suplier) values ('200','HIGH')"
                    + "insert into Suplier (ID_Suplier,Nama_Suplier) values ('201','GODIVA')"
                    + "insert into Suplier (ID_Suplier,Nama_Suplier) values ('202','KABUKI')"
                    + "insert into Suplier (ID_Suplier,Nama_Suplier) values ('203','FLUFFY')"
                    + "insert into Suplier (ID_Suplier,Nama_Suplier) values ('204','FACEHUGGER')"
                    + "insert into Apoteker (ID_Apoteker,Nama_Apoteker,Alamat_Apoteker) values ('301','REKT','JAKARTA')"
                    + "insert into Apoteker (ID_Apoteker,Nama_Apoteker,Alamat_Apoteker) values ('302','LUMINAIRE','JAKARTA')"
                    + "insert into Apoteker (ID_Apoteker,Nama_Apoteker,Alamat_Apoteker) values ('303','WANN','JAKARTA')"
                    + "insert into Apoteker (ID_Apoteker,Nama_Apoteker,Alamat_Apoteker) values ('304','FERXIIC','JAKARTA')"
                    + "insert into Apoteker (ID_Apoteker,Nama_Apoteker,Alamat_Apoteker) values ('305','ANTIMAGE','JAKARTA')"
                    + "insert into Obat (ID_Obat,Nama_Obat,Jenis_Obat) values ('401','PARACETAMOL','OBAT DEMAM')"
                    + "insert into Obat (ID_Obat,Nama_Obat,Jenis_Obat) values ('402','INTUNAL','OBAT FLU')"
                    + "insert into Obat (ID_Obat,Nama_Obat,Jenis_Obat) values ('403','PROCOLD','OBAT BATUK')"
                    + "insert into Obat (ID_Obat,Nama_Obat,Jenis_Obat) values ('404','INSTO','OBAT MATA')"
                    + "insert into Obat (ID_Obat,Nama_Obat,Jenis_Obat) values ('405','AMOXILIN','OBAT PEREDA NYERI')"
                    + "insert into Transaksi (ID_Transaksi,ID_Karyawan,ID_Konsumen,ID_Obat,Tanggal,Jumlah,Total) values ('501','001','101','401',12-03-2022,1,5000)"
                    + "insert into Transaksi (ID_Transaksi,ID_Karyawan,ID_Konsumen,ID_Obat,Tanggal,Jumlah,Total) values ('502','002','102','402',16-04-2022,1,5000)"
                    + "insert into Transaksi (ID_Transaksi,ID_Karyawan,ID_Konsumen,ID_Obat,Tanggal,Jumlah,Total) values ('503','003','103','403',18-05-2022,1,5000)"
                    + "insert into Transaksi (ID_Transaksi,ID_Karyawan,ID_Konsumen,ID_Obat,Tanggal,Jumlah,Total) values ('504','004','104','404',19-06-2022,1,5000)"
                    + "insert into Transaksi (ID_Transaksi,ID_Karyawan,ID_Konsumen,ID_Obat,Tanggal,Jumlah,Total) values ('505','005','105','405',11-07-2022,1,5000)", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }


        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().InsertData();
        }
    }
}
