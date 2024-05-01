using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshop
{
    public partial class fFind : Form
    {
        public string[] filters = ["", "", ""];
        public fFind()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = tbItem.Text.ToString();
            string cust = tbCust.Text.ToString();
            string date = tbDate.Text.ToString();
            filters = [item, cust, date];
            Close();
        }
    }
}
