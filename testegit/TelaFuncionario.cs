using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testegit
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void TelaFuncionario_Load(object sender, EventArgs e)
        {
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultadeReservas consultadeReservas = new ConsultadeReservas();
            consultadeReservas.Show();

        }

        private void btn_cdcliente_Click(object sender, EventArgs e)
        {
            CadastroReserva cadastroReserva = new CadastroReserva();
            cadastroReserva.Show();

        }
    }
}
