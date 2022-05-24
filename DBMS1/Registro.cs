using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS1
{
    class Registro
    {
        public long dir;
        public long dir_sig;
        public List<Dato> datos;

        public Registro()
        {
            dir = -1;
            dir_sig = -1;
            datos = new List<Dato>();
        }
        public void guardaTupla(FileStream Archivo, BinaryWriter Escritura)
        {
            Escritura.Write(this.dir);
            Escritura.Write(this.dir_sig);

        }
    }
}
