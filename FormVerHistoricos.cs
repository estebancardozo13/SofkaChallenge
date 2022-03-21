using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sofka_challenge
{
    public partial class FormVerHistoricos : Form
    {


        public FormVerHistoricos()
        {
            InitializeComponent();
            MostrarHistoricos();
        }

        public void MostrarHistoricos()
        {
            if (Historicos.CargarHistoricos() != null)
            {
                var historicos = Historicos.CargarHistoricos().OrderByDescending(x => x.Premio.Puntos).ToList();

                foreach (Jugador i in historicos)
                {
                    ListViewItem item = lstHistoricos.Items.Add(i.Nombre);
                    item.SubItems.Add(i.Premio.Puntos.ToString());
                    item.SubItems.Add(i.Premio.Fecha.ToString());

                }
            }
        }

        //Eventos
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }

        private void FormVerHistoricos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();

        }
    }
}
