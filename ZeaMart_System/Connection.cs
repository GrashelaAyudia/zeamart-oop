using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ZeaMart_System
{
    internal class Connection
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection konektion = null;

            try
            {
                string sConnstring = "server = localhost; database = db_zeamart_novel; uid=root; password=sela;";
                konektion = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return konektion;
        }
    }
}
