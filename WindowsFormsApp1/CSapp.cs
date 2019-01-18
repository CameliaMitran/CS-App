﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContentShare;

namespace WindowsFormsApp1
{
    public partial class CSapp : Form
    {
        public CSapp()
        {
            InitializeComponent();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            
            TicketsForm1 ticketsForm1 = new TicketsForm1();
            ticketsForm1.TopLevel = false;
            panelDesplay.Controls.Add(ticketsForm1);
            ticketsForm1.BringToFront();
            ticketsForm1.Show();


        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
           
            Upload upload = new Upload();
            upload.TopLevel = false;
            panelDesplay.Controls.Add(upload);
            upload.BringToFront();

            upload.Show();
            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
           
            Contact contact = new Contact();
            contact.TopLevel = false;
            panelDesplay.Controls.Add(contact);
            contact.BringToFront();
            contact.Show();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateTickets createTickets = new CreateTickets();
            createTickets.TopLevel = false;
            panelDesplay.Controls.Add(createTickets);
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
    }
}