
namespace ATM
{
    partial class frmLogin
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_AN = new System.Windows.Forms.Label();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.txt_AN = new System.Windows.Forms.TextBox();
            this.txt_PIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(315, 207);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_AN
            // 
            this.lbl_AN.AutoSize = true;
            this.lbl_AN.Location = new System.Drawing.Point(111, 87);
            this.lbl_AN.Name = "lbl_AN";
            this.lbl_AN.Size = new System.Drawing.Size(90, 13);
            this.lbl_AN.TabIndex = 1;
            this.lbl_AN.Text = "Account Number:";
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.Location = new System.Drawing.Point(173, 140);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(28, 13);
            this.lbl_Pin.TabIndex = 2;
            this.lbl_Pin.Text = "PIN:";
            // 
            // txt_AN
            // 
            this.txt_AN.Location = new System.Drawing.Point(207, 84);
            this.txt_AN.Name = "txt_AN";
            this.txt_AN.Size = new System.Drawing.Size(100, 20);
            this.txt_AN.TabIndex = 3;
            // 
            // txt_PIN
            // 
            this.txt_PIN.Location = new System.Drawing.Point(207, 140);
            this.txt_PIN.Name = "txt_PIN";
            this.txt_PIN.Size = new System.Drawing.Size(100, 20);
            this.txt_PIN.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 323);
            this.Controls.Add(this.txt_PIN);
            this.Controls.Add(this.txt_AN);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.lbl_AN);
            this.Controls.Add(this.btn_Login);
            this.Name = "Login";
            this.Text = "Login into Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_AN;
        private System.Windows.Forms.Label lbl_Pin;
        private System.Windows.Forms.TextBox txt_AN;
        private System.Windows.Forms.TextBox txt_PIN;
    }
}

