using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        
        private Timer timer1;
        
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            InitializeTimer();
            DisplayCashierQueue(CashierClass.CashierQueue);

        }
        private void InitializeTimer() 
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        } 

        private void timer1_Tick(object sender, EventArgs e) 
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
              public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }     
       
        private void listCashier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string dequeueNumber = CashierClass.CashierQueue.Dequeue();
                MessageBox.Show($"Serving Customer: {dequeueNumber}");
                DisplayCashierQueue(CashierClass.CashierQueue);
                

            }
            else 
            {
                MessageBox.Show("The queue is currently empty.");
            }
        }



        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }
    }
}   
