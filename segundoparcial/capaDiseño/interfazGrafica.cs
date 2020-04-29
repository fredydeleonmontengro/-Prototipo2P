using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDiseño.Mantenimientos;
using capaDiseño.consultas;

namespace capaDiseño
{
    public partial class interfazGrafica : UserControl
    {
        public interfazGrafica()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = false;
            button8.Visible = false;
            button9.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           agregarbodega form = new agregarbodega();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mostrarproductos form = new mostrarproductos();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button13.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            agregarcliente form = new agregarcliente();
            form.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            agregarMarca form = new agregarMarca();
            form.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            agregarproveedor form = new agregarproveedor();
            form.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            agregarvendedor form = new agregarvendedor();
            form.ShowDialog();
        }
    }
}
