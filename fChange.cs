using MongoDB.Driver;
using static MongoDB.Driver.WriteConcern;

namespace cshop
{
    public partial class fChange : Form
    {
        public Order anOrder;
        public fChange(Order order = null)
        {
            InitializeComponent();
            tbItem.Text = order.ItemName.ToString();
            tbCust.Text = order.Customer.ToString();
            tbDate.Text = order.Date.ToString();
            anOrder = order;
        }

        private void bChange_Click(object sender, EventArgs e)
        {
            string new_Item = tbItem.Text;
            string new_Cust = tbCust.Text;
            string new_Date = tbDate.Text;

            var update1 = Builders<Order>.Update.Set(o => o.ItemName, new_Item);
            var update2 = Builders<Order>.Update.Set(o => o.Customer, new_Cust);
            var update3 = Builders<Order>.Update.Set(o => o.Date, new_Date);

            Program.orderCollection.UpdateOne(o => o.ItemName == anOrder.ItemName && o.Customer == anOrder.Customer && o.Date == anOrder.Date, update1);
            Program.orderCollection.UpdateOne(o => o.ItemName == anOrder.ItemName && o.Customer == anOrder.Customer && o.Date == anOrder.Date, update2);
            Program.orderCollection.UpdateOne(o => o.ItemName == anOrder.ItemName && o.Customer == anOrder.Customer && o.Date == anOrder.Date, update3);
            
            Close();
        }
    }
}
