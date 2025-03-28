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
    public partial class viewAgregarPersonal : Form
    {
        public viewAgregarPersonal()
        {
            InitializeComponent();
        }

        private void viewAgregarPesonal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBHotelGloriaDataSet2.TPersonal' Puede moverla o quitarla según sea necesario.
            this.tPersonalTableAdapter.Fill(this.dBHotelGloriaDataSet2.TPersonal);
            // TODO: esta línea de código carga datos en la tabla 'dBHotelGloriaDataSet1.TSalario' Puede moverla o quitarla según sea necesario.
            this.tSalarioTableAdapter.Fill(this.dBHotelGloriaDataSet1.TSalario);
            // TODO: esta línea de código carga datos en la tabla 'dBHotelGloriaDataSet.TCargo' Puede moverla o quitarla según sea necesario.
            this.tCargoTableAdapter.Fill(this.dBHotelGloriaDataSet.TCargo);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
