using E_ATM.Properties;
using MongoDB.Driver;


namespace E_ATM

{
    partial class Home_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.Card_Feedback = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.CardInserted = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Insert Your Card";
            // 
            // Card_Feedback
            // 
            this.Card_Feedback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Card_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card_Feedback.Location = new System.Drawing.Point(472, 255);
            this.Card_Feedback.Name = "Card_Feedback";
            this.Card_Feedback.ReadOnly = true;
            this.Card_Feedback.Size = new System.Drawing.Size(488, 62);
            this.Card_Feedback.TabIndex = 1;
            this.Card_Feedback.Text = "No Card Inserted";
            this.Card_Feedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(1092, 251);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(160, 72);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // CardInserted
            // 
            this.CardInserted.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CardInserted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardInserted.Location = new System.Drawing.Point(168, 245);
            this.CardInserted.Name = "CardInserted";
            this.CardInserted.Size = new System.Drawing.Size(169, 72);
            this.CardInserted.TabIndex = 3;
            this.CardInserted.Text = "Card Insert";
            this.CardInserted.UseVisualStyleBackColor = false;
            this.CardInserted.Click += new System.EventHandler(this.CardInserted_Click);
            // 
            // Register_Button
            // 
            this.Register_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Register_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Button.Location = new System.Drawing.Point(650, 394);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(169, 72);
            this.Register_Button.TabIndex = 4;
            this.Register_Button.Text = "Register New Account";
            this.Register_Button.UseVisualStyleBackColor = false;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 536);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.CardInserted);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Card_Feedback);
            this.Controls.Add(this.label1);
            this.Name = "Home_Page";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Card_Feedback;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button CardInserted;

        private static bool CardInsertVar = false;
        private System.Windows.Forms.Button Register_Button;
    }
}