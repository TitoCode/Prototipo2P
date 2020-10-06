using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Ventas : Form
    {
        String tabla = "";
        Controlador cn = new Controlador();

        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabla = "clientes";
            DataTable dt = cn.llenarTbl(tabla);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabla = "vendedores";
            DataTable dt = cn.llenarTbl(tabla);
            dataGridView2.DataSource = dt;
        }
    }
}
