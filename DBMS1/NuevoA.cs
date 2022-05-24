using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS1
{
    public partial class NuevoA : Form
    {
        Archivos ar= null;
        public NuevoA(Archivos archi)
        {
            InitializeComponent();
            ar = archi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ar.creaNuevaBase(textBox1.Text);
            this.Close();
        }
    }
}
