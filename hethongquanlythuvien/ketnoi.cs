using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hethongquanlythuvien
{
    internal class ketnoi
    {
        string conStr = @"Data Source=LAPTOP-0A2731OL\SQLEXPRESS01;Initial Catalog=duanqlthuvien;Integrated Security=True";
        SqlConnection conn;
        public ketnoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataSet laydulieu(string truyvan)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            da.Fill(ds);
            return ds;
        }
        public bool thucthi(string truyvan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r > 0;
        }
    }
}
