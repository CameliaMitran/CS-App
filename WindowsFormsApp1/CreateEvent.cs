using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace ContentShare
{
    public partial class CreateEvent : Form
    {
        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand("select nume_departament from departament ", connection);
            OracleDataReader registru = cmd.ExecuteReader();
            while (registru.Read())
            {
                listAsgnDepartments.Items.Add(registru["nume_departament"].ToString());
            }
           /* OracleCommand cmd1 = new OracleCommand("select (nume_angajat||' '|| prenume_angajat) as angajat from angajat ", connection);
            OracleDataReader registru1 = cmd1.ExecuteReader();
            while (registru1.Read())
            {
                listAsgnEmp.Items.Add(registru1["angajat"].ToString());
            }*/

            connection.Close();
        }

        private void BtnCreateEvent_Click(object sender, EventArgs e)
        {
            string departamente = "";
            string angajat_a = "";
            foreach (string dept in listAsgnDepartments.SelectedItems)
            {
                departamente += dept.ToString() + ", ";
            }
            foreach ( string ang in listAsgnEmp.SelectedItems)
            {
                angajat_a +=ang.ToString() + ", ";
            }
            
            connection.Open();
           
            OracleCommand cmd = new OracleCommand("insert all into ticket(id_ticket, angajat_creator, departament, descriere, departament_adresat, angajat_adresat, cost_aprox)" +
                     " values (:id_ticket, :angajat_creator, :departament, :descriere, :departamente, :angajat_a, :cost_aprox) " +
                     "into eveniment(id_ticket, numar_eveniment, nume_eveniment, data_eveniment, locatie) values (:id_ticket, :numar_eveniment, :nume_eveniment, :data_eveniment, :locatie)" +
                     "select :id_ticket, :angajat_creator, :departament, :descriere, :departamente, :angajat_a, :cost_aprox, :numar_eveniment, :nume_eveniment, :data_eveniment, :locatie from dual ", connection);

            cmd.Parameters.Add(":id_ticket", textID.Text);
            cmd.Parameters.Add(":angajat_creator", textEmpName.Text);
            cmd.Parameters.Add(":departament", textDepartment.Text);
            cmd.Parameters.Add(":descriere", textDescr.Text);
            cmd.Parameters.Add(":departamente", listAsgnDepartments.GetItemText(listAsgnDepartments.SelectedItem));
            cmd.Parameters.Add(":angajat_a", listAsgnEmp.GetItemText(listAsgnEmp.SelectedItem));
            cmd.Parameters.Add(":cost_aprox", textCost.Text);
            cmd.Parameters.Add(":numar_eveniment", textEvNo.Text);
            cmd.Parameters.Add(":nume_eveniment", textNumeEv.Text);
            cmd.Parameters.Add(":data_eveniment", dateEvent.Value.Date);
            cmd.Parameters.Add(":locatie", textAddressEv.Text);
            cmd.BindByName = true;    
            cmd.ExecuteNonQuery();
            connection.Close();
            this.Hide();
        }

        private void listAsgnEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listAsgnDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //adauga angajati in listbox in functie de departamentul ales in listboxul pt dept
                connection.Open();
                string dept = listAsgnDepartments.SelectedItem.ToString();
                OracleCommand cmd1 = new OracleCommand("select (nume_angajat||' '|| prenume_angajat) as angajat from angajat where departament = '" + dept + "' ", connection);
                OracleDataReader registru1 = cmd1.ExecuteReader();
                while (registru1.Read())
                {
                    if (!listAsgnEmp.Items.Contains(registru1["angajat"]))
                    {
                        listAsgnEmp.Items.Add(registru1["angajat"].ToString());
                    }

                }                              
                cmd1.BindByName = true;
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " +ex);
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
