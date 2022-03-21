using System;
using System.Windows.Forms;

namespace Sofka_challenge
{
    public partial class FormJugador : Form
    {

        public static string nombreJugador;
        public FormJugador()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (txtJugador.Text != "")
            {
                nombreJugador = txtJugador.Text;
                Form iniciarJuego = new FormRonda();
                iniciarJuego.Show();
                Application.OpenForms[0].Hide();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor ingrese su nombre para continuar.");
            }
        }


    }
}
