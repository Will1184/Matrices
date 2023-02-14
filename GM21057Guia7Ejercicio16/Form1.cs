using System.Windows.Forms;
// Guía:7
// Ejercicio: #16
// Fecha: 09/10/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GD: #1
// Instructora: ING. NELLY LISSETTE HENRIQUEZ SANCHEZ

namespace GM21057Guia7Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Matriz matrices = new Matriz();
            matrices.Matrices(labelVector1,labelVector2,dataGridMatriz);
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridMatriz.DataSource= null;
            dataGridMatriz.Rows.Clear();
            dataGridMatriz.Columns.Clear();
            labelVector1.Text = "";
            labelVector2.Text = "";

        }
    }
}