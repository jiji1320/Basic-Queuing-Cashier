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


namespace Basic_Queuing_Cashier
{
    public partial class QueuingForm1 : Form
    {
        private CashierClass cashier;
        CashierWindowQueueForm ciqw;
        public QueuingForm1()
        {
            InitializeComponent();
            cashier = new CashierClass();
            ciqw = new CashierWindowQueueForm();
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
        }
    }
}
