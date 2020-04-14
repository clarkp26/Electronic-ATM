namespace E_ATM
{
    partial class Deposit_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.DepositAmount = new System.Windows.Forms.TextBox();
            this.DepositProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(997, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter the Amount you Wish to Deposit";
            // 
            // DepositAmount
            // 
            this.DepositAmount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositAmount.Location = new System.Drawing.Point(449, 244);
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.Size = new System.Drawing.Size(372, 62);
            this.DepositAmount.TabIndex = 1;
            this.DepositAmount.TextChanged += new System.EventHandler(this.DepositAmount_TextChanged);
            // 
            // DepositProceed
            // 
            this.DepositProceed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DepositProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositProceed.Location = new System.Drawing.Point(493, 407);
            this.DepositProceed.Name = "DepositProceed";
            this.DepositProceed.Size = new System.Drawing.Size(264, 116);
            this.DepositProceed.TabIndex = 2;
            this.DepositProceed.Text = "Proceed";
            this.DepositProceed.UseVisualStyleBackColor = false;
            this.DepositProceed.Click += new System.EventHandler(this.DepositProceed_Click);
            // 
            // Deposit_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1226, 647);
            this.Controls.Add(this.DepositProceed);
            this.Controls.Add(this.DepositAmount);
            this.Controls.Add(this.label1);
            this.Name = "Deposit_Page";
            this.Text = "Deposit Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepositAmount;
        private System.Windows.Forms.Button DepositProceed;
    }
}