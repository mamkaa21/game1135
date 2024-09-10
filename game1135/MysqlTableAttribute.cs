using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135
{
    public class MysqlTableAttribute : Attribute
    {
        public MysqlTableAttribute(string table)
        {
            TableName = table;
        }

        public string TableName { get; }
    }
}
