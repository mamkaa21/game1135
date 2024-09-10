using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using game1135;
namespace game1135
{
    public class MysqlClass
    {
        MySqlConnection mySqlConnection;
        public MysqlClass()
        {
            mySqlConnection = new MySqlConnection("server=192.168.200.13;user=student;password=student;database=games_1135;Character Set=utf8mb4");

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}