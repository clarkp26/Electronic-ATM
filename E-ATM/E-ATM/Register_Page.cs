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
    public partial class Register_Page : Form
    {
        MongodbClass DBdoc = new MongodbClass();
        

        public Register_Page()
        {
            InitializeComponent();
        }
        
        private void Register_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var x = Int32.Parse(Pin_Details.Text);
            }
            catch (FormatException)
            {
                Pin_Details.Text = "";
                MessageBox.Show("Pin entered can only contain numbers.\n" +
                    "Please re-enter your Pin");
                return;
            }
            try
            {
                var x = Int32.Parse(Balance_Details.Text);
            }
            catch (FormatException)
            {
                Pin_Details.Text = "";
                MessageBox.Show("Balance Entered must be a Number.\nPlease re-enter your Balance");
                return;
            }
            var query_pin = Builders<BsonDocument>.Filter.Eq("Pin", Int32.Parse(Pin_Details.Text));
            var DocFromDB = DBdoc.BankAccounts.Find(query_pin).FirstOrDefault();
            if (DocFromDB == null)
            {
               
                var doc = new BsonDocument
            {
                {"Pin", Int32.Parse(Pin_Details.Text) },
                {"FisrtName", FirstName_Details.Text },
                {"SecondName", Surname_Details.Text },
                {"Balance", Int32.Parse(Balance_Details.Text) }
            };

                DBdoc.BankAccounts.InsertOne(doc);
                MessageBox.Show("User Registered Successfully");
                this.Close();
            }
            else
            {
                Pin_Details.Text = "";
                /*FirstName_Details.Text = "";
                Surname_Details.Text = "";
                Balance_Details.Text = "";*/
                MessageBox.Show("Pin entered has already been taken\n" +
                    "Please try again with a different Pin.");
            }
            
        }
        private void Cancel_Register_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
