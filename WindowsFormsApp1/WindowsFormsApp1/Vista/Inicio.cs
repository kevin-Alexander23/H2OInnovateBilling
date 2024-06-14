using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelo;
using WindowsFormsApp1.Vista;


namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.Show();
        }

        private void btnContadores_Click(object sender, EventArgs e)
        {
            Contadores contadores = new Contadores();
            contadores.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Conexion conectar = new Conexion();
            conectar.Abrir();
        }
    }
}
