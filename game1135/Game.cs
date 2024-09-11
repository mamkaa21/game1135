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
        [MysqlTable("id")]
        public int ID {  get; set; }
        [MysqlTable("title")]
        public string Title { get; set; }
        [MysqlTable("id_gamestudio")]
        public int ID_GameStudio { get; set; }
        [MysqlTable("genre")]
        public string Genre { get; set; }
        [MysqlTable("year")]
        public string Year { get; set; }
    }
}
