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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexaoCliente = @"server=localhost;Database=estacionamento;Uid=root;Pwd='94609398lpS@' ";
            MySqlConnection Clienteconnection = new MySqlConnection();
            Clienteconnection.ConnectionString = conexaoCliente;
            Clienteconnection.Open();
            MySqlCommand clientecommand = new MySqlCommand();
            clientecommand.CommandText = "select*from cliente";
            clientecommand.Connection = Clienteconnection;
            MySqlDataAdapter clienteAdapter = new MySqlDataAdapter(clientecommand);
            clienteAdapter.Fill(dt);

            dgvCliente.DataSource = dt;


        }
    }
}
