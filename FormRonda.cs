using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Sofka_challenge
{
    public partial class FormRonda : Form
    {
        private static string _path = "./preguntas.json";
        public List<Categoria> categorias = CargarPreguntas();

        private Pregunta pregunta;
        private int ronda;
        private int puntosAcumulados;
        string jugador = FormJugador.nombreJugador;

        // Para elegir pregunta y orden de opciones aleatorios
        private int eleccionPregunta;
        private int op;


        public FormRonda()
        {
            InitializeComponent();
            this.Focus();
            CargarRonda();
        }

        //Funciones
        public static List<Categoria> CargarPreguntas()
        {
            string PreguntasDesdeJson;
            using (var reader = new StreamReader(_path))
            { PreguntasDesdeJson = reader.ReadToEnd(); }
            var categorias = JsonConvert.DeserializeObject<List<Categoria>>(PreguntasDesdeJson);
            return categorias;
        }

        private void CargarRonda()
        {
            this.eleccionPregunta = new Random().Next(0, 4);
            this.op = new Random().Next(0, 3);
            this.pregunta = categorias[ronda].Preguntas[eleccionPregunta];


            lbPregunta.Text = pregunta.TextoPregunta;
            lbRonda.Text = string.Format("Ronda {0}", ronda + 1);
            lbPuntos.Text = string.Format("Puntos: {0}", puntosAcumulados);

            btnOpcion1.Text = pregunta.Opciones[op].TextoOpcion;
            btnOpcion2.Text = pregunta.Opciones[op + 1 < 4 ? op + 1 : op - 3].TextoOpcion;
            btnOpcion3.Text = pregunta.Opciones[op + 2 < 4 ? op + 2 : op - 2].TextoOpcion;
            btnOpcion4.Text = pregunta.Opciones[op + 3 < 4 ? op + 3 : op - 1].TextoOpcion;
        }


        private void SiguienteRonda(bool verificador)
        {
            this.Hide();
            FormInformativo continuar = new FormInformativo();


            if (verificador)
            {
                puntosAcumulados += categorias[ronda].Puntos;

                if (ronda < 4)
                {
                    continuar.CargarCorrecto(ronda, puntosAcumulados, categorias[ronda + 1].Puntos);
                    if (continuar.ShowDialog() == DialogResult.OK)
                    {
                        this.ronda++;
                        CargarRonda();
                        this.Focus();
                    }
                    else
                    {
                        GuardarRegistro();
                        continuar.CargarRetiro(puntosAcumulados);
                        continuar.ShowDialog();
                    }
                }

                else
                {
                    GuardarRegistro();
                    continuar.CargarFinal(puntosAcumulados);
                    continuar.ShowDialog();
                }
            }
            else
            {
                continuar.CargarIncorrecto();
                continuar.ShowDialog();
            }
        }


        private void GuardarRegistro()
        {
            var jugadores = Historicos.GetJugador(jugador, puntosAcumulados);
            Historicos.EscribirHistoricos(jugadores);
        }

        // Eventos
        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            var verificador = Pregunta.VerificarRespuesta(pregunta.Opciones[op]);
            SiguienteRonda(verificador);

        }
        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            var verificador = Pregunta.VerificarRespuesta(pregunta.Opciones[op + 1 < 4 ? op + 1 : op - 3]);
            SiguienteRonda(verificador);

        }
        private void btnOpcion3_Click(object sender, EventArgs e)
        {
            var verificador = Pregunta.VerificarRespuesta(pregunta.Opciones[op + 2 < 4 ? op + 2 : op - 2]);
            SiguienteRonda(verificador);

        }
        private void btnOpcion4_Click(object sender, EventArgs e)
        {
            var verificador = Pregunta.VerificarRespuesta(pregunta.Opciones[op + 3 < 4 ? op + 3 : op - 1]);
            SiguienteRonda(verificador);
        }


        private void FormRonda_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Si sale perdera todo su progreso." +
              "\n ¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);

            if (salir != DialogResult.Yes)
            {
                e.Cancel = true;
            }

        }

        private void FormRonda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
