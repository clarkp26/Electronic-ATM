using E_ATM.Properties;
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
    public partial class Home_Page : Form
    {

        
        public Home_Page()
        {
           // new MongodbClass();
            InitializeComponent();
            
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (CardInsertVar == true)
            {
                
                new Pin_Page().Show();
               // this.Close();

            }
        }

        private void CardInserted_Click(object sender, EventArgs e)
        {
            if(CardInsertVar == false)
            {
                CardInsertVar = true;
                Card_Feedback.Text = "Card Inserted";

            }
            else
            {
                CardInsertVar = false;
                Card_Feedback.Text = "No Card Inserted";

            }

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            new Register_Page().Show();
        }
    }
}
