using MongoDB.Driver;

namespace cshop
{
    public partial class fMain : Form
    {
        int iter = 1;
        private void updateGrid()
        {
            var orders = Program.orderCollection.Find(_ => true).ToList();

            dGrid.DataSource = orders;
        }
        public fMain()
        {
            InitializeComponent();

            updateGrid();
            dGrid.Columns["Id"].Visible = false;
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addOrderForm = new fAdd();
            addOrderForm.ShowDialog();

            updateGrid();
        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dGrid.CurrentRow.Selected = true;

            string item = dGrid.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
            string cust = dGrid.Rows[e.RowIndex].Cells["Customer"].Value.ToString();
            string date = dGrid.Rows[e.RowIndex].Cells["Date"].Value.ToString();

            string message, caption;

            switch (iter)
            {
                case 0:
                    message = "Are you sure you want to delete this order?";
                    caption = "";
                    if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Program.orderCollection.DeleteOne(o => o.ItemName == item && o.Customer == cust && o.Date == date);

                        updateGrid();
                    }
                    break;
                case 1:
                    Order newOrder = new Order(item, cust, date);

                    message = "Are you sure you want to change this order?";
                    caption = "";
                    if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var changeOrderForm = new fChange(newOrder);
                        changeOrderForm.ShowDialog();

                        updateGrid();
                    }
                    break;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iter = 0;
            toolStripTextBox2.Text = "Delete";
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iter = 1;
            toolStripTextBox2.Text = "Update";
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manualForm = new fManual();
            manualForm.ShowDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var findForm = new fFind();
            findForm.ShowDialog();

            findAndSet(findForm.filters);
        }
        public void findAndSet(string[] array)
        {
            if (array[0] != "" && array[1] != "" && array[2] != "")//1 2 3
            {
                var orders = Program.orderCollection.Find(o => o.ItemName == array[0] && o.Customer == array[1] && o.Date == array[2]).ToList();
                dGrid.DataSource = orders;
            } else if (array[0] != "" && array[1] != "" && array[2] == "")//1 2
            {
                var orders = Program.orderCollection.Find(o => o.ItemName == array[0] && o.Customer == array[1]).ToList();
                dGrid.DataSource = orders;
            } else if (array[0] != "" && array[1] == "" && array[2] == "")//1
            {
                var orders = Program.orderCollection.Find(o => o.ItemName == array[0]).ToList();
                dGrid.DataSource = orders;
            } else if (array[0] == "" && array[1] != "" && array[2] == "")//2
            {
                var orders = Program.orderCollection.Find(o => o.Customer == array[1]).ToList();
                dGrid.DataSource = orders;
            } else if (array[0] == "" && array[1] == "" && array[2] != "")//3
            {
                var orders = Program.orderCollection.Find(o => o.Date == array[2]).ToList();
                dGrid.DataSource = orders;
            } else if (array[0] == "" && array[1] != "" && array[2] != "")//2 3
            {
                var orders = Program.orderCollection.Find(o => o.Customer == array[1] && o.Date == array[2]).ToList();
                dGrid.DataSource = orders;
            } else if (array[0] != "" && array[1] == "" && array[2] != "")//1 3
            {
                var orders = Program.orderCollection.Find(o => o.ItemName == array[0] && o.Date == array[2]).ToList();
                dGrid.DataSource = orders;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateGrid();
        }
    }
}