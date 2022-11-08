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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click_1(object sender, EventArgs e)
        {
            if (textusuario.Text == "" && txtsenha.Text == "")
            {
                MessageBox.Show("Campos vazios");
            }
            else if (textusuario.Text == "funcionario" && txtsenha.Text == "1212")
            {
                TelaFuncionario telaFuncionario = new TelaFuncionario();
                telaFuncionario.Show();
             }
            else if (textusuario.Text == "ADM" && txtsenha.Text == "2525")
            {
                TelaAdm telaAdm = new TelaAdm();
                telaAdm.Show();
            }
            else
            {
                MessageBox.Show("Dados incorretos");
            }
        }


    }
}

