using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using Oracle.DataAccess.Client;


namespace ContentShare
{
    public partial class Other_Department : Form
    {
        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        public Other_Department()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Other_Department other = new Other_Department();
            other.Show();
        }

        private void Other_Department_Load(object sender, EventArgs e)
        {
            connection.Open();
            //afisare tichete it create de departamentul others in functie de stare, folosind proceduri
            OracleCommand cmd = new OracleCommand("Other_afisare_tickete", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("reg", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewTickets.DataSource = dataTable;

            connection.Close();
        }

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTickets_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            //afisarea pe acelasi display, in loc de gridview imi apare ticketul pe care l-am selectat
            ticket.TopLevel = false;
            panelDisplay.Controls.Add(ticket);
            ticket.BringToFront();
            ticket.Show();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets();
            createTickets.TopLevel = false;
            panelDisplay.Controls.Add(createTickets);
            createTickets.BringToFront();
            createTickets.Show();
        }
    }
}
