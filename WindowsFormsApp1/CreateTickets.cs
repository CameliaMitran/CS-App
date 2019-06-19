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
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace ContentShare
{
    public partial class CreateTickets : Form

    {

        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        public CreateTickets() => InitializeComponent();

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                //inserare date, creare ticket nou
                connection.Open();
                OracleCommand cmd = new OracleCommand(
                     "insert all into ticket(id_ticket, angajat_creator, departament, descriere, departament_adresat, angajat_adresat, cost_aprox)" +
                     " values (:id_ticket, :angajat_creator, :departament, :descriere, :departament_adresat, :angajat_adresat, :cost_aprox) " +
                     " into suport_it(id_ticket, numar_sesizare, serviciu, stare, data_creare) values (:id_ticket, :numar_sesizare, :serviciu, :stare, :data_creare)" +
                     " select :id_ticket, :angajat_creator, :departament, :descriere, :departament_adresat, :angajat_adresat, :cost_aprox, :numar_sesizare, :serviciu, :stare, :data_creare  from dual ", connection);
                 cmd.Parameters.Add(":id_ticket", textIDTicket.Text );
                 cmd.Parameters.Add(":angajat_creator", textTicketEmpNameIT.Text );
                 cmd.Parameters.Add(":departament", comboTicketDepIT.GetItemText(comboTicketDepIT.SelectedItem));
                 cmd.Parameters.Add(":descriere", textDescrTicketIT.Text );
                 cmd.Parameters.Add(":departament_adresat", comboAsgnDeptIT.GetItemText(comboAsgnDeptIT.SelectedItem) );
                 cmd.Parameters.Add(":angajat_adresat", textAsgnNameIT.Text );
                 cmd.Parameters.Add(":cost_aprox", textCostIT.Text );
                 cmd.Parameters.Add(":numar_sesizare", textNrSesizare.Text );
                 cmd.Parameters.Add(":serviciu", textService.Text);
                 cmd.Parameters.Add(":stare", comboStateIT.GetItemText(comboStateIT.SelectedItem));
                 cmd.Parameters.Add(":data_creare", dateTicketIT.Value.Date);
                cmd.BindByName = true;
                 cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("The ticket was created");
                this.Hide();
            }
            catch(Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally {
                connection.Close();
                
            }
           
        }

        private void CreateTickets_Load(object sender, EventArgs e)
        {
            //incarcare date din baza de date in combobox
            connection.Open();
            OracleCommand cmd = new OracleCommand("select nume_departament from departament ", connection);
            OracleDataReader registru = cmd.ExecuteReader();            
            while (registru.Read())
            {
                comboTicketDepIT.Items.Add(registru["nume_departament"].ToString());
                comboAsgnDeptIT.Items.Add(registru["nume_departament"].ToString());
            }

            OracleCommand cmd1 = new OracleCommand("select stare from state ", connection);
            OracleDataReader registru1 = cmd1.ExecuteReader();
            while(registru1.Read())
            {
                comboStateIT.Items.Add(registru1["stare"].ToString());
            }
            connection.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textAsgnNameIT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*  connection.Open();
                 OracleCommand cmd = new OracleCommand(" insert all into ContentShareDB.ticket ( id_ticket, angajat_creator, departament, angajat_adresat, departament_adresat, cost_aprox, descriere, comentarii ) " +
                     " values ( @id_ticket, @angajat_creator, @departament, @angajat_adresat,  @departament_adresat, @cost_aprox, @descriere, @comentarii ) " +
                     " into ContentShareDB.suport_it ( id_ticket, numar_sesizare, serviciu, stare, data_creare ) values ( @id_ticket, @numar_sesizare, @serviciu, @stare, @data_creare ) select * from dual ", connection);
                 cmd.Parameters.Add("@id_ticket", textIDTicket.Text);
                 cmd.Parameters.Add("@angajat_creator", textTicketEmpNameIT.Text);
                 cmd.Parameters.Add("@departament", comboTicketDepIT.GetItemText(comboTicketDepIT.SelectedItem));
                 cmd.Parameters.Add("@angajat_adresat", textAsgnNameIT.Text);
                 cmd.Parameters.Add("@departament_adresat", comboAsgnDeptIT.GetItemText(comboAsgnDeptIT.SelectedItem));
                 cmd.Parameters.Add("@cost_aprox", textCostIT.Text);
                 cmd.Parameters.Add("@descriere", textDescrTicketIT.Text);
                 cmd.Parameters.Add("@comentarii", richComTicketIT.Text);

                 // OracleCommand cmd1 = new OracleCommand("insert into ContentShareDB.support_it('id_ticket', 'numar_sesizare', 'serviciu', 'stare', 'data_creare') values (@id_ticket, @numar_sesizare, @serviciu, @stare, @data_creare)", connection);
                 //cmd1.Parameters.Add("@id_ticket", textIDTicket.Text);
                 cmd.Parameters.Add("@numar_sesizare", textNrSesizare.Text);
                 cmd.Parameters.Add("@serviciu", textService.Text);
                 cmd.Parameters.Add("@stare", comboStateIT.GetItemText(comboStateIT.SelectedItem));
                 cmd.Parameters.Add("@data_creare", dateTicketIT.Value.Date);

                 cmd.ExecuteNonQuery();
                 //cmd1.ExecuteNonQuery();
                 connection.Close(); */
