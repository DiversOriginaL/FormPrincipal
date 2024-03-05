using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPrincipal.FormsButton.Paciente.FormHijos;

namespace FormPrincipal.FormsButton.Paciente
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrudPaciente crudPaciente = new CrudPaciente();

            crudPaciente.Show();
        }
    }
}
