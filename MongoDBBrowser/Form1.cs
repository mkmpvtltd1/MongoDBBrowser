using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MongoDBBrowser
{
    public partial class MongoDBBrowser : Form
    {
        //protected static IMongoClient _client;
        //protected static IMongoDatabase _database;
        public MongoDBBrowser()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectServer();
        }

        private void ConnectServer()
        {
            string ConnectionString = "mongodb://Manoj:Com456@ds037215.mongolab.com:37215/mkmpvtltd";
            MongoServer mongo = MongoServer.Create();
            mongo.Connect();
            var db = mongo.GetDatabase("tutorial");



            mongo.Disconnect();
        }
    }
}
