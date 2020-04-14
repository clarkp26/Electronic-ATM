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
    public partial class Transaction_Choice : Form
    {
        public FilterDefinition<BsonDocument> query_pin;

        public Transaction_Choice(FilterDefinition<BsonDocument> query_pin)
        {
            this.query_pin = query_pin;
            InitializeComponent();
        }

        private void Withdrawal_Click(object sender, EventArgs e)
        {
            new AccountPage(query_pin).Show();
            this.Close();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            new Deposit_Page(query_pin).Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
