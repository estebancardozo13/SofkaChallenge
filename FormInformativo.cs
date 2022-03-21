using System;
using System.Windows.Forms;

namespace Sofka_challenge
{
    public partial class FormInformativo : Form
    {
        //Funciones
        public FormInformativo()
        {
            InitializeComponent();
        }

        public void CargarCorrecto(int ronda, int puntosAcumulados, int siguientePremio)
        {
            lbDeclarador.Text = "¡¡CORRECTO!!";
            lbMensaje.Text = "Tienes " + puntosAcumulados + " Puntos";
            lbSiguiente.Text = "Siguiente premio \n" + siguientePremio + " Puntos";
        }
        public void CargarIncorrecto()
        {
            lbDeclarador.Text = "Incorrecto";
            lbDeclarador.ForeColor = System.Drawing.Color.Red;
            lbMensaje.Text = "Lo lamento, has perdido";
            lbMensaje.ForeColor = System.Drawing.Color.Red;
            lbSiguiente.Text = "¡Animo! Vuelve a intentarlo";
            lbPregunta.Visible = false;
            btnInicio.Visible = true;
            btnContinuar.Visible = false;
            btnRetirarse.Visible = false;
        }
        public void CargarRetiro(int puntosAcumulados)
        {
            lbDeclarador.Text = "Felicidades";
            lbMensaje.Text = "Has ganado " + puntosAcumulados + " Puntos";
            lbSiguiente.Text = "¡Sigue mejorando tu puntaje!";
            lbPregunta.Visible = false;
            btnContinuar.Visible = false;
            btnRetirarse.Visible = false;
            btnInicio.Visible = true;
        }

        public void CargarFinal(int puntosAcumulados)
        {
            lbDeclarador.Text = "¡HAS GANADO!";
            lbMensaje.Text = "Conseguiste " + puntosAcumulados + " Puntos";
            lbSiguiente.Text = "¡No hay duda que eres el mejor!";
            lbPregunta.Visible = false;
            btnContinuar.Visible = false;
            btnRetirarse.Visible = false;
            btnInicio.Visible = true;
        }

        // Eventos
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[1].Show();
            Application.OpenForms[1].Focus();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[1].Dispose();
            Application.OpenForms[0].Show();
        }
        private void FormInformativo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lbDeclarador.Text != "¡¡CORRECTO!!")
            {
                Application.OpenForms[0].Close();
            }


        }
    }
}
