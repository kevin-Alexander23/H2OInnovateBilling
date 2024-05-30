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

namespace WindowsFormsApp1
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            dataGridView1.DataSource = llenar_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public DataTable llenar_grid()
        {
            Conexion conexion = new Conexion();
            DataTable dt = new DataTable();
            string consulta = "select * from Clientes";
            SqlCommand cdm = new SqlCommand(consulta);

            SqlDataAdapter da = new SqlDataAdapter(cdm);
            da.Fill(dt);
            return dt;
        }
    }
}
