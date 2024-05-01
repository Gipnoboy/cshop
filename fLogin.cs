using MongoDB.Driver;

namespace cshop
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var user = Program.staffCollection.Find(s => s.Username == username && s.Password == password).FirstOrDefault();
            if (user != null)
            {
                fMain fMain = new fMain();
                this.Hide();
                fMain.Show();
                fMain.BringToFront();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
    }
}
