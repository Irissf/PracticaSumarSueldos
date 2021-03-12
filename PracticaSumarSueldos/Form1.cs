using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaSumarSueldos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Combobox->llenamos el combobox
            this.cbxCondicion.Items.Add("Contratado");
            this.cbxCondicion.Items.Add("Permanente");
            this.cbxCondicion.Items.Add("Eventual");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double total = 0;
            string nombre = this.txtcolaborador.Text;
            double sueldoBásico = Convert.ToDouble(this.txtSueldo.Text);
            double descuento;
            double sueldoNeto;

            if (RbtAfp.Checked)
            {
                descuento = 0.11 * sueldoBásico;
            }
            else
            {
                descuento = 0.13 * sueldoBásico;
            }
            sueldoNeto = sueldoBásico - descuento;
            descuento = lsbDescuento.Items.Add(descuento);
            sueldoNeto = lsbSueldoNeto.Items.Add(sueldoNeto);

            lsbColaboradores.Items.Add(nombre);
            lsbBasico.Items.Add(sueldoBásico);
            lsbCondicion.Items.Add(cbxCondicion.SelectedItem);
            foreach(Object item in lsbSueldoNeto.Items)
            {
                //suma el total de los elementos del listbox y lo pone en el textbox de abajo
                total += Convert.ToDouble(item);
                txtPlanilla.Text = (total).ToString();
            }
            limpiar();
        }

        private void limpiar()
        {
            txtcolaborador.Clear();
            txtSueldo.Clear();
            cbxCondicion.SelectedIndex = -1;//lo deja limpio visualemte
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int i = this.lsbColaboradores.SelectedIndex;
            if (i >= 0)
            {
                lsbSueldoNeto.Items.RemoveAt(i);
                lsbDescuento.Items.RemoveAt(i);
                lsbBasico.Items.RemoveAt(i);
                lsbCondicion.Items.RemoveAt(i);
                lsbColaboradores.Items.RemoveAt(i);
            }

            double total = 0;
            foreach (Object item in lsbSueldoNeto.Items)
            {
                //suma el total de los elementos del listbox y lo pone en el textbox de abajo
                total += Convert.ToDouble(item);
                txtPlanilla.Text = (total).ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
