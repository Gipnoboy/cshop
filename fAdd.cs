namespace cshop
{
    public partial class fAdd : Form
    {
        public fAdd()
        {
            InitializeComponent();

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            string item = tbItem.Text;
            string cust = tbCust.Text;
            string date = tbDate.Text;

            Order newOrder = new Order(item, cust, date);

            try
            {
                Program.orderCollection.InsertOne(newOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("The order was inserted successfully!");
                Close();
            }
        }
    }
}
