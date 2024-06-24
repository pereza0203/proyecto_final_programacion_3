using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMainMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Form formActual = null;
        private void AbrirRegistrarProfesores(object FormRegistrarProfesores)
        {

            if (formActual != null)
            {
                this.panelContenedor.Controls.Remove(formActual);
            }

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt (0);
            Form FR = FormRegistrarProfesores as Form;
            FR.TopLevel = false;
            FR.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add (FR);
            this.panelContenedor.Tag = FR;
            FR.Show();
            formActual = FR as Form;
        }
    }
}
