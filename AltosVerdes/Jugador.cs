using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltosVerdes
{
    class Jugador
    {
        private string nombre;
        private int camiseta;
        private int faltas = 0;
        private int tantos = 0;

        public Jugador (int camiseta, string nombre)
        {
            this.camiseta = camiseta;
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Camiseta
        {
            get { return camiseta; }
        }

        public int Faltas
        {
            get { return faltas; }
            set { faltas += value; }
        }

        public int Tantos
        {
            get { return tantos; }
            set { tantos += value; }
        }
    }
}
