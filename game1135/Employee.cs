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
        [MysqlColumn("firstname")]
        public string FirstName { get; set; }
        [MysqlColumn("lastname")]
        public string LastName { get; set; }
        [MysqlColumn("role")]
        public string Role { get; set; }
        [MysqlColumn("id_gamestudio")]
        public int ID_GameStudio { get; set; }
    }
}
