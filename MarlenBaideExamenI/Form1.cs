using System.ComponentModel;

namespace MarlenBaideExamenI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicioIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio1());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void  abrirForm(Form form)
        {
            while(panelBase.Controls.Count > 0)
            {
                panelBase.Controls.RemoveAt(0);
            }

            Form formHijo = form;

            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelBase.Controls.Add(formHijo);
            formHijo.Show();

        }

        private void MenuEjercicio2_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio2());
        }

        private void MenuEjercicio3_Click(object sender, EventArgs e)
        {
            abrirForm(new Ejercicio3());
        }
    }
}