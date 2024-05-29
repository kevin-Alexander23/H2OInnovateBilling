using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controlador
{
    internal class Cliente
    {
        public int Clienteid { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        public String Email { get; set; }


        public Cliente(int Clienteid, string Nombre, string Direccion, int Telefono, string Email)
        {
            this.Clienteid = Clienteid;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Email = Email;

        }
    }
}
