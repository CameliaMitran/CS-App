using ContentShare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.DataAccess;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
//using Oracle.DataAccess.Client;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        //conectarea la baza de date, loginul facut in functie de departamentul la care lucreaza un angajat
        /*https://www.youtube.com/watch?v=QrsZ4DPCgpg
         * https://www.c-sharpcorner.com/article/login-form-in-c-sharp-connected-with-database-for/
         * https://www.youtube.com/watch?v=N9uX-0CnLu4
         */
         //conectarea la baza de date
        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand( "select username, parola, departament from angajat where username = :username and parola = :parola", connection);
            cmd.Parameters.Add(":username", userName.Text);
            cmd.Parameters.Add(":parola", Password.Text);
            OracleDataReader lector = cmd.ExecuteReader();
            
            if(lector.Read())
            {   //login pe roluri/departamente - aceeasi interfata pentru toti angajatii de pe un departament

                if(lector["departament"].ToString() == "HR")
                {
                    this.Hide();
                    CSapp C = new CSapp();
                    C.Show();
                    
                }
                if (lector["departament"].ToString() == "IT_Support")
                {
                    this.Hide();
                    IT_Support it = new IT_Support(); 
                    it.Show();

                }
                if (lector["departament"].ToString() == "Others")
                {
                    this.Hide();
                    Other_Department other = new Other_Department();
                    other.Show();

                }

               // userName.Clear();
               // Password.Clear();

            }
            
            else
            {
                MessageBox.Show("Error: Username/password incorrect!!! Please try again.");
                userName.Clear();
                Password.Clear();
            }
            connection.Close();
            lector.Close();
            
        } //close button login

        private void linkSingup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NewEmployee signUp = new NewEmployee();
            signUp.Show();
                
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
