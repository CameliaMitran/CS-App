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
using Oracle.ManagedDataAccess.Client;

namespace ContentShare
{
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void labelFullname_Click(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void labelSingup_Click(object sender, EventArgs e)
        {

        }

        private void labeUserName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ///////////////////
        /// conexiunea la baza de date
        /// </summary>
        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        //incercare de incarcare nume departament in combobox, nefunctionala
        private void NewEmployee_Load (object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand dept_cmd = new OracleCommand("select nume_departament from departament", connection);
            OracleDataReader lector = dept_cmd.ExecuteReader();

            while(lector.Read())
            {
                comboDepartment.Items.Add(lector["nume_departament"].ToString());

            }
            connection.Close();
        }


        private void BtnCancelNewEmp_Click(object sender, EventArgs e)
        {
            this.Close();
            CSapp menu = new CSapp();
            menu.Show();
        }

        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OracleCommand cmd = new OracleCommand("inserare", connection);                
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //s-a creat o procedura numita "inserare", un trigger ce imi adauga id_ul corect si inlocuieste atunci cand se sterge
                cmd.Parameters.Add("nume_angajat", OracleDbType.Varchar2).Value = textFirstName.Text;
                cmd.Parameters.Add("prenume_angajat", OracleDbType.Varchar2).Value = textLastName.Text;
                cmd.Parameters.Add("CNP", OracleDbType.Int32).Value = textCNP.Text;
                cmd.Parameters.Add("adresa", OracleDbType.Varchar2).Value = textAddress.Text;
                cmd.Parameters.Add("telefon", OracleDbType.Int32).Value = textPhone.Text;
                cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = textEmail.Text;
                cmd.Parameters.Add("functie", OracleDbType.Varchar2).Value = textJob.Text;
                cmd.Parameters.Add("data_angajare", OracleDbType.Date).Value = dateHiring.Value.Date;
                //cred ca trebuie inlocuit ceva la departament
                cmd.Parameters.Add("departament", OracleDbType.Varchar2).Value = comboDepartment.GetItemText(comboDepartment.SelectedItem);

                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = textUserName.Text;
                cmd.Parameters.Add("parola", OracleDbType.Varchar2).Value = textPassword.Text;
                cmd.Parameters.Add("salariu", OracleDbType.Int32).Value = textSalary.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("The employee was added");
            }   
            catch(Exception ex)
            {
                MessageBox.Show("Error: "+ ex);

            }
            
            connection.Close();
        }
    }
}
