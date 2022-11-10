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
    public partial class TelaAdm : Form
    {
        public TelaAdm()
        {
            InitializeComponent();
        }

       
        private void TelaAdm_Load(object sender, EventArgs e)
        {

        }

        private void conultaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.Show();

        }

        private void consultaReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeReservas consultadeReservas = new ConsultadeReservas();
            consultadeReservas.Show ();
        }

        private void cadastroDeFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }

        private void consultaFuncionárioToolStripMenuItem_Click(object sender, EventArgs e) { 
        
            ConsultaFuncionario consultaFuncionario = new ConsultaFuncionario();
            consultaFuncionario.Show();
        }

        private void planoDeReservaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PlanoDeReserva planoDeReserva  = new PlanoDeReserva();
            planoDeReserva.Show();
        }
    }
}
