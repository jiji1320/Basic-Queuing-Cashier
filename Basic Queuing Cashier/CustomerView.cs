using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Queuing_Cashier
{
    public partial class CustomerView : Form
    {
        Timer timer = new Timer();
        public CustomerView()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        internal class CustomerViewForm 
        {
            
        }
        private void Timer_Tick(object sender, EventArgs e) 
        {
            if (CashierClass.CashierQueue.Count > 0) 
            {
                lblNowServing.Text = "Now Serving " + CashierClass.CashierQueue.Peek();
            }else 
            {
                lblNowServing.Text = "Now Serving: ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {


        }

        private void lblNowServing_Click(object sender, EventArgs e)
        {

        }
    }
}
