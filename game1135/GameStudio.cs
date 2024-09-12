using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135
{  
    [MysqlTable("gamestudio")]
    public class GameStudio: BaseModel
    {
        [MysqlColumn("name")]
        public string Name { get; set; }
        [MysqlRelation("game", "id_gamestudio")]
        public List<Game> Games { get; set; }
        [MysqlRelation("employee", "id_gamestudio")]
        public List<Employee> Employees { get; set; }
    }
}
