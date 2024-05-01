using MongoDB.Driver;

namespace cshop
{
    internal static class Program
    {
        public static IMongoCollection<Order> orderCollection;
        public static IMongoCollection<Staff> staffCollection;
        [STAThread]
        static void Main()
        {
            var conn = "mongodb+srv://Gipnoboy:1234@shop.pl0okcs.mongodb.net/?retryWrites=true&w=majority&appName=Shop";
            var client = new MongoClient(conn);
            try
            {
                var database = client.GetDatabase("Shop");

                orderCollection = database.GetCollection<Order>("Orders");
                staffCollection = database.GetCollection<Staff>("Staff");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new fLogin());
        }
    }
}