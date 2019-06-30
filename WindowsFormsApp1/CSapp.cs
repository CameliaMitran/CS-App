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
using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{    
    public partial class CSapp : Form
    {       
        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        public CSapp()
        {
            InitializeComponent();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            connection.Open();
            //afisare tichete it create de departamentul hr in functie de stare, folosind proceduri
            OracleCommand cmd = new OracleCommand("HR_afisare_tickete", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("reg", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewTickets.DataSource = dataTable;
        
            connection.Close();

            CSapp hr = new CSapp();
            hr.Show();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEvent ev = new CreateEvent();
            ev.TopLevel = false;
            panelDisplay.Controls.Add(ev);
            ev.BringToFront();
            ev.Show();  
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand("afisare_angajati", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("registru", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
          
            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = cmd;
            DataTable dataTbl = new DataTable();
            adapt.Fill(dataTbl);
            dataGridViewTickets.DataSource = dataTbl;

            connection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets();
            createTickets.TopLevel = false;
            panelDisplay.Controls.Add(createTickets);
            createTickets.BringToFront();
            createTickets.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnNewEmp_Click(object sender, EventArgs e)
        {
            NewEmployee new_employee = new NewEmployee();
            new_employee.TopLevel = false;
            panelDisplay.Controls.Add(new_employee);
            new_employee.BringToFront();
            new_employee.Show();

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void CSapp_Load(object sender, EventArgs e)
        {
            connection.Open();
            //afisare tichete it create de departamentul hr in functie de stare, folosind proceduri
            OracleCommand cmd = new OracleCommand("HR_afisare_tickete", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("reg", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewTickets.DataSource = dataTable;

            string data = "";
            OracleCommand cmd1 = new OracleCommand("select data_eveniment from eveniment", connection);
            OracleDataReader read = cmd1.ExecuteReader();
            if (read.HasRows == true)
            {
                while (read.Read())
                {
                    data = read.GetValue(read.GetOrdinal("data_eveniment")).ToString();
                    Calendar.AddBoldedDate(Convert.ToDateTime(data));
                }
            }
            read.Close();
            Calendar.UpdateBoldedDates();

            connection.Close();
        }

        private void dataGridViewTickets_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //la dublu click pe o inregistrare se afiseaza ticketul repsectiv
            TicketsForm1 ticket = new TicketsForm1();
            ticket.textIDTicket.Text = this.dataGridViewTickets.CurrentRow.Cells[0].Value.ToString();
            ticket.textTicketEmpNameIT.Text = this.dataGridViewTickets.CurrentRow.Cells[1].Value.ToString();
            ticket.textTicketDepIT.Text = this.dataGridViewTickets.CurrentRow.Cells[2].Value.ToString();
            ticket.textDescrTicketIT.Text = this.dataGridViewTickets.CurrentRow.Cells[3].Value.ToString();
            ticket.textAsgnNameIT.Text = this.dataGridViewTickets.CurrentRow.Cells[5].Value.ToString();
            ticket.textAsgnDeptIT.Text = this.dataGridViewTickets.CurrentRow.Cells[4].Value.ToString();
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

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridViewEvents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*Event ev = new Event();
            ev.textNumeEv.Text = this.GridViewEvents.CurrentRow.Cells[1].Value.ToString();*/
        }

        private void panelDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridViewEmployees_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void BtnEvent_Click(object sender, EventArgs e)
        {
            connection.Open();
            string data = "";
            OracleCommand cmd = new OracleCommand("select data_eveniment from eveniment", connection);
            OracleDataReader read = cmd.ExecuteReader();
            if (read.HasRows == true)

            {
                while (read.Read())
                {
                    data = read.GetValue(read.GetOrdinal("data_eveniment")).ToString();

                    Calendar.AddBoldedDate(Convert.ToDateTime(data));
                }
            }
            read.Close();
            Calendar.UpdateBoldedDates();
            connection.Close();
        
        }

       /* private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {//eroare, terbuie verificat
            Event ev = new Event();
            connection.Open();
            
            OracleCommand cmd = new OracleCommand("select nume_eveniment, locatie, descriere, data_eveniment from eveniment, ticket where eveniment.id_ticket = ticket.id_ticket ", connection);
            OracleDataReader rd = cmd.ExecuteReader(); 
            //display the selected date from monthcalendar to a textbox from other form
            ev.textDate.Text = this.Calendar.SelectionRange.Start.ToShortDateString();
            while(rd.Read())
            {//trebuie rectificat
                if(rd.)
                    ev.textNumeEv.Text = rd["nume_eveniment"].ToString();
                    ev.textDescr.Text = rd["descriere"].ToString();
                    ev.textAddressEv.Text = rd["locatie"].ToString();

            }
            ev.Show();
           
            connection.Close();
        } */

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Event ev = new Event();
            connection.Open();

            OracleCommand cmd = new OracleCommand("select nume_eveniment, locatie, descriere, data_eveniment from eveniment, ticket where eveniment.id_ticket = ticket.id_ticket ", connection);
            OracleDataReader rd = cmd.ExecuteReader();
            ev.textDate.Text = this.Calendar.SelectionRange.Start.ToShortDateString();
            while (rd.Read())
            {
                    ev.textNumeEv.Text = rd["nume_eveniment"].ToString();
                    ev.textDescr.Text = rd["descriere"].ToString();
                    ev.textAddressEv.Text = rd["locatie"].ToString();              

            }
            ev.Show();

            connection.Close();
        }
        /* while(rd.Read())
   {//trebuie rectificat, fara if arata ultimul eveniment indiferent de data
       if(rd["data_eveniment"].ToString() == this.Calendar.ToString())
       {
           ev.textNumeEv.Text = rd["nume_eveniment"].ToString();
ev.textDescr.Text = rd["descriere"].ToString();
ev.textAddressEv.Text = rd["locatie"].ToString();*/
    }

    //ev.textDate.Text = rd["data_eveniment"].ToString();
}
    

