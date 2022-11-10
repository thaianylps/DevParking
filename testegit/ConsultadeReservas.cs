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
    public partial class ConsultadeReservas : Form
    {
        public ConsultadeReservas()
        {
            InitializeComponent();
        }

        private void ConsultadeReservas_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexaoReserva = @"server=localhost;Database=estacionamento;Uid=root;Pwd='94609398lpS@' ";
            MySqlConnection Reservaconnection = new MySqlConnection();
            Reservaconnection.ConnectionString = conexaoReserva;
            Reservaconnection.Open();
            MySqlCommand Reservacommand = new MySqlCommand();
            Reservacommand.CommandText = "select*from reserva";
            Reservacommand.Connection = Reservaconnection;
            MySqlDataAdapter ReservaAdapter = new MySqlDataAdapter(Reservacommand);
            ReservaAdapter.Fill(dt);

            dgv_reserva.DataSource = dt;
        }
    }
}
