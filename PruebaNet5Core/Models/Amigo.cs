using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNet5Core.Models
{
    public class Amigo
    {

        private int id;
        private string nombres;
        private string correo;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Correo { get => correo; set => correo = value; }

        public Amigo()
        {
        }

        public Amigo(int id, string nombres, string correo)
        {
            this.id = id;
            this.nombres = nombres;
            this.correo = correo;
        }
    }
}
