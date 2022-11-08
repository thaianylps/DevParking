using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testegit
{
    public partial class ConsultaFuncionario : Form
    {
        public ConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexaoFuncionario = @"server=localhost;Database=estacionamento;Uid=root;Pwd='94609398lpS@' ";
            MySqlConnection Funcionarioconnection= new MySqlConnection();
            Funcionarioconnection.ConnectionString = conexaoFuncionario;
            Funcionarioconnection.Open();
            MySqlCommand Funcionariocommand = new MySqlCommand();
            Funcionariocommand.CommandText = "select*from funcionario";
            Funcionariocommand.Connection = Funcionarioconnection;
            MySqlDataAdapter FuncionarioAdapter = new MySqlDataAdapter(Funcionariocommand);
            FuncionarioAdapter.Fill(dt);

            dgvFuncionario.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
