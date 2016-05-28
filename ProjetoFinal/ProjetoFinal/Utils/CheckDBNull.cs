using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Utils
{
    public class CheckDBNull
    {
        public static Object getNullValue(Object reader)
        {
            if (reader == DBNull.Value)
            {
                return null;
            }
            return reader;
        }

        public static Object getDBNullValue(Object value)
        {
            if(value == null)
            {
                return DBNull.Value;
            }
            return value;
        }

    }
}
