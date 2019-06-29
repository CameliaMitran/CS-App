using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContentShare;
using Oracle.ManagedDataAccess.Client;
using WindowsFormsApp1;


namespace ContentShare
{
    public partial class TicketsForm1 : Form
    {
        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        //IT_Support it = new IT_Support();
        public TicketsForm1()
        {
            InitializeComponent();
        }

        private void TicketsForm1_Load(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd1 = new OracleCommand("select stare from state ", connection);
            OracleDataReader registru1 = cmd1.ExecuteReader();
            while (registru1.Read())
            {
                comboStateIT.Items.Add(registru1["stare"].ToString());
            }
            connection.Close();

            /*
            connection.Open();
            OracleCommand cmd = new OracleCommand("select ticket.id_ticket, angajat_creator, departament, descriere, departament_adresat, angajat_adresat, cost_aprox, numar_sesizare, serviciu, stare, data_creare from ticket, suport_it where ticket.id_ticket = suport_it.id_ticket", connection);
            //cmd.Parameters.Add(":numar_sesizare", textNrSesizare.Text);
            cmd.BindByName = true;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textIDTicket.Text = reader.GetValue(0).ToString();
                textTicketEmpNameIT.Text = reader.GetValue(1).ToString();
                comboTicketDepIT.SelectedItem = reader.GetValue(2).ToString();
                textDescrTicketIT.Text = reader.GetValue(3).ToString();
                comboAsgnDeptIT.SelectedItem = reader.GetValue(4).ToString();
                textAsgnNameIT.Text = reader.GetValue(5).ToString();
                textCostIT.Text = reader.GetValue(6).ToString();
                textNrSesizare.Text = reader.GetValue(7).ToString();
                textService.Text = reader.GetValue(8).ToString();
                comboStateIT.SelectedItem = reader.GetValue(9).ToString();
                dateTicketIT.Value = Convert.ToDateTime(reader["data_creare"]);

            }

            connection.Close();
           
            connection.Open();
            OracleCommand cmd = new OracleCommand("afisare_tickete", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registru", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewTickets.DataSource = dataTable; */

            // connection.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand("actualizare_suport_it", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("id_ticket", OracleDbType.Int32).Value = textIDTicket.Text;
            cmd.Parameters.Add("stare", OracleDbType.Varchar2).Value = comboStateIT.GetItemText(comboStateIT.SelectedItem);
            cmd.ExecuteNonQuery();
            OracleCommand cmd1 = new OracleCommand("actualizare_ticket", connection);
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.Parameters.Add("id_ticket", OracleDbType.Int32).Value = textIDTicket.Text;
            cmd1.Parameters.Add("cost_aprox", OracleDbType.Int32).Value = textCostIT.Text;
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The ticket was successfully updated :)");
            connection.Close();
            this.Hide();
        }
/*
        private void BtnCharge_Click(object sender, EventArgs e)
        {
           /* connection.Open();
            OracleCommand cmd = new OracleCommand("select ticket.id_ticket, angajat_creator, departament, descriere, departament_adresat, angajat_adresat, cost_aprox, numar_sesizare, serviciu, stare, data_creare from ticket, suport_it where ticket.id_ticket = suport_it.id_ticket and numar_sesizare = :numar_sesizare", connection);
            //cmd.Parameters.Add(":numar_sesizare", textNrSesizare.Text);
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
                textIDTicket.Text = reader.GetValue(0).ToString();
                textTicketEmpNameIT.Text = reader.GetValue(1).ToString();
                comboTicketDepIT.SelectedItem = reader.GetValue(2).ToString();
                textDescrTicketIT.Text = reader.GetValue(3).ToString();
                comboAsgnDeptIT.DisplayMember = reader.GetValue(4).ToString();
                textAsgnNameIT.Text = reader.GetValue(5).ToString();
                textCostIT.Text = reader.GetValue(6).ToString();
                textNrSesizare.Text = reader.GetValue(7).ToString();
                textService.Text = reader.GetValue(8).ToString();
                comboStateIT.SelectedItem = reader.GetValue(9).ToString();
                dateTicketIT.Value = Convert.ToDateTime(reader["data_creare"]) ;
          
            }

            connection.Close(); *
        }
*/
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }
        public void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BtnRedirect_Click(object sender, EventArgs e)
        {

        }
    }
}
