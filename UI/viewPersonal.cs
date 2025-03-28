using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGloriaDataBase
{
    public partial class viewPersonal : Form
    {
        public viewPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewAgregarPersonal windowAgregar= new viewAgregarPersonal();
            windowAgregar.StartPosition = FormStartPosition.Manual;
            windowAgregar.Location = this.Location;
            windowAgregar.Size = this.Size;

            // Mostrar la nueva ventana
            windowAgregar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewBuscarPersonal windowBuscar = new viewBuscarPersonal();
            windowBuscar.StartPosition = FormStartPosition.Manual;
            windowBuscar.Location = this.Location;
            windowBuscar.Size = this.Size;

            // Mostrar la nueva ventana
            windowBuscar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewModificarPersonal windowModificar = new viewModificarPersonal();
            windowModificar.StartPosition = FormStartPosition.Manual;
            windowModificar.Location = this.Location;
            windowModificar.Size = this.Size;

            // Mostrar la nueva ventana
            windowModificar.Show();
        }
    }
}
