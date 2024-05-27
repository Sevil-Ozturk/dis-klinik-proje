using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisProje01
{
    internal class Kullanicilar
    {
        public void HastaEkle(string query)
        {
            ConnectionString benimBaglantim = new ConnectionString();
            SqlConnection baglanti = benimBaglantim.Getbaglanti();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            baglanti.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            baglanti.Close();

        }
        public void HastaSil(string query)
        {
            ConnectionString benimBaglantim = new ConnectionString();
            SqlConnection baglanti = benimBaglantim.Getbaglanti();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            baglanti.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        public void HastaGuncelle(string query)
        {
            ConnectionString benimBaglantim = new ConnectionString();
            SqlConnection baglanti = benimBaglantim.Getbaglanti();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            baglanti.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataSet HastaTblGoster(string query)
        {
            ConnectionString benimBaglantim = new ConnectionString();
            SqlConnection baglanti = benimBaglantim.Getbaglanti();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}
