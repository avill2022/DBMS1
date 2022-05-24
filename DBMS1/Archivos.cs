using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS1
{
    public partial class Archivos : Form
    {
        FileStream Archivo;
        BinaryWriter Escritura;
        BinaryReader Lectura;
        List<Entidad> DiccionarioDatos = new List<Entidad>();
        Entidad EActual = null;
        Atributo AActual = null;
        Registro TActua = null;

        public Archivos()
        {
            InitializeComponent();
        }

        private void abrirArchivo()
        {
            Lectura = new BinaryReader(Archivo,Encoding.UTF8);
            Archivo.Position = 0;
            long pos = Lectura.ReadInt64();
            if (pos != -1)
            {
                do
                {
                    Archivo.Position = pos;
                    Entidad nueva = recuperaEntidad(Archivo, Lectura);                    
                    pos = nueva.dir_sig;
                    if (nueva.dir_atributo != -1)
                    {
                        Archivo.Position = nueva.dir_atributo;
                        Atributo nuevo = recuperaAtributo(Archivo,Lectura);
                        nueva.ListAtributo.Add(nuevo);
                        if (nuevo.dir_sig != -1)
                        {
                            do
                            {
                                Archivo.Position = nuevo.dir_sig;
                                nuevo = recuperaAtributo(Archivo, Lectura);
                                nueva.ListAtributo.Add(nuevo);
                            } while (nuevo.dir_sig != -1);
                        }
                    }
                    DiccionarioDatos.Add(nueva);
                } while (pos != -1);
                foreach (Entidad e in DiccionarioDatos)
                {
                    if (e.dir_tupla != -1)
                    {
                        Registro t = recuperaTupla(e, e.dir_tupla, Archivo,Lectura);
                        e.ListTupla.Add(t);
                        if (t.dir_sig != -1)
                        {
                            do
                            {
                                t = recuperaTupla(e, t.dir_sig, Archivo, Lectura);
                                e.ListTupla.Add(t);
                            } while (t.dir_sig != -1);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Archivo vacio");
            cargaListaTablasAtributos();
            Lectura.Close();
        }
        #region Entidades
        private void NombreEntidad_TextChanged(object sender, EventArgs e)
        {
            if (NombreEntidad.Text != "")
            {
                if (nombreValidoE(NombreEntidad.Text))
                {
                    Imagen1.Image = Image.FromFile("Correcto.png");
                    _AgregaT.Enabled = true;
                }
                else
                {
                    Imagen1.Image = Image.FromFile("Incorrecto.png");
                    _AgregaT.Enabled = false;
                }
            }else
                Imagen1.Image = null;
        }
        public bool nombreValidoE(String nombre)
        {
            foreach (Entidad e in DiccionarioDatos)
            {
                if (e.nombre == nombre)
                    return false;
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] == '°' || nombre[i] == '!' || nombre[i] == '"' || nombre[i] == '#' || nombre[i] == '$' || nombre[i] == '%' || nombre[i] == '/' || nombre[i] == '(' || nombre[i] == ')' || nombre[i] == '=' || nombre[i] == '?' || nombre[i] == '.' || nombre[i] == '¿')
                    return false;
            }
            return true;
        }
        private void NombreEntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            if (NombreEntidad.Text != "")
            {
                if (DiccionarioDatos.Count == 0)
                {
                    Entidad nueva = new Entidad(NombreEntidad.Text);
                    NombreEntidad.Text = "";
                    _AgregaT.Enabled = false;
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                    nueva.dir = Archivo.Length;
                    Archivo.Position = 0;
                    Escritura.Write(nueva.dir);
                    Archivo.Position = nueva.dir;
                    nueva.guardaEntidad(Archivo, Escritura);
                    DiccionarioDatos.Add(nueva);
                    listBoxE.Items.Add(nueva.nombre);
                    SelectTabla1.Items.Add(nueva.nombre);
                    Escritura.Close();
                    Archivo.Close();
                }
                else
                {
                    Entidad nueva = new Entidad(NombreEntidad.Text);
                    NombreEntidad.Text = "";
                    _AgregaT.Enabled = false;
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                    nueva.dir = Archivo.Length;
                    Entidad aux = DiccionarioDatos[DiccionarioDatos.Count - 1];
                    aux.dir_sig = nueva.dir;
                    Archivo.Position = aux.dir;
                    aux.guardaEntidad(Archivo, Escritura);
                    Archivo.Position = nueva.dir;
                    nueva.guardaEntidad(Archivo, Escritura);

                    DiccionarioDatos.Add(nueva);
                    listBoxE.Items.Add(nueva.nombre);
                    SelectTabla1.Items.Clear();
                    foreach (Entidad en in DiccionarioDatos)
                    {
                        SelectTabla1.Items.Add(en.nombre);
                    }
                    SelectTabla2.Enabled = true;
                    SelectTabla2.Items.Clear();
                    foreach (Entidad en in DiccionarioDatos)
                    {
                        SelectTabla2.Items.Add(en.nombre);
                    }
                    Escritura.Close();
                    Archivo.Close();
                }
            }
            else
                MessageBox.Show("Ingresa un Nombre");
        }
        private void _AgregaT_Click(object sender, EventArgs e)
        {
            if (NombreEntidad.Text != "")
            {
                if (DiccionarioDatos.Count == 0)
                {
                    Entidad nueva = new Entidad(NombreEntidad.Text);
                    NombreEntidad.Text = "";
                    _AgregaT.Enabled = false;
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                    nueva.dir = Archivo.Length;
                    Archivo.Position = 0;
                    Escritura.Write(nueva.dir);
                    Archivo.Position = nueva.dir;
                    nueva.guardaEntidad(Archivo, Escritura);
                    DiccionarioDatos.Add(nueva);
                    listBoxE.Items.Add(nueva.nombre);
                    SelectTabla1.Items.Add(nueva.nombre);
                    Escritura.Close();
                    Archivo.Close();
                }
                else
                {
                    Entidad nueva = new Entidad(NombreEntidad.Text);
                    NombreEntidad.Text = "";
                    _AgregaT.Enabled = false;
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                    nueva.dir = Archivo.Length;
                    Entidad aux = DiccionarioDatos[DiccionarioDatos.Count - 1];
                    aux.dir_sig = nueva.dir;
                    Archivo.Position = aux.dir;
                    aux.guardaEntidad(Archivo, Escritura);
                    Archivo.Position = nueva.dir;
                    nueva.guardaEntidad(Archivo, Escritura);

                    DiccionarioDatos.Add(nueva);
                    listBoxE.Items.Add(nueva.nombre);
                    SelectTabla1.Items.Clear();
                    foreach (Entidad en in DiccionarioDatos)
                    {
                        SelectTabla1.Items.Add(en.nombre);
                    }
                    SelectTabla2.Enabled = true;
                    SelectTabla2.Items.Clear();
                    foreach (Entidad en in DiccionarioDatos)
                    {
                        SelectTabla2.Items.Add(en.nombre);
                    }
                    Escritura.Close();
                    Archivo.Close();
                }
            }
            else
                MessageBox.Show("Ingresa un Nombre");
        }
        private void _EliminaT_Click(object sender, EventArgs e)
        {
            if (EActual != null && listBoxE.SelectedItem != null)
            {
                long dirPrim = -1;
                if (DiccionarioDatos.Count == 1)
                {
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);

                    Archivo.Position = 0;
                    dirPrim = -1;
                    Escritura.Write(dirPrim);
                    DiccionarioDatos.Remove(EActual);
                    Escritura.Close();
                    Archivo.Close();
                }
                else
                if (EActual == DiccionarioDatos[0])
                {
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                    Archivo.Position = 0;
                    Escritura.Write(DiccionarioDatos[1].dir);
                    DiccionarioDatos.Remove(EActual);
                    Escritura.Close();
                    Archivo.Close();
                }
                else
                if (EActual == DiccionarioDatos[DiccionarioDatos.Count - 1])
                {
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                    Entidad AUX = DiccionarioDatos[DiccionarioDatos.Count - 2];
                    Archivo.Position = AUX.dir;
                    AUX.dir_sig = -1;
                    AUX.guardaEntidad(Archivo, Escritura);
                    DiccionarioDatos.Remove(EActual);
                    Escritura.Close();
                    Archivo.Close();
                }
                else
                {
                    int i = 0;
                    foreach (Entidad een in DiccionarioDatos)
                    {
                        if (een == EActual)
                        {
                            break;
                        }
                        else
                            i++;
                    }
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                    Entidad AUX1 = DiccionarioDatos[i - 1];
                    Entidad AUX2 = DiccionarioDatos[i + 1];
                    AUX1.dir_sig = AUX2.dir;
                    Archivo.Position = AUX1.dir;
                    AUX1.guardaEntidad(Archivo, Escritura);
                    DiccionarioDatos.Remove(EActual);
                    Escritura.Close();
                    Archivo.Close();
                }
                EActual = null;
                _Atributo.Enabled = false;
                _TipoA.Text = "";
                _LongitudA.Text = "";
                _EstatusA.Text = "";
                _GridAtributos.Rows.Clear();
                cargaListaTablasAtributos();
            }
        }
        private Entidad recuperaEntidad(FileStream Archivo, BinaryReader Lectura)
        {          
            Entidad nueva = new Entidad(Lectura.ReadString());
            nueva.dir = Lectura.ReadInt64();
            nueva.dir_sig = Lectura.ReadInt64();
            nueva.dir_atributo = Lectura.ReadInt64();
            nueva.dir_tupla = Lectura.ReadInt64();
            return nueva;
        }
        private Entidad buscaEntidad(String nombre)
        {
            foreach (Entidad e in DiccionarioDatos)
            {
                if (e.nombre == nombre)
                    return e;
            }
            return null;
        }
        private void listBoxE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxE.SelectedItem != null)
            {
                String selec = listBoxE.SelectedItem.ToString();
                _EliminaT.Enabled = true;
                _Atributo.Enabled = true;                
                foreach (Entidad een in DiccionarioDatos)
                {
                    if (een.nombre == selec)
                    {
                        EActual = een;
                        _EstatusA.Items.Clear();
                        bool primaria = true;
                        foreach (Atributo a in EActual.ListAtributo)
                        {
                            if (a.iEstatus == 1)
                                primaria = false;
                        }
                        _EstatusA.Items.Add("-");
                        if (primaria == true)
                            _EstatusA.Items.Add("Pk");
                        _EstatusA.Items.Add("Fk");
                        cargaGridAtributos();
                        break;
                    }
                }
            }
            else
            {
                EActual = null;
                _GridAtributos.Rows.Clear();
                _EliminaT.Enabled = false;
                _Atributo.Enabled = false;
            }
        }
        #endregion
        #region Atributos
        public void cargaGridAtributos()
        {
            if (EActual != null)
            {
                _GridAtributos.Rows.Clear();
                int num = 0;
                foreach (Atributo aat in EActual.ListAtributo)
                {
                    _GridAtributos.Rows.Add();
                    _GridAtributos.Rows[num].Cells[0].Value = aat.sNombre;
                    _GridAtributos.Rows[num].Cells[1].Value = aat.cTipo;
                    _GridAtributos.Rows[num].Cells[2].Value = aat.iLongitud;
                    if(aat.iEstatus==0)
                    _GridAtributos.Rows[num].Cells[3].Value = aat.iEstatus;
                    else
                        if (aat.iEstatus == 1)
                        _GridAtributos.Rows[num].Cells[3].Value = "Pk";
                    else
                        if (aat.iEstatus == 2)
                        _GridAtributos.Rows[num].Cells[3].Value = "Fk";
                    num += 1;
                }
            }
        }
        public void cargaListaTablasAtributos()
        {
            listBoxE.Items.Clear();
            foreach (Entidad een in DiccionarioDatos)
            {
                listBoxE.Items.Add(een.nombre);
            }
        }
        private void _AgregaA_Click(object sender, EventArgs e)
        {
            if (_NombreA.Text != "")
            {
                if (_TipoA.Text != "")
                {
                    if (_LongitudA.Text != "")
                    {
                        if (_EstatusA.Text != "")
                        {
                            Atributo nuevo = new Atributo(_NombreA.Text, _TipoA.Text, int.Parse(_LongitudA.Text), _EstatusA.Text);
                            Archivo = new FileStream(Actual1.Text, FileMode.Open);
                            Escritura = new BinaryWriter(Archivo, Encoding.UTF8);

                            if (EActual.ListAtributo.Count == 0)
                            {
                                EActual.dir_atributo = Archivo.Length;
                                Archivo.Position = EActual.dir;
                                EActual.guardaEntidad(Archivo, Escritura);
                                nuevo.dir = Archivo.Length;
                                Archivo.Position = EActual.dir_atributo;
                                nuevo.guardaAtributo(Archivo, Escritura);
                                EActual.ListAtributo.Add(nuevo);
                            }
                            else
                            {
                                Atributo aux = EActual.ListAtributo[EActual.ListAtributo.Count - 1];
                                aux.dir_sig = Archivo.Length;
                                Archivo.Position = aux.dir;
                                aux.guardaAtributo(Archivo, Escritura);
                                Archivo.Position = Archivo.Length;
                                nuevo.dir = Archivo.Length;
                                nuevo.guardaAtributo(Archivo, Escritura);
                                EActual.ListAtributo.Add(nuevo);
                            }
                            _NombreA.Text = "";
                            _TipoA.Text = "";
                            _LongitudA.Text = "";
                            _EstatusA.Text = "";
                            _TipoA.Enabled = false;
                            _AgregaA.Enabled = false;
                            _EstatusA.Enabled = false;
                            Escritura.Close();
                            Archivo.Close();
                            cargaGridAtributos();
                        }
                        else
                            MessageBox.Show("Falta un dato");
                    }
                    else
                        MessageBox.Show("Falta un dato");
                }
                else
                    MessageBox.Show("Falta un dato");
            }
            else
                MessageBox.Show("Falta un dato");
        }
        private void _EliminaA_Click(object sender, EventArgs e)
        {
            if (EActual != null && AActual != null)
            {
                if (EActual.ListAtributo.Count == 1)
                {
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);

                    EActual.dir_atributo = -1;
                    Archivo.Position = EActual.dir;
                    EActual.guardaEntidad(Archivo, Escritura);

                    Escritura.Close();
                    Archivo.Close();
                }
                else
                if (AActual == EActual.ListAtributo[0])
                {
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);

                    EActual.dir_atributo = AActual.dir_sig;
                    Archivo.Position = EActual.dir;
                    EActual.guardaEntidad(Archivo, Escritura);

                    Escritura.Close();
                    Archivo.Close();
                }
                else
                if (AActual == EActual.ListAtributo[EActual.ListAtributo.Count - 1])
                {
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);

                    Atributo atrib = EActual.ListAtributo[EActual.ListAtributo.Count - 2];
                    atrib.dir_sig = -1;
                    Archivo.Position = atrib.dir;
                    atrib.guardaAtributo(Archivo,Escritura);

                    Escritura.Close();
                    Archivo.Close();
                }
                else
                {
                    int i = 0;
                    Archivo = new FileStream(Actual1.Text, FileMode.Open);
                    Escritura = new BinaryWriter(Archivo, Encoding.UTF8);   
                    foreach (Atributo A in EActual.ListAtributo)
                    {
                        if (A == AActual)
                        {
                            break;
                        }
                        else
                            i++;
                    }
                    Atributo AUX1 = EActual.ListAtributo[i - 1];
                    AUX1.dir_sig = AActual.dir_sig;
                    Archivo.Position = AUX1.dir;
                    AUX1.guardaAtributo(Archivo, Escritura);

                    Escritura.Close();
                    Archivo.Close();
                }
                EActual.ListAtributo.Remove(AActual);
                cargaGridAtributos();
                AActual = null;
            }
        }

        private Atributo recuperaAtributo(FileStream Archivo, BinaryReader Lectura)
        {
            Atributo nuevo = new Atributo(Lectura.ReadString());
            nuevo.cTipo = Lectura.ReadString();
            nuevo.iLongitud = Lectura.ReadInt32();
            nuevo.iEstatus = Lectura.ReadInt32();
            nuevo.dir = Lectura.ReadInt64();
            nuevo.dir_sig = Lectura.ReadInt64();
            return nuevo;
        }
        private void _GridAtributos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != _GridAtributos.Rows.Count)
            {
                if (e.RowIndex >= 0)
                {
                    String nombreAtributo = _GridAtributos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    foreach (Atributo a in EActual.ListAtributo)
                    {
                        if (a.sNombre == nombreAtributo)
                        {
                            AActual = a;
                            if(EActual.dir_tupla == -1)
                            _EliminaA.Enabled = true;
                                break;
                        }
                    }
                }
                else
                {
                    _EliminaA.Enabled = false;
                    AActual = null;
                }
            }
            else
            {
                _EliminaA.Enabled = false;
                AActual = null;
            }
        }

        public bool nombreValidoA(String nombre)
        {
            foreach (Atributo a in EActual.ListAtributo)
            {
                if (a.sNombre == nombre)
                    return false;
            }
            for (int i = 0; i < nombre.Length; i++)
            {
                if (nombre[i] == '°' || nombre[i] == '!' || nombre[i] == '"' || nombre[i] == '#' || nombre[i] == '$' || nombre[i] == '%' || nombre[i] == '/' || nombre[i] == '(' || nombre[i] == ')' || nombre[i] == '=' || nombre[i] == '?' || nombre[i] == '.' || nombre[i] == '¿')
                    return false;
            }
            return true;
        }
        private void _NombreA_TextChanged(object sender, EventArgs e)
        {
            if (_NombreA.Text != "")
            {
                if (nombreValidoA(_NombreA.Text))
                {
                    Imagen2.Image = Image.FromFile("Correcto.png");
                    _TipoA.Enabled = true;
                }
                else
                {
                    Imagen2.Image = Image.FromFile("Incorrecto.png");
                    _TipoA.Enabled = false;
                }
            }
            else
            {
                Imagen2.Image = null;
                _TipoA.Enabled = false;
                _TipoA.Text = "";
            }
        }
        private void _TipoA_TextChanged(object sender, EventArgs e)
        {
            if (_TipoA.Text != "")
            {
                switch (_TipoA.Text)
                {
                    case "int":
                        _LongitudA.Text = "4";
                        _LongitudA.Enabled = false;
                        break;
                    case "float":
                        _LongitudA.Text = "6";
                        _LongitudA.Enabled = false;
                        break;
                    case "char":
                        _LongitudA.Text = "1";
                        _LongitudA.Enabled = false;
                        break;
                    case "string":
                        _LongitudA.Text = "";
                        _LongitudA.Enabled = true;
                        break;
                    case "bool":
                        _LongitudA.Text = "1";
                        _LongitudA.Enabled = false;
                        break;
                }
            }
        }
        private void _LongitudA_TextChanged(object sender, EventArgs e)
        {
            if (_LongitudA.Text != "")
            {
                _EstatusA.Enabled = true;
                _EstatusA.Items.Clear();
                bool primaria = true;
                foreach (Atributo a in EActual.ListAtributo)
                {
                    if (a.iEstatus == 1)
                        primaria = false;
                }
                _EstatusA.Items.Add("-");
                if (primaria == true)
                    _EstatusA.Items.Add("Pk");
                _EstatusA.Items.Add("Fk");
            }
            else
            {
                _EstatusA.Enabled = false;
            }
        }
        
        private void _EstatusA_TextChanged(object sender, EventArgs e)
        {
            if (_EstatusA.Text != "")
            {               
                _AgregaA.Enabled = true;
            }
            else
            {
                _AgregaA.Enabled = false;
            }
        }
        #endregion
        #region Registros
        private void SelectTabla1_TextChanged(object sender, EventArgs e)
        {
            Tuplas1.Columns.Clear();
            Entidad select = buscaEntidad(SelectTabla1.Text);
            if (select != null)
            {
                foreach (Atributo a in select.ListAtributo)
                {
                    Tuplas1.Columns.Add(a.sNombre, a.sNombre);
                }
                foreach (Registro t in select.ListTupla)
                {
                    Tuplas1.Rows.Add();
                    int num = 0;
                    foreach (Dato d in t.datos)
                    {
                        Tuplas1.Rows[Tuplas1.Rows.Count - 1].Cells[num].Value = d.dato;
                        num += 1;
                    }
                }
                if(select.dir_atributo != -1)
                    _NuevoRegistro.Enabled = true;
                else
                    _NuevoRegistro.Enabled = false;
            }
        }
        private void cargaRegistros(Entidad _Entidad)
        {
            Tuplas1.Rows.Clear();
            Tuplas1.Columns.Clear();
            if (_Entidad != null)
            {
                foreach (Atributo a in _Entidad.ListAtributo)
                {
                    Tuplas1.Columns.Add(a.sNombre, a.sNombre);
                }
                foreach (Registro t in _Entidad.ListTupla)
                {
                    Tuplas1.Rows.Add();
                    int num = 0;
                    foreach (Dato d in t.datos)
                    {
                        Tuplas1.Rows[Tuplas1.Rows.Count - 1].Cells[num].Value = d.dato;
                        num += 1;
                    }
                }
                _NuevoRegistro.Enabled = true;
            }
        }
        private Registro recuperaTupla(Entidad entidad,long dir, FileStream Archivo, BinaryReader Lectura)
        {
            Registro t = new Registro();
            Archivo.Position = dir;
            t.dir = Lectura.ReadInt64();
            t.dir_sig = Lectura.ReadInt64();
            foreach (Atributo a in entidad.ListAtributo)
            {
                Dato d = new Dato();
                switch (a.cTipo)
                {
                    case "int":
                        d.tipo = a.cTipo;
                        d.dato = Lectura.ReadInt32().ToString();                        
                        break;
                    case "float":
                        d.tipo = a.cTipo;
                        d.dato = Lectura.ReadSingle().ToString();
                        break;
                    case "char":
                        d.tipo = a.cTipo;
                        d.dato = Lectura.ReadChar().ToString();
                        break;
                    case "string":
                        d.tipo = a.cTipo;
                        d.dato = Lectura.ReadString().ToString();
                        String da = "";
                        for (int i = 0; i < d.dato.Length; i++)
                        {
                            if (d.dato[i] == ' ')
                                break;
                            else
                                da += d.dato[i].ToString();
                        }
                        d.dato = da;
                        break;
                    case "bool":
                        d.tipo = a.cTipo;
                        d.dato = Lectura.ReadBoolean().ToString();
                        break;
                }
                t.datos.Add(d);
            }
            return t;
        }
        private void guardaTupla(Entidad entidad, Registro t,FileStream Archivo, BinaryWriter Escritura)
        {
            foreach (Atributo a in entidad.ListAtributo)
            {
                Dato d = new Dato();
                switch (a.cTipo)
                {
                    case "int":
                        d.tipo = a.cTipo;
                        int entero = 0;
                        Escritura.Write(entero);
                        d.dato = "0";
                        break;
                    case "float":
                        d.tipo = a.cTipo;
                        float flotante = 0.00F;
                        Escritura.Write(flotante);
                        d.dato = "0.00";
                        break;
                    case "char":
                        d.tipo = a.cTipo;
                        char caracter = '-';
                        Escritura.Write(caracter);
                        d.dato = "-";
                        break;
                    case "string":
                        d.tipo = a.cTipo;
                        String s = creaCadena(a.iLongitud);
                        Escritura.Write(s);
                        d.dato = s;
                        break;
                    case "bool":
                        d.tipo = a.cTipo;
                        bool boleano = false;
                        Escritura.Write(boleano);
                        d.dato = "False";
                        break;
                }
                t.datos.Add(d);
            }
        }
        private String creaCadena(int iLongitud)
        {
            String cad = "";
            for (int i = 0; i < iLongitud; i++)
            {
                cad += "-";
            }
            return cad;
        }
        private void _NuevoRegistro_Click(object sender, EventArgs e)
        {
            Tuplas1.Rows.Add();
            Entidad select = buscaEntidad(SelectTabla1.Text);
            if (select != null)
            {
                Archivo = new FileStream(Actual1.Text, FileMode.Open);
                Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                Registro t = new Registro();
                if (select.ListTupla.Count == 0)
                {
                    t.dir = Archivo.Length;
                    select.dir_tupla = Archivo.Length;
                    Archivo.Position = select.dir;
                    select.guardaEntidad(Archivo,Escritura);
                    Archivo.Position = Archivo.Length;
                    t.guardaTupla(Archivo, Escritura);
                    this.guardaTupla(select,t, Archivo, Escritura);
                    select.ListTupla.Add(t);
                    cargaRegistros(select);       
                }
                else
                {
                    Registro aux = select.ListTupla[select.ListTupla.Count - 1];
                    aux.dir_sig = Archivo.Length;
                    t.dir = Archivo.Length;
                    Archivo.Position = aux.dir;
                    aux.guardaTupla(Archivo, Escritura);

                    Archivo.Position = Archivo.Length;
                    t.guardaTupla(Archivo, Escritura);
                    this.guardaTupla(select, t, Archivo, Escritura);
                    select.ListTupla.Add(t);
                    cargaRegistros(select);
                }
                Escritura.Close();
                Archivo.Close();               
            }
        }
        private bool validaDatos(Entidad ent,int indice, DataGridViewRow dtg)
        {
            int num = 0;
            Registro t = ent.ListTupla[indice];
            foreach (Atributo a in ent.ListAtributo)
            {
                String value = dtg.Cells[num].Value.ToString();
                switch (a.cTipo)
                {
                    case "int":
                        try
                        {
                            int.Parse(value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("El valor tiene que ser entero " +ex.Message);
                            dtg.Cells[num].Value = 0;
                            t.datos[num].dato = "0";
                            return false;
                        }
                        break;
                    case "float":
                        try
                        {
                            float.Parse(value);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("El valor tiene que ser flotante " + ex.Message);
                            dtg.Cells[num].Value = 0.00F;
                            t.datos[num].dato = "0.00";
                            return false;
                        }
                        break;
                    case "char":
                        if (value.Length > 1)
                        {
                            dtg.Cells[num].Value = '-';
                            t.datos[num].dato = "-";
                            MessageBox.Show("El valor tiene que ser un caracter ");
                            return false;
                        }
                        break;
                    case "string":
                        if (value.Length > a.iLongitud)
                        {
                            String valor = "";
                            for (int i = 0; i < a.iLongitud; i++)
                            {
                                valor = valor += value[i];
                            }
                            MessageBox.Show("El valor tiene que ser menor a la longitud, la cadena sera resultante sera:" + valor);
                            //t.datos[num].dato = valor;
                            dtg.Cells[num].Value = valor;
                            return false;
                        }
                        else
                        {
                            for (int i = value.Length; i < a.iLongitud; i++)
                            {
                                value = value +=" ";
                            }
                            dtg.Cells[num].Value = value;
                            //t.datos[num].dato = value;
                        }
                        break;
                    case "bool":
                        if (value != "True" && value != "False")
                        {
                            dtg.Cells[num].Value = "False";
                            //t.datos[num].dato = "False";
                            MessageBox.Show("El valor tiene qu ser True o False ");
                            return false;
                        }
                        break;
                }
                num += 1;
            }
            return true;
        }
        private bool validaClave(Entidad ent, DataGridViewRow dtg, int Row, int Colum)
        {
            Registro ttt = ent.ListTupla[Row];
            Dato dato = ttt.datos[Colum];
            String cadena = dtg.Cells[Colum].Value.ToString();
            if (ent != null)
            {
                if (ent.ListAtributo[Colum].iEstatus == 1)//Si el llave Primaria
                {
                    foreach (Registro tt in ent.ListTupla)
                    {
                        String compara = tt.datos[Colum].dato.ToString();
                        Atributo a = ent.ListAtributo[Colum];
                        for (int i = compara.Length; i < a.iLongitud; i++)
                        {
                            compara = compara += " ";
                        }
                        if (compara == cadena)
                        {
                            MessageBox.Show("Este atributo es llave primaria y no se puede repetir");
                            dtg.Cells[Colum].Value = dato.dato;
                            return false;
                        }
                    }
                        /*foreach (Tupla tt in ent.ListTupla)
                        {
                            if (tt.datos[Colum].dato == cadena)
                            {
                                Tuplas1.Columns.Clear();
                                Entidad select = buscaEntidad(SelectTabla1.Text);
                                if (select != null)
                                {
                                    foreach (Atributo a in select.ListAtributo)
                                    {
                                        Tuplas1.Columns.Add(a.sNombre, a.sNombre);
                                    }
                                    foreach (Tupla t in select.ListTupla)
                                    {
                                        Tuplas1.Rows.Add();
                                        int num = 0;
                                        foreach (Dato d in t.datos)
                                        {
                                            Tuplas1.Rows[Tuplas1.Rows.Count - 1].Cells[num].Value = d.dato;
                                            num += 1;
                                        }
                                    }
                                    if (select.dir_atributo != -1)
                                        _NuevoRegistro.Enabled = true;
                                    else
                                        _NuevoRegistro.Enabled = false;
                                }
                                MessageBox.Show("Este atributo es llave primaria y no se puede repetir");
                                return false;
                            }
                        }*/
                    }
            }
            return true;
        }
        private void Tuplas1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {    
               
            Entidad ent = buscaEntidad(SelectTabla1.Text); 
            DataGridViewRow dtg = Tuplas1.Rows[e.RowIndex];
            Registro t = ent.ListTupla[e.RowIndex];
            Tuplas2.Rows.Clear();
            
            if (validaDatos(ent, e.RowIndex, dtg)== true && validaClave(ent,dtg,e.RowIndex,e.ColumnIndex)==true)
            {
                Archivo = new FileStream(Actual1.Text, FileMode.Open);
                Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                Archivo.Position = t.dir;
                Escritura.Write(t.dir);
                Escritura.Write(t.dir_sig);
                int num = 0;
                foreach (Atributo a in ent.ListAtributo)
                {
                    String s = dtg.Cells[num].Value.ToString();
                    switch (a.cTipo)
                    {
                        case "int":
                            int entero = int.Parse(s);
                            t.datos[num].dato = entero.ToString(); 
                            Escritura.Write(entero);
                            break;
                        case "float":
                            float flotante = float.Parse(dtg.Cells[num].Value.ToString());
                            t.datos[num].dato = flotante.ToString();
                            Escritura.Write(flotante);
                            break;
                        case "char":
                            char caracter = dtg.Cells[num].Value.ToString()[0];
                            t.datos[num].dato = caracter.ToString();
                            Escritura.Write(caracter);
                            break;
                        case "string":
                            Escritura.Write(s);
                            t.datos[num].dato = s;
                            break;
                        case "bool":
                            bool boleano;
                            if (s == "False")
                                boleano = false;
                            else
                                boleano = true;
                            t.datos[num].dato = boleano.ToString();
                            Escritura.Write(boleano);
                            break;
                    }
                    num += 1;
                }
                Escritura.Close();
                Lectura.Close();
                Archivo.Close();

            }
        }      
        private void _EliminaRegistro_Click(object sender, EventArgs e)
        {
            Entidad entidad = buscaEntidad(SelectTabla1.Text);
            if (entidad != null && TActua != null)
            {
                Archivo = new FileStream(Actual1.Text, FileMode.Open);
                Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
                if (entidad.ListTupla.Count == 1)
                {
                    entidad.dir_tupla = -1;
                    Archivo.Position = entidad.dir;
                    entidad.guardaEntidad(Archivo, Escritura);
                }
                else
                    if (TActua == entidad.ListTupla[0])
                {
                    entidad.dir_tupla = entidad.ListTupla[1].dir;
                    Archivo.Position = entidad.dir;
                    entidad.guardaEntidad(Archivo, Escritura);
                }
                else
                    if (TActua == entidad.ListTupla[entidad.ListTupla.Count - 1])
                {
                    entidad.ListTupla[entidad.ListTupla.Count - 2].dir_sig = -1;
                    Archivo.Position = entidad.ListTupla[entidad.ListTupla.Count - 2].dir;
                    entidad.ListTupla[entidad.ListTupla.Count - 2].guardaTupla(Archivo, Escritura);
                }
                else
                {
                    int i = 0;
                    foreach (Registro t in entidad.ListTupla)
                    {
                        if (t == TActua)
                        {
                            break;
                        }
                        else
                            i++;
                    }
                    entidad.ListTupla[i - 1].dir_sig = entidad.ListTupla[i + 1].dir;
                    Archivo.Position = entidad.ListTupla[i - 1].dir;
                    entidad.ListTupla[i - 1].guardaTupla(Archivo, Escritura);
                }
                entidad.ListTupla.Remove(TActua);
                cargaRegistros(entidad);
                Escritura.Close();
                Archivo.Close();
                TActua = null;
                _EliminaRegistro.Enabled = false;
            }
        }
        private void Tuplas1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Entidad entidad = buscaEntidad(SelectTabla1.Text);
            if (entidad != null)
            {
                int num = 0;
                foreach (Registro t in entidad.ListTupla)
                {
                    if (e.RowIndex == num)
                    {
                        TActua = t;
                        _EliminaRegistro.Enabled = true;
                        break;
                    }
                    num += 1;
                }
            }
            
        }     
        private void SelectTabla2_TextChanged(object sender, EventArgs e)
        {
            Tuplas2.Columns.Clear();
            SelectAtributo.Items.Clear();
            SelectAtributo.Text = "";
            SelectAtributo.Enabled = true;
            Entidad select = buscaEntidad(SelectTabla2.Text);
            if (select != null)
            {
                foreach (Atributo a in select.ListAtributo)
                {
                    if(a.iEstatus==1)
                        SelectAtributo.Items.Add(a.sNombre);
                    if(a.iEstatus==2)
                        SelectAtributo.Items.Add(a.sNombre);
                    Tuplas2.Columns.Add(a.sNombre, a.sNombre);
                }
                foreach (Registro t in select.ListTupla)
                {
                    Tuplas2.Rows.Add();
                    int num = 0;
                    foreach (Dato d in t.datos)
                    {
                        Tuplas2.Rows[Tuplas2.Rows.Count - 1].Cells[num].Value = d.dato;
                        num += 1;
                    }
                }
            }
        }
        private void _Buscar_Click(object sender, EventArgs e)
        {
            Tuplas2.Rows.Clear();
            Entidad select = buscaEntidad(SelectTabla2.Text);
            if (select != null)
            {
                int num1 = 0;
                foreach (Atributo a in select.ListAtributo)
                {
                    if (a.sNombre == SelectAtributo.Text)
                    {
                        break;
                    }
                    num1 += 1;
                }
                foreach (Registro t in select.ListTupla)
                {
                    if (t.datos[num1].dato == _Busqueda.Text)
                    {
                        Tuplas2.Rows.Add();
                        int num = 0;
                        foreach (Dato d in t.datos)
                        {
                            Tuplas2.Rows[Tuplas2.Rows.Count - 1].Cells[num].Value = d.dato;
                            num += 1;
                        }
                    }
                }
            }
            _Busqueda.Text = "";
            _Busqueda.Enabled = false;
            _TipoB.Text = "Tipo:";
            _Buscar.Enabled = false;
        }
       
        #endregion
        private void AgregarBD__Click(object sender, EventArgs e)
        {
            NuevoA D = new NuevoA(this);
            D.Show();
        }
        public void creaNuevaBase(String nombre)
        {          
            nombre += ".dat";
            Archivo = new FileStream(nombre, System.IO.FileMode.Create);
            Escritura = new BinaryWriter(Archivo, Encoding.UTF8);
            long cab = -1;
            Escritura.Write(cab);
            Escritura.Close();
            Archivo.Close();
            Actual1.Text = nombre;
        }

        private void SelectAtributo_TextChanged(object sender, EventArgs e)
        {
            String s = SelectTabla2.Text;
            Entidad enti = null;
            foreach (Entidad ee in DiccionarioDatos)
            {
                if(ee.nombre == s)
                enti = ee;
            }
            s = SelectAtributo.Text;
            if (s == "")
                _Busqueda.Enabled = false;
            else
            {
                _Busqueda.Enabled = true;
                foreach (Atributo a in enti.ListAtributo)
                {
                    if (a.sNombre == s)
                    {
                        if (a.iEstatus == 1)
                            _TipoB.Text = "Pk->" + a.cTipo;
                        if (a.iEstatus == 2)
                            _TipoB.Text = "Fk->"+ a.cTipo;
                    }
                }
            }
        }

        private void _Busqueda_TextChanged(object sender, EventArgs e)
        {
            if (_Busqueda.Text != "")
            {

                _Buscar.Enabled = true;
            }
            else
                _Buscar.Enabled = false;
        }

        private void AbrirBD_Click(object sender, EventArgs e)
        {
            NuevoA nuevo = new NuevoA(this);
            nuevo.Show();
        }
    
        private void Actual1_TextChanged_1(object sender, EventArgs e)
        {
            if (Actual1.Text != "")
            {
                try
                {
                    Archivo = new FileStream(Actual1.Text, System.IO.FileMode.Open);
                    _Tabla.Enabled = true;
                    DiccionarioDatos.Clear();
                    listBoxE.Items.Clear();
                    _GridAtributos.Rows.Clear();
                    _Atributo.Enabled = false;
                    abrirArchivo();
                    Archivo.Close();
                    SelectTabla1.Enabled = true;
                    SelectTabla1.Items.Clear();
                    SelectTabla2.Items.Clear();


                    foreach (Entidad en in DiccionarioDatos)
                    {
                        SelectTabla1.Items.Add(en.nombre);
                    }
                    SelectTabla2.Enabled = true;
                    foreach (Entidad en in DiccionarioDatos)
                    {
                        SelectTabla2.Items.Add(en.nombre);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void AgregarBD__Click_1(object sender, EventArgs e)
        {
            OpenFileDialog DialogoArchivo = new OpenFileDialog();

            DialogoArchivo.Filter = "dat files (*.dat)|*.dat";
            DialogoArchivo.FilterIndex = 2;
            DialogoArchivo.RestoreDirectory = true;

            if (DialogoArchivo.ShowDialog() == DialogResult.OK)
            {
                Tuplas1.Rows.Clear();
                SelectTabla1.Items.Clear();
                SelectTabla1.Text = "";
                SelectTabla2.Items.Clear();
                SelectTabla2.Text = "";

                Actual1.Text = DialogoArchivo.SafeFileName;
            }
        }

        private void _Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Tuplas2.Rows.Clear();
                Entidad select = buscaEntidad(SelectTabla2.Text);
                if (select != null)
                {
                    int num1 = 0;
                    foreach (Atributo a in select.ListAtributo)
                    {
                        if (a.sNombre == SelectAtributo.Text)
                        {
                            break;
                        }
                        num1 += 1;
                    }
                    foreach (Registro t in select.ListTupla)
                    {
                        if (t.datos[num1].dato == _Busqueda.Text)
                        {
                            Tuplas2.Rows.Add();
                            int num = 0;
                            foreach (Dato d in t.datos)
                            {
                                Tuplas2.Rows[Tuplas2.Rows.Count - 1].Cells[num].Value = d.dato;
                                num += 1;
                            }
                        }
                    }
                }
                _Busqueda.Text = "";
                //_Busqueda.Enabled = false;
                //_TipoB.Text = "Tipo:";
                //_Buscar.Enabled = false;
            }
        }
    }
}
