using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RE_Cafeteria
{
    public partial class ingresarUsuario : Form
    {
        public ingresarUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "")&&(textBox3.Text != "") && (textBox4.Text != ""))
            {
                MessageBox.Show("Usuario Ingresado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
