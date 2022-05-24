using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS1
{
    class Atributo
    {
        public String sNombre;
        public String cTipo;
        public int iLongitud;
        public int iEstatus;

        public long dir;
        public long dir_sig;

        public Atributo(String _nombre,String _cTipo,int _iLongitud,String _iEstatus)
        {
            sNombre = _nombre;
            cTipo = _cTipo;
            iLongitud = _iLongitud;
            if(_iEstatus=="-")
                iEstatus = 0;
            else
            if(_iEstatus=="Pk")
                iEstatus = 1;
            else
            if(_iEstatus=="Fk")
                iEstatus = 2;
            dir = -1;
            dir_sig = -1;
        }
        public Atributo(String _nombre)
        {
            sNombre = _nombre;
            cTipo = "";
            iLongitud = 0;
            iEstatus = 0;
            dir = -1;
            dir_sig = -1;
        }
        public void guardaAtributo(FileStream Archivo, BinaryWriter Escritura)
        {
            Escritura.Write(this.sNombre);
            Escritura.Write(this.cTipo);
            Escritura.Write(this.iLongitud);
            Escritura.Write(this.iEstatus);
            Escritura.Write(this.dir);
            Escritura.Write(this.dir_sig);
        }
    }
}
