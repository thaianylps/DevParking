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

        private void btnfun_consulta_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario consultaFuncionario = new ConsultaFuncionario();
            consultaFuncionario.Show();
        }
    }
}
