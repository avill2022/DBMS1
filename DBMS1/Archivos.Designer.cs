namespace DBMS1
{
    partial class Archivos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Consultas = new System.Windows.Forms.TabPage();
            this.Consultas_ = new System.Windows.Forms.GroupBox();
            this._Buscar = new System.Windows.Forms.Button();
            this._Busqueda = new System.Windows.Forms.TextBox();
            this._TipoB = new System.Windows.Forms.Label();
            this.SelectTabla2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tuplas2 = new System.Windows.Forms.DataGridView();
            this.SelectAtributo = new System.Windows.Forms.ComboBox();
            this.Registros = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectTabla1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._EliminaRegistro = new System.Windows.Forms.Button();
            this._NuevoRegistro = new System.Windows.Forms.Button();
            this.Tuplas1 = new System.Windows.Forms.DataGridView();
            this.Base_de_Datos = new System.Windows.Forms.TabPage();
            this._Diccionario = new System.Windows.Forms.GroupBox();
            this.AbrirBD = new System.Windows.Forms.Button();
            this.Actual1 = new System.Windows.Forms.TextBox();
            this.AgregarBD_ = new System.Windows.Forms.Button();
            this._BDS = new System.Windows.Forms.Label();
            this._Atributo = new System.Windows.Forms.GroupBox();
            this.Imagen2 = new System.Windows.Forms.PictureBox();
            this._EliminaA = new System.Windows.Forms.Button();
            this._AgregaA = new System.Windows.Forms.Button();
            this._GridAtributos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._EstatusA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._LongitudA = new System.Windows.Forms.TextBox();
            this._Longitud = new System.Windows.Forms.Label();
            this._TipoA = new System.Windows.Forms.ComboBox();
            this._Tipo = new System.Windows.Forms.Label();
            this._NombreA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Tabla = new System.Windows.Forms.GroupBox();
            this._EliminaT = new System.Windows.Forms.Button();
            this._AgregaT = new System.Windows.Forms.Button();
            this.listBoxE = new System.Windows.Forms.ListBox();
            this.Imagen1 = new System.Windows.Forms.PictureBox();
            this.NombreEntidad = new System.Windows.Forms.TextBox();
            this._NombreTabla = new System.Windows.Forms.Label();
            this._Control = new System.Windows.Forms.TabControl();
            this.Consultas.SuspendLayout();
            this.Consultas_.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tuplas2)).BeginInit();
            this.Registros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tuplas1)).BeginInit();
            this.Base_de_Datos.SuspendLayout();
            this._Diccionario.SuspendLayout();
            this._Atributo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridAtributos)).BeginInit();
            this._Tabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1)).BeginInit();
            this._Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Consultas
            // 
            this.Consultas.Controls.Add(this.Consultas_);
            this.Consultas.Location = new System.Drawing.Point(4, 22);
            this.Consultas.Name = "Consultas";
            this.Consultas.Padding = new System.Windows.Forms.Padding(3);
            this.Consultas.Size = new System.Drawing.Size(611, 282);
            this.Consultas.TabIndex = 2;
            this.Consultas.Text = "Busqueda";
            this.Consultas.UseVisualStyleBackColor = true;
            // 
            // Consultas_
            // 
            this.Consultas_.Controls.Add(this._Buscar);
            this.Consultas_.Controls.Add(this._Busqueda);
            this.Consultas_.Controls.Add(this._TipoB);
            this.Consultas_.Controls.Add(this.SelectTabla2);
            this.Consultas_.Controls.Add(this.label4);
            this.Consultas_.Controls.Add(this.groupBox2);
            this.Consultas_.Controls.Add(this.SelectAtributo);
            this.Consultas_.Location = new System.Drawing.Point(7, 7);
            this.Consultas_.Name = "Consultas_";
            this.Consultas_.Size = new System.Drawing.Size(598, 269);
            this.Consultas_.TabIndex = 0;
            this.Consultas_.TabStop = false;
            this.Consultas_.Text = "Consultas";
            // 
            // _Buscar
            // 
            this._Buscar.Enabled = false;
            this._Buscar.Location = new System.Drawing.Point(555, 18);
            this._Buscar.Name = "_Buscar";
            this._Buscar.Size = new System.Drawing.Size(30, 26);
            this._Buscar.TabIndex = 15;
            this._Buscar.Text = "B";
            this._Buscar.UseVisualStyleBackColor = true;
            this._Buscar.Click += new System.EventHandler(this._Buscar_Click);
            // 
            // _Busqueda
            // 
            this._Busqueda.Enabled = false;
            this._Busqueda.Location = new System.Drawing.Point(437, 21);
            this._Busqueda.Name = "_Busqueda";
            this._Busqueda.Size = new System.Drawing.Size(112, 20);
            this._Busqueda.TabIndex = 16;
            this._Busqueda.TextChanged += new System.EventHandler(this._Busqueda_TextChanged);
            this._Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._Busqueda_KeyPress);
            // 
            // _TipoB
            // 
            this._TipoB.AutoSize = true;
            this._TipoB.Location = new System.Drawing.Point(270, 26);
            this._TipoB.Name = "_TipoB";
            this._TipoB.Size = new System.Drawing.Size(31, 13);
            this._TipoB.TabIndex = 18;
            this._TipoB.Text = "Tipo:";
            // 
            // SelectTabla2
            // 
            this.SelectTabla2.Enabled = false;
            this.SelectTabla2.FormattingEnabled = true;
            this.SelectTabla2.Location = new System.Drawing.Point(52, 22);
            this.SelectTabla2.Name = "SelectTabla2";
            this.SelectTabla2.Size = new System.Drawing.Size(93, 21);
            this.SelectTabla2.TabIndex = 11;
            this.SelectTabla2.TextChanged += new System.EventHandler(this.SelectTabla2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tabla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tuplas2);
            this.groupBox2.Location = new System.Drawing.Point(9, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 213);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // Tuplas2
            // 
            this.Tuplas2.AllowUserToAddRows = false;
            this.Tuplas2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tuplas2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Tuplas2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tuplas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tuplas2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Tuplas2.Location = new System.Drawing.Point(6, 19);
            this.Tuplas2.MultiSelect = false;
            this.Tuplas2.Name = "Tuplas2";
            this.Tuplas2.RowHeadersVisible = false;
            this.Tuplas2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tuplas2.Size = new System.Drawing.Size(570, 188);
            this.Tuplas2.TabIndex = 0;
            // 
            // SelectAtributo
            // 
            this.SelectAtributo.Enabled = false;
            this.SelectAtributo.FormattingEnabled = true;
            this.SelectAtributo.Location = new System.Drawing.Point(165, 22);
            this.SelectAtributo.Name = "SelectAtributo";
            this.SelectAtributo.Size = new System.Drawing.Size(98, 21);
            this.SelectAtributo.TabIndex = 17;
            this.SelectAtributo.TextChanged += new System.EventHandler(this.SelectAtributo_TextChanged);
            // 
            // Registros
            // 
            this.Registros.Controls.Add(this.groupBox1);
            this.Registros.Location = new System.Drawing.Point(4, 22);
            this.Registros.Name = "Registros";
            this.Registros.Padding = new System.Windows.Forms.Padding(3);
            this.Registros.Size = new System.Drawing.Size(611, 282);
            this.Registros.TabIndex = 4;
            this.Registros.Text = "Registros";
            this.Registros.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectTabla1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            // 
            // SelectTabla1
            // 
            this.SelectTabla1.Enabled = false;
            this.SelectTabla1.FormattingEnabled = true;
            this.SelectTabla1.Location = new System.Drawing.Point(58, 22);
            this.SelectTabla1.Name = "SelectTabla1";
            this.SelectTabla1.Size = new System.Drawing.Size(92, 21);
            this.SelectTabla1.TabIndex = 11;
            this.SelectTabla1.TextChanged += new System.EventHandler(this.SelectTabla1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tabla";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._EliminaRegistro);
            this.groupBox3.Controls.Add(this._NuevoRegistro);
            this.groupBox3.Controls.Add(this.Tuplas1);
            this.groupBox3.Location = new System.Drawing.Point(9, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 222);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // _EliminaRegistro
            // 
            this._EliminaRegistro.Enabled = false;
            this._EliminaRegistro.Location = new System.Drawing.Point(546, 51);
            this._EliminaRegistro.Name = "_EliminaRegistro";
            this._EliminaRegistro.Size = new System.Drawing.Size(30, 26);
            this._EliminaRegistro.TabIndex = 10;
            this._EliminaRegistro.Text = "-";
            this._EliminaRegistro.UseVisualStyleBackColor = true;
            this._EliminaRegistro.Click += new System.EventHandler(this._EliminaRegistro_Click);
            // 
            // _NuevoRegistro
            // 
            this._NuevoRegistro.Enabled = false;
            this._NuevoRegistro.Location = new System.Drawing.Point(546, 19);
            this._NuevoRegistro.Name = "_NuevoRegistro";
            this._NuevoRegistro.Size = new System.Drawing.Size(30, 26);
            this._NuevoRegistro.TabIndex = 9;
            this._NuevoRegistro.Text = "+";
            this._NuevoRegistro.UseVisualStyleBackColor = true;
            this._NuevoRegistro.Click += new System.EventHandler(this._NuevoRegistro_Click);
            // 
            // Tuplas1
            // 
            this.Tuplas1.AllowUserToAddRows = false;
            this.Tuplas1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tuplas1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Tuplas1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Tuplas1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Tuplas1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tuplas1.Location = new System.Drawing.Point(12, 19);
            this.Tuplas1.MultiSelect = false;
            this.Tuplas1.Name = "Tuplas1";
            this.Tuplas1.RowHeadersVisible = false;
            this.Tuplas1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tuplas1.Size = new System.Drawing.Size(528, 197);
            this.Tuplas1.TabIndex = 0;
            this.Tuplas1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tuplas1_CellClick);
            this.Tuplas1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tuplas1_CellEndEdit);
            // 
            // Base_de_Datos
            // 
            this.Base_de_Datos.Controls.Add(this._Diccionario);
            this.Base_de_Datos.Location = new System.Drawing.Point(4, 22);
            this.Base_de_Datos.Name = "Base_de_Datos";
            this.Base_de_Datos.Padding = new System.Windows.Forms.Padding(3);
            this.Base_de_Datos.Size = new System.Drawing.Size(611, 282);
            this.Base_de_Datos.TabIndex = 1;
            this.Base_de_Datos.Text = "Dicionario";
            this.Base_de_Datos.UseVisualStyleBackColor = true;
            // 
            // _Diccionario
            // 
            this._Diccionario.Controls.Add(this.AbrirBD);
            this._Diccionario.Controls.Add(this.Actual1);
            this._Diccionario.Controls.Add(this.AgregarBD_);
            this._Diccionario.Controls.Add(this._BDS);
            this._Diccionario.Controls.Add(this._Atributo);
            this._Diccionario.Controls.Add(this._Tabla);
            this._Diccionario.Location = new System.Drawing.Point(7, 7);
            this._Diccionario.Name = "_Diccionario";
            this._Diccionario.Size = new System.Drawing.Size(598, 269);
            this._Diccionario.TabIndex = 0;
            this._Diccionario.TabStop = false;
            this._Diccionario.Text = "Diccionario";
            // 
            // AbrirBD
            // 
            this.AbrirBD.Location = new System.Drawing.Point(291, 241);
            this.AbrirBD.Name = "AbrirBD";
            this.AbrirBD.Size = new System.Drawing.Size(70, 24);
            this.AbrirBD.TabIndex = 14;
            this.AbrirBD.Text = "NuevoArchivo";
            this.AbrirBD.UseVisualStyleBackColor = true;
            this.AbrirBD.Click += new System.EventHandler(this.AbrirBD_Click);
            // 
            // Actual1
            // 
            this.Actual1.Enabled = false;
            this.Actual1.Location = new System.Drawing.Point(108, 243);
            this.Actual1.Name = "Actual1";
            this.Actual1.Size = new System.Drawing.Size(100, 20);
            this.Actual1.TabIndex = 13;
            this.Actual1.TextChanged += new System.EventHandler(this.Actual1_TextChanged_1);
            // 
            // AgregarBD_
            // 
            this.AgregarBD_.Location = new System.Drawing.Point(215, 241);
            this.AgregarBD_.Name = "AgregarBD_";
            this.AgregarBD_.Size = new System.Drawing.Size(70, 23);
            this.AgregarBD_.TabIndex = 12;
            this.AgregarBD_.Text = "Abrir";
            this.AgregarBD_.UseVisualStyleBackColor = true;
            this.AgregarBD_.Click += new System.EventHandler(this.AgregarBD__Click_1);
            // 
            // _BDS
            // 
            this._BDS.AutoSize = true;
            this._BDS.Location = new System.Drawing.Point(13, 243);
            this._BDS.Name = "_BDS";
            this._BDS.Size = new System.Drawing.Size(86, 13);
            this._BDS.TabIndex = 11;
            this._BDS.Text = "Nombre Archivo:";
            // 
            // _Atributo
            // 
            this._Atributo.Controls.Add(this.Imagen2);
            this._Atributo.Controls.Add(this._EliminaA);
            this._Atributo.Controls.Add(this._AgregaA);
            this._Atributo.Controls.Add(this._GridAtributos);
            this._Atributo.Controls.Add(this._EstatusA);
            this._Atributo.Controls.Add(this.label3);
            this._Atributo.Controls.Add(this._LongitudA);
            this._Atributo.Controls.Add(this._Longitud);
            this._Atributo.Controls.Add(this._TipoA);
            this._Atributo.Controls.Add(this._Tipo);
            this._Atributo.Controls.Add(this._NombreA);
            this._Atributo.Controls.Add(this.label1);
            this._Atributo.Enabled = false;
            this._Atributo.Location = new System.Drawing.Point(271, 19);
            this._Atributo.Name = "_Atributo";
            this._Atributo.Size = new System.Drawing.Size(319, 221);
            this._Atributo.TabIndex = 6;
            this._Atributo.TabStop = false;
            this._Atributo.Text = "Atributo";
            // 
            // Imagen2
            // 
            this.Imagen2.Location = new System.Drawing.Point(168, 13);
            this.Imagen2.Name = "Imagen2";
            this.Imagen2.Size = new System.Drawing.Size(33, 31);
            this.Imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen2.TabIndex = 13;
            this.Imagen2.TabStop = false;
            // 
            // _EliminaA
            // 
            this._EliminaA.Enabled = false;
            this._EliminaA.Location = new System.Drawing.Point(283, 111);
            this._EliminaA.Name = "_EliminaA";
            this._EliminaA.Size = new System.Drawing.Size(30, 26);
            this._EliminaA.TabIndex = 12;
            this._EliminaA.Text = "-";
            this._EliminaA.UseVisualStyleBackColor = true;
            this._EliminaA.Click += new System.EventHandler(this._EliminaA_Click);
            // 
            // _AgregaA
            // 
            this._AgregaA.Enabled = false;
            this._AgregaA.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._AgregaA.Location = new System.Drawing.Point(283, 79);
            this._AgregaA.Name = "_AgregaA";
            this._AgregaA.Size = new System.Drawing.Size(30, 26);
            this._AgregaA.TabIndex = 11;
            this._AgregaA.Text = "+";
            this._AgregaA.UseVisualStyleBackColor = true;
            this._AgregaA.Click += new System.EventHandler(this._AgregaA_Click);
            // 
            // _GridAtributos
            // 
            this._GridAtributos.AllowUserToAddRows = false;
            this._GridAtributos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this._GridAtributos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._GridAtributos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._GridAtributos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Tipo,
            this.Longitud,
            this.Llave});
            this._GridAtributos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this._GridAtributos.Location = new System.Drawing.Point(9, 79);
            this._GridAtributos.MultiSelect = false;
            this._GridAtributos.Name = "_GridAtributos";
            this._GridAtributos.RowHeadersVisible = false;
            this._GridAtributos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._GridAtributos.Size = new System.Drawing.Size(268, 130);
            this._GridAtributos.TabIndex = 10;
            this._GridAtributos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._GridAtributos_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Longitud
            // 
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.Name = "Longitud";
            // 
            // Llave
            // 
            this.Llave.HeaderText = "Llave";
            this.Llave.Name = "Llave";
            // 
            // _EstatusA
            // 
            this._EstatusA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._EstatusA.Enabled = false;
            this._EstatusA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._EstatusA.FormattingEnabled = true;
            this._EstatusA.Location = new System.Drawing.Point(194, 51);
            this._EstatusA.Name = "_EstatusA";
            this._EstatusA.Size = new System.Drawing.Size(55, 21);
            this._EstatusA.TabIndex = 9;
            this._EstatusA.TextChanged += new System.EventHandler(this._EstatusA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo Llave:";
            // 
            // _LongitudA
            // 
            this._LongitudA.Enabled = false;
            this._LongitudA.Location = new System.Drawing.Point(63, 50);
            this._LongitudA.Name = "_LongitudA";
            this._LongitudA.Size = new System.Drawing.Size(59, 20);
            this._LongitudA.TabIndex = 7;
            this._LongitudA.TextChanged += new System.EventHandler(this._LongitudA_TextChanged);
            // 
            // _Longitud
            // 
            this._Longitud.AutoSize = true;
            this._Longitud.Location = new System.Drawing.Point(6, 53);
            this._Longitud.Name = "_Longitud";
            this._Longitud.Size = new System.Drawing.Size(51, 13);
            this._Longitud.TabIndex = 6;
            this._Longitud.Text = "Longitud:";
            // 
            // _TipoA
            // 
            this._TipoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._TipoA.Enabled = false;
            this._TipoA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._TipoA.FormattingEnabled = true;
            this._TipoA.Items.AddRange(new object[] {
            "int",
            "float",
            "char",
            "string",
            "bool"});
            this._TipoA.Location = new System.Drawing.Point(258, 15);
            this._TipoA.Name = "_TipoA";
            this._TipoA.Size = new System.Drawing.Size(55, 21);
            this._TipoA.TabIndex = 5;
            this._TipoA.TextChanged += new System.EventHandler(this._TipoA_TextChanged);
            // 
            // _Tipo
            // 
            this._Tipo.AutoSize = true;
            this._Tipo.Location = new System.Drawing.Point(221, 19);
            this._Tipo.Name = "_Tipo";
            this._Tipo.Size = new System.Drawing.Size(31, 13);
            this._Tipo.TabIndex = 4;
            this._Tipo.Text = "Tipo:";
            // 
            // _NombreA
            // 
            this._NombreA.Location = new System.Drawing.Point(54, 19);
            this._NombreA.Name = "_NombreA";
            this._NombreA.Size = new System.Drawing.Size(108, 20);
            this._NombreA.TabIndex = 3;
            this._NombreA.TextChanged += new System.EventHandler(this._NombreA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // _Tabla
            // 
            this._Tabla.Controls.Add(this._EliminaT);
            this._Tabla.Controls.Add(this._AgregaT);
            this._Tabla.Controls.Add(this.listBoxE);
            this._Tabla.Controls.Add(this.Imagen1);
            this._Tabla.Controls.Add(this.NombreEntidad);
            this._Tabla.Controls.Add(this._NombreTabla);
            this._Tabla.Enabled = false;
            this._Tabla.Location = new System.Drawing.Point(6, 19);
            this._Tabla.Name = "_Tabla";
            this._Tabla.Size = new System.Drawing.Size(247, 198);
            this._Tabla.TabIndex = 5;
            this._Tabla.TabStop = false;
            this._Tabla.Text = "Tabla";
            // 
            // _EliminaT
            // 
            this._EliminaT.Enabled = false;
            this._EliminaT.Location = new System.Drawing.Point(209, 83);
            this._EliminaT.Name = "_EliminaT";
            this._EliminaT.Size = new System.Drawing.Size(30, 26);
            this._EliminaT.TabIndex = 5;
            this._EliminaT.Text = "-";
            this._EliminaT.UseVisualStyleBackColor = true;
            this._EliminaT.Click += new System.EventHandler(this._EliminaT_Click);
            // 
            // _AgregaT
            // 
            this._AgregaT.Enabled = false;
            this._AgregaT.Location = new System.Drawing.Point(209, 51);
            this._AgregaT.Name = "_AgregaT";
            this._AgregaT.Size = new System.Drawing.Size(30, 26);
            this._AgregaT.TabIndex = 4;
            this._AgregaT.Text = "+";
            this._AgregaT.UseVisualStyleBackColor = true;
            this._AgregaT.Click += new System.EventHandler(this._AgregaT_Click);
            // 
            // listBoxE
            // 
            this.listBoxE.FormattingEnabled = true;
            this.listBoxE.Location = new System.Drawing.Point(10, 50);
            this.listBoxE.Name = "listBoxE";
            this.listBoxE.Size = new System.Drawing.Size(192, 134);
            this.listBoxE.TabIndex = 3;
            this.listBoxE.SelectedIndexChanged += new System.EventHandler(this.listBoxE_SelectedIndexChanged);
            // 
            // Imagen1
            // 
            this.Imagen1.Location = new System.Drawing.Point(206, 12);
            this.Imagen1.Name = "Imagen1";
            this.Imagen1.Size = new System.Drawing.Size(33, 31);
            this.Imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imagen1.TabIndex = 2;
            this.Imagen1.TabStop = false;
            // 
            // NombreEntidad
            // 
            this.NombreEntidad.Location = new System.Drawing.Point(55, 17);
            this.NombreEntidad.Name = "NombreEntidad";
            this.NombreEntidad.Size = new System.Drawing.Size(147, 20);
            this.NombreEntidad.TabIndex = 1;
            this.NombreEntidad.TextChanged += new System.EventHandler(this.NombreEntidad_TextChanged);
            this.NombreEntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreEntidad_KeyPress);
            // 
            // _NombreTabla
            // 
            this._NombreTabla.AutoSize = true;
            this._NombreTabla.Location = new System.Drawing.Point(7, 20);
            this._NombreTabla.Name = "_NombreTabla";
            this._NombreTabla.Size = new System.Drawing.Size(47, 13);
            this._NombreTabla.TabIndex = 0;
            this._NombreTabla.Text = "Nombre:";
            // 
            // _Control
            // 
            this._Control.Controls.Add(this.Base_de_Datos);
            this._Control.Controls.Add(this.Registros);
            this._Control.Controls.Add(this.Consultas);
            this._Control.Location = new System.Drawing.Point(12, 12);
            this._Control.Name = "_Control";
            this._Control.SelectedIndex = 0;
            this._Control.Size = new System.Drawing.Size(619, 308);
            this._Control.TabIndex = 0;
            // 
            // Archivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(643, 332);
            this.Controls.Add(this._Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(659, 390);
            this.MinimumSize = new System.Drawing.Size(659, 371);
            this.Name = "Archivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.Consultas.ResumeLayout(false);
            this.Consultas_.ResumeLayout(false);
            this.Consultas_.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tuplas2)).EndInit();
            this.Registros.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tuplas1)).EndInit();
            this.Base_de_Datos.ResumeLayout(false);
            this._Diccionario.ResumeLayout(false);
            this._Diccionario.PerformLayout();
            this._Atributo.ResumeLayout(false);
            this._Atributo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GridAtributos)).EndInit();
            this._Tabla.ResumeLayout(false);
            this._Tabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1)).EndInit();
            this._Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Consultas;
        private System.Windows.Forms.GroupBox Consultas_;
        private System.Windows.Forms.ComboBox SelectTabla2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label _TipoB;
        private System.Windows.Forms.Button _Buscar;
        private System.Windows.Forms.TextBox _Busqueda;
        private System.Windows.Forms.ComboBox SelectAtributo;
        private System.Windows.Forms.DataGridView Tuplas2;
        private System.Windows.Forms.TabPage Registros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SelectTabla1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button _EliminaRegistro;
        private System.Windows.Forms.Button _NuevoRegistro;
        private System.Windows.Forms.DataGridView Tuplas1;
        private System.Windows.Forms.TabPage Base_de_Datos;
        private System.Windows.Forms.GroupBox _Diccionario;
        private System.Windows.Forms.GroupBox _Atributo;
        private System.Windows.Forms.PictureBox Imagen2;
        private System.Windows.Forms.Button _EliminaA;
        private System.Windows.Forms.Button _AgregaA;
        private System.Windows.Forms.DataGridView _GridAtributos;
        private System.Windows.Forms.ComboBox _EstatusA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _LongitudA;
        private System.Windows.Forms.Label _Longitud;
        private System.Windows.Forms.ComboBox _TipoA;
        private System.Windows.Forms.Label _Tipo;
        private System.Windows.Forms.TextBox _NombreA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _Tabla;
        private System.Windows.Forms.Button _EliminaT;
        private System.Windows.Forms.Button _AgregaT;
        private System.Windows.Forms.ListBox listBoxE;
        private System.Windows.Forms.PictureBox Imagen1;
        private System.Windows.Forms.TextBox NombreEntidad;
        private System.Windows.Forms.Label _NombreTabla;
        private System.Windows.Forms.TabControl _Control;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llave;
        private System.Windows.Forms.Button AbrirBD;
        private System.Windows.Forms.TextBox Actual1;
        private System.Windows.Forms.Button AgregarBD_;
        private System.Windows.Forms.Label _BDS;
    }
}