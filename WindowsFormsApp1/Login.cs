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
         */

        OracleConnection connection = new OracleConnection("DATA SOURCE=DESKTOP-Q1DI1IT:1521/XE;PERSIST SECURITY INFO=True; PASSWORD = cami; USER ID=CAMI");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand( "select username, parola, departament from angajat where username = :username and parola = :parola", connection);
            cmd.Parameters.Add(":username", userName.Text);
            cmd.Parameters.Add(":parola", Password.Text);
            OracleDataReader lector = cmd.ExecuteReader();
            /*
            if (dt.Rows.Count > 0)
            {
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["departament"].ToString() == "1")
                    {
                        this.Hide();
                        CSapp C = new CSapp();
                        C.ShowDialog();
                    }
                } *

            }*/
            if(lector.Read())
            {
                this.Hide();
                CSapp C = new CSapp();
                C.Show();
                connection.Close();
            }
            else
            {
                MessageBox.Show("error");
            }
            lector.Close();


          /*  if(( userName.Text=="admin") &&(Password.Text=="admin"))
                {
                this.Hide();
                CSapp C= new CSapp();
                C.ShowDialog();
            
            }*/
        }

        private void linkSingup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
                
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
