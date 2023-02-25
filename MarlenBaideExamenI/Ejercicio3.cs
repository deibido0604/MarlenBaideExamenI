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
    public partial class Ejercicio3 : Form
    {
        string stdDetalle = "{0,-10}{1,-20}{2,-20}{3,-20}";

        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(String.Format(stdDetalle, "N", "Multiplo de 3", "Multiplo de 5", "Multiplo de 3 y 5"));
        }

        private void Add_Click(object sender, EventArgs e)
        {

            string m5 = null, m3 = null, m3y5 = null;

            for (int i = 1; i <= 100; i++)
            {
                

                if (i % 3 == 0)
                {
                    m3 = textBoxNombre.Text;
                    listBox1.Items.Add(String.Format(stdDetalle, i.ToString(), m3, m5, m3y5));
                }
                else
                {
                    m3 = null;
                }
                if (i % 5 == 0)
                {
                    m5 = textBoxApellido.Text;
                    listBox1.Items.Add(String.Format(stdDetalle, i.ToString(), m3, m5, m3y5));
                }
                else
                {
                    m5 = null;
                }
                if (i % 3 == 0 && i%5==0)
                {
                    m3y5 = textBoxNombre.Text + textBoxApellido.Text;
                    listBox1.Items.Add(String.Format(stdDetalle, i.ToString(), m3, m5, m3y5));
                }
                else
                {
                    m3y5= null;
                }

            }
        }
    }
}
