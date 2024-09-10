﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135
{
    internal class MysqlRelationAttribute
    {
        public MysqlRelationAttribute(string table, string secKey)
        {
            TableName = table;
            SecKey = secKey;
        }

        public string TableName { get; }
        public string SecKey { get; }
    }
}
