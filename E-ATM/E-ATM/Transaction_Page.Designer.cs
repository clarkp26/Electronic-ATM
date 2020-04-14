namespace E_ATM
{
    partial class Transaction_Choice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_Choice));
            this.label1 = new System.Windows.Forms.Label();
            this.Withdrawal = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Transaction Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Withdrawal
            // 
            this.Withdrawal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Withdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdrawal.Location = new System.Drawing.Point(197, 283);
            this.Withdrawal.Name = "Withdrawal";
            this.Withdrawal.Size = new System.Drawing.Size(328, 106);
            this.Withdrawal.TabIndex = 1;
            this.Withdrawal.Text = "Withdrawal";
            this.Withdrawal.UseVisualStyleBackColor = false;
            this.Withdrawal.Click += new System.EventHandler(this.Withdrawal_Click);
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.Location = new System.Drawing.Point(712, 283);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(328, 106);
            this.Deposit.TabIndex = 2;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Transaction_Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1199, 645);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Withdrawal);
            this.Controls.Add(this.label1);
            this.Name = "Transaction_Choice";
            this.Text = "Choose Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Withdrawal;
        private System.Windows.Forms.Button Deposit;
    }
}