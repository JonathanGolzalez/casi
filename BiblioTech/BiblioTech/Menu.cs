using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   

            RegistroLibros Frm  = new RegistroLibros();
            Frm.TopLevel = true;
            Frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            RegistroUsuarios Frm = new RegistroUsuarios();
            Frm.TopLevel = true;
            Frm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
