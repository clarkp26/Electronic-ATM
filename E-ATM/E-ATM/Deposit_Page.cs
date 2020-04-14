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

namespace E_ATM
{
    public partial class Deposit_Page : Form
    {
        MongodbClass DBClass = new MongodbClass();
        public FilterDefinition<BsonDocument> query_pin;
        public BsonDocument Doc;

        public Deposit_Page(FilterDefinition<BsonDocument> query_pin)
        {
            this.query_pin = query_pin;
            Doc = DBClass.BankAccounts.Find(query_pin).FirstOrDefault();

            InitializeComponent();
        }

        private void DepositAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DepositProceed_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance += Int32.Parse(DepositAmount.Text);
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            DepositAmount.Text = IntBalance.ToString();

            MessageBox.Show("The Funds have been added to your Account\nThank you!");
            this.Close();
            
        }
    }
}
