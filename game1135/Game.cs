using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135
{
    [MysqlTable("game")]
    public class Game: BaseModel
    {

        [MysqlColumn("title")]
        public string Title { get; set; }
        [MysqlColumn("id_gamestudio")]
        public int ID_GameStudio { get; set; }
        [MysqlColumn("genre")]
        public string Genre { get; set; }
        [MysqlColumn("year")]
        public string Year { get; set; }
    }
}
