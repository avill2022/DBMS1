using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS1
{
    class Tabla
    {
        public List<Registro> ListTupla;
        public List<String> ListAtributo;
        public Tabla()
        {
            ListTupla = new List<Registro>();
            ListAtributo = new List<String>();
        }
    }
}
