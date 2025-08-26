using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Basic_Queuing_Cashier.CustomerView;


namespace Basic_Queuing_Cashier
{
    public partial class QueuingForm1 : Form
    {
        private CashierClass cashier;
        CashierWindowQueueForm ciqw;
        private readonly CustomerViewForm hshs;
        public QueuingForm1()
        {
            InitializeComponent();
            cashier = new CashierClass();
            ciqw = new CashierWindowQueueForm();
            hshs = new CustomerViewForm();
            ciqw.Show();
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            CustomerView customerForm = new CustomerView();
            customerForm.Show();

        }
    }
}
