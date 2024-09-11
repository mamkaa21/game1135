using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135
{
    [MysqlTable("employee")]
    public class Employee: BaseModel
    {
        [MysqlTable("id")]
        public int ID { get; set; }
        [MysqlTable("firstname")]
        public string FirstName { get; set; }
        [MysqlTable("lastname")]
        public string LastName { get; set; }
        [MysqlTable("role")]
        public string Role { get; set; }
        [MysqlTable("id_gamestudio")]
        public int ID_GameStudio { get; set; }
    }
}
