using CompraIngressos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraIngressos.View
{
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }
        Ingressos ingresso = new Ingressos();

        private void Calcular_Click(object sender, EventArgs e)
        {
            int Quanti = Convert.ToInt32(Quantidade.Text);
            int Valo = Convert.ToInt32(Valor.Text);
            string resul = ingresso.Calculo(Quanti,Valo).ToString();
            tx_resultado.Text = resul;
        }
    }
}
