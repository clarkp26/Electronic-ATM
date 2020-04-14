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
    public partial class Pin_Page : Form
    {
        public Pin_Page()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            MongodbClass x = new MongodbClass();
            FilterDefinition<BsonDocument> query_pin = null;
            BsonDocument DocumentFromDatabase = null;
            try
            {
                query_pin = Builders<BsonDocument>.Filter.Eq("Pin", Int32.Parse(PinCodeBox.Text));

            }
            catch (FormatException)
            {
                PinCodeBox.Text = "";
                PinMessageBox.Text = "Invalid Pin. Please Try Again";
                return;
            }
            DocumentFromDatabase = x.BankAccounts.Find(query_pin).FirstOrDefault();

            /*
            var update = Builders<BsonDocument>.Update.Set("Balance", 1000);
            var DocumentFromDatabase = x.BankAccounts.UpdateOneAsync(query_pin,update).Result;
            */

            //x.BankAccounts.UpdateOne
            if (DocumentFromDatabase == null)
            {
                attempt_counter--;

                   if (attempt_counter == 0)
                   {
                       attempt_counter = 3;
                       this.Close();
                   }
                PinCodeBox.Text = "";
                PinMessageBox.Text = "Pin Incorrect. " + attempt_counter + " attempts left";
            }
            else
            {
                new Transaction_Choice(query_pin).Show();
                this.Close();
            }
        }

        private void PinCodeBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
