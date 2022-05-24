using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS1
{
    class Entidad
    {
        public List<Atributo> ListAtributo;
        public List<Registro> ListTupla;

        public String nombre;
        public long dir;
        public long dir_sig;

        public long dir_atributo;
        public long dir_tupla;

        public Entidad(String _nombre)
        {
            ListAtributo = new List<Atributo>();
            ListTupla = new List<Registro>();
            nombre = _nombre;
            dir = -1;
            dir_sig = -1;
            dir_atributo = -1;
            dir_tupla = -1;
        }
        public void guardaEntidad(FileStream Archivo, BinaryWriter Escritura)
        {
            Escritura.Write(this.nombre);
            Escritura.Write(this.dir);
            Escritura.Write(this.dir_sig);
            Escritura.Write(dir_atributo);
            Escritura.Write(dir_tupla);
        }
    }
}
