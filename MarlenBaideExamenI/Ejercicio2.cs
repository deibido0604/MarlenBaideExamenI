using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarlenBaideExamenI
{
    public partial class Ejercicio2 : Form
    {
        string stdDetalle = "{0,-10}{1,-20}";
        double total = 0, p = 0;

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(String.Format(stdDetalle, "Producto", "Precio"));
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string producto, precio;
            

            producto = textBoxProducto.Text;
            precio = textBoxPrecio.Text;

            p = Convert.ToDouble(precio);

            total += p;
            
            listBox1.Items.Add(String.Format(stdDetalle, producto, precio));
            textBoxTotal.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
