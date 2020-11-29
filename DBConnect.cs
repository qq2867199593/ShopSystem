using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ShopSystem
{
    class DBConnect
    {
        private string conStr = "Data Source=.;Initial Catalog=ShopSystem;User Id=zzx;Password=zzx7845zzx;";

        public Tuple<bool,bool> AccountFind(string account,string password)
        {
            string sqlStr = string.Format("select uId,uIsAdmin from userInfo where uAccount = '{0}' AND uPassword = '{1}'", account, password);
            bool isExist = false;
            bool isAdmin = false;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                string[] tempbox = new string[2];
                
                try
                {
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        tempbox[0] = sdr[0].ToString();
                        tempbox[1] = sdr[1].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
                finally
                {
                    conn.Close();
                }

                if (tempbox[0] != null)
                {
                    isExist = true;
                }
                if (tempbox[1] == "1")
                {
                    isAdmin = true;
                }
            }

            return new Tuple<bool, bool>(isExist, isAdmin);
        }

        public void GoodsInsert(string goodsname)
        {

        }
    }
}
