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
        [MysqlTable("id")]
        public int ID {  get; set; }
        [MysqlTable("name")]
        public string Name { get; set; }
    }
}
