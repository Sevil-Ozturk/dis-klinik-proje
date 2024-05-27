using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DisProje01
{
    internal class ConnectionString
    {
        public SqlConnection Getbaglanti()
        {
            SqlConnection baglanti= new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-D9U083R\SQLEXPRESS01;Initial Catalog=dis_klinik_proje;Integrated Security=True";
            return baglanti;
        }
    }
}
