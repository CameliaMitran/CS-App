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
using WindowsFormsApp1;
using Oracle.ManagedDataAccess.Client;

namespace ContentShare
{
    public partial class IT_Support : Form
    {
        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        
        public IT_Support()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets();
            createTickets.TopLevel = false;
            panelDisplay.Controls.Add(createTickets);
            createTickets.BringToFront();
            createTickets.Show();
        }

        private void BtnTickets_Click(object sender, EventArgs e)
        {
            /* connection.Open();
             OracleCommand cmd = new OracleCommand("afisare_tickete", connection);
             cmd.CommandType = System.Data.CommandType.StoredProcedure;
             cmd.Parameters.Add("registru", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

             OracleDataAdapter adapter = new OracleDataAdapter();
             adapter.SelectCommand = cmd;
             DataTable dataTable = new DataTable();
             adapter.Fill(dataTable);
             dataGridViewTickets.DataSource = dataTable;

             connection.Close();*/
            IT_Support it = new IT_Support();
            it.Show();
        }
    
        private void IT_Support_Load(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand("afisare_tickete", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registru", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewTickets.DataSource = dataTable;

            connection.Close();
        }

        private void dataGridViewTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketsForm1 ticket = new TicketsForm1();
            ticket.textIDTicket.Text = this.dataGridViewTickets.CurrentRow.Cells[0].Value.ToString();
            ticket.textTicketEmpNameIT.Text = this.dataGridViewTickets.CurrentRow.Cells[1].Value.ToString();
            ticket.comboTicketDepIT.Text = this.dataGridViewTickets.CurrentRow.Cells[2].Value.ToString();
            ticket.textDescrTicketIT.Text = this.dataGridViewTickets.CurrentRow.Cells[3].Value.ToString();
            ticket.comboAsgnDeptIT.Text = this.dataGridViewTickets.CurrentRow.Cells[4].Value.ToString();
            ticket.textAsgnNameIT.Text = this.dataGridViewTickets.CurrentRow.Cells[5].Value.ToString();
            ticket.textCostIT.Text = this.dataGridViewTickets.CurrentRow.Cells[6].Value.ToString();
            ticket.textNrSesizare.Text = this.dataGridViewTickets.CurrentRow.Cells[7].Value.ToString();
            ticket.textService.Text = this.dataGridViewTickets.CurrentRow.Cells[8].Value.ToString();
            ticket.comboStateIT.Text = this.dataGridViewTickets.CurrentRow.Cells[9].Value.ToString();
            ticket.dateTicketIT.Text = this.dataGridViewTickets.CurrentRow.Cells[10].Value.ToString();
            ticket.TopLevel = false;
            panelDisplay.Controls.Add(ticket);
            ticket.BringToFront();
            ticket.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand("afisare_tickete", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registru", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewTickets.DataSource = dataTable;

            connection.Close();
        }
    }
}
