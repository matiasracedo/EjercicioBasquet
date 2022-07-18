using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltosVerdes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Instancio objetos de equipos y ventanas modal
        Equipo equipoLocal;
        Equipo equipoVisitante;
        CargaEquipos equipoLoc;
        CargaEquipos equipoVisit;
        bool local;

        private void actualizarTablero()
        {
            labLocal.Text = equipoLocal.Puntos.ToString();
            labVisitante.Text = equipoVisitante.Puntos.ToString();
            labFaltasLoc.Text = equipoLocal.Faltas.ToString();
            labFaltasVis.Text = equipoVisitante.Faltas.ToString();
        }

        private void btnCargar1_Click(object sender, EventArgs e)
        {
            // Inicializo ventana modal carga equipos
            equipoLoc = new CargaEquipos();
            local = true;

            // Inicializo evento click boton cargar y continuar
            equipoLoc.btnCargar.Click += new System.EventHandler(this.formCarga_btnAgregar_Click);
            equipoLoc.btnContinuar.Click += new System.EventHandler(this.formCarga_btnContinuar_Click);

            equipoLoc.ShowDialog();
            equipoLoc.btnCargar.Click -= new System.EventHandler(this.formCarga_btnAgregar_Click);
            equipoLoc.btnContinuar.Click -= new System.EventHandler(this.formCarga_btnContinuar_Click);
            equipoLoc.Dispose();
            labNombre1.Text = equipoLocal.Nombre;
            btnCargar1.Enabled = false;
            if (!btnCargar2.Enabled) btnIniciar.Enabled = true;
        }

        private void btnCargar2_Click(object sender, EventArgs e)
        {
            // Inicializo ventana modal carga equipos
            equipoVisit = new CargaEquipos();
            local = false;

            // Inicializo evento click boton cargar y continuar
            equipoVisit.btnCargar.Click += new System.EventHandler(this.formCarga_btnAgregar_Click);
            equipoVisit.btnContinuar.Click += new System.EventHandler(this.formCarga_btnContinuar_Click);

            equipoVisit.ShowDialog();
            equipoVisit.btnCargar.Click -= new System.EventHandler(this.formCarga_btnAgregar_Click);
            equipoVisit.btnContinuar.Click -= new System.EventHandler(this.formCarga_btnContinuar_Click);
            equipoVisit.Dispose();
            labNombre2.Text = equipoVisitante.Nombre;
            btnCargar2.Enabled = false;
            if (!btnCargar1.Enabled) btnIniciar.Enabled = true;
        }

        private void formCarga_btnContinuar_Click(object sender, EventArgs e)
        {
            // Inicializo equipos
            if (local)
            {
                string equipo = equipoLoc.tbEquipo.Text;
                equipoLocal = new Equipo(equipo, local);
            }
            else
            {
                string equipo = equipoVisit.tbEquipo.Text;
                equipoVisitante = new Equipo(equipo, local);
            }
            
        }

        private void formCarga_btnAgregar_Click(object sender, EventArgs e)
        {
            if (local)
            {
                // Inicio carga jugadores equipo local
                int camiseta = Convert.ToInt32(equipoLoc.cBCamiseta.SelectedItem.ToString());
                string nombre = equipoLoc.tBJugador.Text;
                Jugador jugador = new Jugador(camiseta, nombre);

                bool result = equipoLocal.cargarJugador(jugador);
                if (result)
                {
                    equipoLoc.cBCamiseta.ResetText();
                    equipoLoc.tBJugador.Clear();
                }
                else
                {
                    equipoLoc.tBJugador.Text = "ERROR! Equipo completo";
                    equipoLoc.gBjugadores.Enabled = false;
                }
            }
            else
            {
                // Inicio carga jugadores equipo visitante
                int camiseta = Convert.ToInt32(equipoVisit.cBCamiseta.SelectedItem.ToString());
                string nombre = equipoVisit.tBJugador.Text;
                Jugador jugador = new Jugador(camiseta, nombre);

                bool result = equipoVisitante.cargarJugador(jugador);
                if (result)
                {
                    equipoVisit.cBCamiseta.ResetText();
                    equipoVisit.tBJugador.Clear();
                }
                else
                {
                    equipoVisit.tBJugador.Text = "ERROR! Equipo completo";
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Visible = false;
            btnFinalizar.Visible = true;
            btnTanto.Enabled = true;
            btnFalta.Enabled = true;
        }

        private void btnTanto_Click(object sender, EventArgs e)
        {
            // Creo nueva ventana modal de carga
            TantoFalta ventana = new TantoFalta();
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                int equipo = ventana.cBequipo.SelectedIndex;
                int camiseta = Convert.ToInt32(ventana.cBjugador.SelectedItem.ToString());
                int tanto = Convert.ToInt32(ventana.cBtanto.SelectedItem.ToString());
                if (equipo == 0)
                {
                    equipoLocal.cargarTanto(camiseta, tanto);
                }
                else equipoVisitante.cargarTanto(camiseta, tanto);
            }
            ventana.Dispose();
            actualizarTablero();
        }

        private void btnFalta_Click(object sender, EventArgs e)
        {
            // Creo nueva ventana modal de carga
            TantoFalta ventana = new TantoFalta();
            ventana.labTanto.Visible = false;
            ventana.cBtanto.Visible = false;
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                int equipo = ventana.cBequipo.SelectedIndex;
                int camiseta = Convert.ToInt32(ventana.cBjugador.SelectedItem.ToString());
                if (equipo == 0)
                {
                    equipoLocal.cargarFalta(camiseta);
                }
                else equipoVisitante.cargarFalta(camiseta);
            }
            ventana.Dispose();
            actualizarTablero();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Creo nueva ventana modal resultado
            Resultado ventana = new Resultado();
            // LLeno columna local
            ventana.lBlocal.Items.Add("LOCALES");
            ventana.lBlocal.Items.Add("Jugador       |       Puntos");
            ventana.lBlocal.Items.Add("*****************************");
            for (int i = 0; i < 12; i++)
            {
                ventana.lBlocal.Items.Add(equipoLocal.Jugadores[i].Nombre+"             "+ equipoLocal.Jugadores[i].Tantos.ToString());
            }

            ventana.ShowDialog();
            ventana.Dispose();
        }
    }
}
