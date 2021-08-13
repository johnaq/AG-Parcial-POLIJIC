using AG_Parcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new();

        public Form1()
        {
            InitializeComponent();

            txtObjetivo.Text = "Politécnico Colombiano Jaime Isaza Cadavid";
            txtIndividuos.Text = "100";
            txtMutacion.Text = "0.02";

            dataGridView1.AutoResizeColumns();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var objetivo = txtObjetivo.Text;
            int numero_ind = int.Parse(txtIndividuos.Text);
            double tasa_mutacion = double.Parse(txtMutacion.Text);

            Poblacion poblacion = new Poblacion(tasa_mutacion, numero_ind, objetivo);

            var dataList = new BindingList<Data>();
            dataGridView1.DataSource = dataList;

            while (true)
            {
                Data data = new();

                data.Generacion = poblacion.generacion;
                data.Mejor_Individuo = poblacion.Mejor_individuo();
                data.Fitness = poblacion.poblacion.Max(x => x.fitness);

                dataList.Add(data);
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                poblacion.Seleccion();
                poblacion.Cruce();
                if (poblacion.Mejor_individuo() == objetivo)
                    break;
                poblacion.Calcular_funcion_fitness();
            }
            dataGridView1.AutoResizeColumns();
        }
    }
}
