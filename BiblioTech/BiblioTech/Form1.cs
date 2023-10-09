using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
           

            Menu Frm = new Menu();
            Frm.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {
            if(txtUsuarioLogin.Text== "USUARIO")
            {
                txtUsuarioLogin.Text = "";
                
            }
        }

        private void txtContraLogin_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
