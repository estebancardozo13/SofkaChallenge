using System;
using System.Windows.Forms;

namespace Sofka_challenge
{
    public partial class Consultados : Form
    {
        public Consultados()
        {
            InitializeComponent();
        }

        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            Form jugador = new FormJugador();
            jugador.ShowDialog();
        }

        private void btnRecords(object sender, EventArgs e)
        {
            this.Hide();
            Form historicos = new FormVerHistoricos();
            historicos.ShowDialog();
        }

    }
}
