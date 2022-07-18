using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltosVerdes
{
    class Equipo
    {
        private string nombre;
        private Jugador[] jugadores = new Jugador[12];
        private int agregados = 0;
        private int puntos = 0;
        private int faltas = 0;
        private bool local;

        public Equipo(string nombre, bool local)
        {
            this.nombre = nombre;
            this.local = local;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public Jugador[] Jugadores
        {
            get { return jugadores; }
        }

        public int Puntos
        {
            get { return puntos; }
        }

        public int Faltas
        {
            get { return faltas; }
        }

        public bool Local
        {
            get { return local; }
        }

        public bool cargarJugador(Jugador jugador)
        {
            bool result;
            if (agregados < 12)
            {
                jugadores[jugador.Camiseta - 1] = jugador;
                agregados++;
                result = true;
            }
            else result = false;
            return result;
        }

        public void cargarTanto(int camiseta, int tanto)
        {
            jugadores[camiseta - 1].Tantos += tanto;
            puntos += tanto;
        }

        public void cargarFalta(int camiseta)
        {
            jugadores[camiseta - 1].Faltas++;
            faltas++;
        }

    }
}
