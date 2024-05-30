using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp1.Modelo
{
    class Conexion
    {
        SqlConnection con;
        public Conexion()
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-02IV51R//SQLkevin;Initial catalog=FacturacionAguaPotable");
                con.Open();
                MessageBox.Show("Bienvenido");
            }
            catch (Exception e)
            {
                MessageBox.Show("Usuario no encontrado");
            }

        }
    }
}
