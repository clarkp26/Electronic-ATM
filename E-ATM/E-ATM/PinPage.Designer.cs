namespace E_ATM
{
    partial class Pin_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pin_Page));
            this.PinCodeBox = new System.Windows.Forms.TextBox();
            this.Pin_Label = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.PinMessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PinCodeBox
            // 
            this.PinCodeBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PinCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinCodeBox.Location = new System.Drawing.Point(461, 211);
            this.PinCodeBox.Name = "PinCodeBox";
            this.PinCodeBox.Size = new System.Drawing.Size(363, 62);
            this.PinCodeBox.TabIndex = 0;
            this.PinCodeBox.TextChanged += new System.EventHandler(this.PinCodeBox_TextChanged);
            // 
            // Pin_Label
            // 
            this.Pin_Label.AutoSize = true;
            this.Pin_Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin_Label.Location = new System.Drawing.Point(325, 86);
            this.Pin_Label.Name = "Pin_Label";
            this.Pin_Label.Size = new System.Drawing.Size(640, 55);
            this.Pin_Label.TabIndex = 1;
            this.Pin_Label.Text = "Please Enter Your Pin Below";
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(901, 204);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(164, 69);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // PinMessageBox
            // 
            this.PinMessageBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PinMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinMessageBox.Location = new System.Drawing.Point(277, 382);
            this.PinMessageBox.Name = "PinMessageBox";
            this.PinMessageBox.Size = new System.Drawing.Size(761, 62);
            this.PinMessageBox.TabIndex = 3;
            this.PinMessageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.PinMessageBox);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Pin_Label);
            this.Controls.Add(this.PinCodeBox);
            this.Name = "Pin_Page";
            this.Text = "Pin Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PinCodeBox;
        private System.Windows.Forms.Label Pin_Label;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox PinMessageBox;

        private const int Pin_Code = 12345;
        private int attempt_counter = 3;
        
    }
}