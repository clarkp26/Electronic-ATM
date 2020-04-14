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
    public partial class AccountPage : Form
    {
        MongodbClass DBClass = new MongodbClass();
        public FilterDefinition<BsonDocument> query_pin;
        public BsonDocument Doc;

        public AccountPage(FilterDefinition<BsonDocument> query_pin)
        {
            this.query_pin = query_pin;
            Doc = DBClass.BankAccounts.Find(query_pin).FirstOrDefault();
            InitializeComponent();
            label2.Text = Doc.GetValue("Balance").ToString();
            Money_Withdraw_Panel.Hide();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Twenty_Euro_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance -= 20;
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            label2.Text = IntBalance.ToString();

            MessageBox.Show("Thank You!\nPlease Take your Cash");
            this.Close();

        }

        private void Forty_Euro_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance -= 40;
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            label2.Text = IntBalance.ToString();
            MessageBox.Show("Thank You!\nPlease Take your Cash");
            this.Close();
        }

        private void Sixty_Euro_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance -= 60;
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            label2.Text = IntBalance.ToString();
            MessageBox.Show("Thank You!\nPlease Take your Cash");
            this.Close();
        }

        private void Eighty_Euro_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance -= 80;
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            label2.Text = IntBalance.ToString();
            MessageBox.Show("Thank You!\nPlease Take your Cash");
            this.Close();
        }

        private void Hundred_Euro_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance -= 100;
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            label2.Text = IntBalance.ToString();
            MessageBox.Show("Thank You!\nPlease Take your Cash");
            this.Close();
        }

        private void Hundred_and_Twenty_Euro_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance -= 120;
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            label2.Text = IntBalance.ToString();
            MessageBox.Show("Thank You!\nPlease Take your Cash");
            this.Close();
        }

        private void Hundred_and_Forty_Euro_Click(object sender, EventArgs e)
        {
            var balance = Doc.GetValue("Balance").ToString();
            int IntBalance = Int32.Parse(balance);
            IntBalance -= 140;
            var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
            var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
            label2.Text = IntBalance.ToString();
            MessageBox.Show("Thank You!\nPlease Take your Cash");
            this.Close();
        }

        private void Other_Click(object sender, EventArgs e)
        {
            Money_Withdraw_Panel.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Doc.GetValue("Balance").ToString();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int Withdraw_Amount = Int32.Parse(Withdraw_Money_Textbox.Text);
            
            if (Withdraw_Amount > 1000)
            {
                MessageBox.Show("Max Withdrawal is €1000.\nPlease re-enter an Amount within this limit");
                Withdraw_Money_Textbox.Text = "";
            }
            else
            {
                var balance = Doc.GetValue("Balance").ToString();
                int IntBalance = Int32.Parse(balance);
                IntBalance -= Withdraw_Amount;
                var update = Builders<BsonDocument>.Update.Set("Balance", IntBalance);
                var DocumentFromDatabase = DBClass.BankAccounts.UpdateOneAsync(query_pin, update).Result;
                label2.Text = IntBalance.ToString();
                MessageBox.Show("Thank you!\nPlease take your cash");
                this.Close();
            }
        }

        private void AccountPage_Load(object sender, EventArgs e)
        {

        }

        private void Money_Withdraw_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
