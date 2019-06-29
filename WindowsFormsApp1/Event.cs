using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentShare
{
   
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        public partial class FormState
        {
            public static Form PreviousPage;
        }

        private void Event_Load(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void dateEvent_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
           // FormState.PreviousPage.Show();
            this.Hide();
            //FormState.PreviousPage = this;
        }
    }
}
