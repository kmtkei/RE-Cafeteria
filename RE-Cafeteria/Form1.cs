using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RE_Cafeteria.Modelo;
using RE_Cafeteria.Controlador;

namespace RE_Cafeteria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ingresarUsuario nuevo = new ingresarUsuario();
            nuevo.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        public void MostrarUsuarios() {
            DataTable DT = new DataTable();
            BDUsuario bdu = new BDUsuario();
            bdu.mostrar(ref DT);
            dataGridView1.DataSource = DT;
        }

    }
}
