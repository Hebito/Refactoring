
namespace ATM
{
    partial class frmAccount
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_checking = new System.Windows.Forms.Label();
            this.lbl_Saving = new System.Windows.Forms.Label();
            this.label_Balances = new System.Windows.Forms.Label();
            this.label_Checking = new System.Windows.Forms.Label();
            this.label_saving = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.label_DollarCheck = new System.Windows.Forms.Label();
            this.label_DollarSaving = new System.Windows.Forms.Label();
            this.label_Transaction = new System.Windows.Forms.Label();
            this.label_CtoS = new System.Windows.Forms.Label();
            this.label_WChecking = new System.Windows.Forms.Label();
            this.label_DChecking = new System.Windows.Forms.Label();
            this.txt_WChecking = new System.Windows.Forms.TextBox();
            this.txt_DChecking = new System.Windows.Forms.TextBox();
            this.label_StoC = new System.Windows.Forms.Label();
            this.txt_DSaving = new System.Windows.Forms.TextBox();
            this.txt_WSaving = new System.Windows.Forms.TextBox();
            this.label_DSaving = new System.Windows.Forms.Label();
            this.label_WSaving = new System.Windows.Forms.Label();
            this.btn_WChecking = new System.Windows.Forms.Button();
            this.btn_DChecking = new System.Windows.Forms.Button();
            this.btn_DSaving = new System.Windows.Forms.Button();
            this.btn_WSaving = new System.Windows.Forms.Button();
            this.label_Transfer = new System.Windows.Forms.Label();
            this.txt_Transfer = new System.Windows.Forms.TextBox();
            this.btn_StoC = new System.Windows.Forms.Button();
            this.btn_CtoS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbl_welcome.Location = new System.Drawing.Point(339, 22);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(162, 16);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to your account!";
            // 
            // lbl_checking
            // 
            this.lbl_checking.AutoSize = true;
            this.lbl_checking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_checking.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_checking.Location = new System.Drawing.Point(32, 146);
            this.lbl_checking.Name = "lbl_checking";
            this.lbl_checking.Size = new System.Drawing.Size(158, 20);
            this.lbl_checking.TabIndex = 1;
            this.lbl_checking.Text = "Checkings Account:";
            // 
            // lbl_Saving
            // 
            this.lbl_Saving.AutoSize = true;
            this.lbl_Saving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_Saving.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Saving.Location = new System.Drawing.Point(51, 210);
            this.lbl_Saving.Name = "lbl_Saving";
            this.lbl_Saving.Size = new System.Drawing.Size(139, 20);
            this.lbl_Saving.TabIndex = 2;
            this.lbl_Saving.Text = "Savings Account:";
            // 
            // label_Balances
            // 
            this.label_Balances.AutoSize = true;
            this.label_Balances.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label_Balances.Location = new System.Drawing.Point(65, 81);
            this.label_Balances.Name = "label_Balances";
            this.label_Balances.Size = new System.Drawing.Size(158, 39);
            this.label_Balances.TabIndex = 3;
            this.label_Balances.Text = "Balances";
            // 
            // label_Checking
            // 
            this.label_Checking.AutoSize = true;
            this.label_Checking.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Checking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Checking.Location = new System.Drawing.Point(199, 150);
            this.label_Checking.Name = "label_Checking";
            this.label_Checking.Size = new System.Drawing.Size(34, 16);
            this.label_Checking.TabIndex = 7;
            this.label_Checking.Text = "Test";
            // 
            // label_saving
            // 
            this.label_saving.AutoSize = true;
            this.label_saving.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_saving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_saving.Location = new System.Drawing.Point(199, 214);
            this.label_saving.Name = "label_saving";
            this.label_saving.Size = new System.Drawing.Size(34, 16);
            this.label_saving.TabIndex = 8;
            this.label_saving.Text = "Test";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.CadetBlue;
            this.btn_LogOut.Location = new System.Drawing.Point(689, 405);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(75, 33);
            this.btn_LogOut.TabIndex = 9;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // label_DollarCheck
            // 
            this.label_DollarCheck.AutoSize = true;
            this.label_DollarCheck.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold);
            this.label_DollarCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_DollarCheck.Location = new System.Drawing.Point(185, 148);
            this.label_DollarCheck.Name = "label_DollarCheck";
            this.label_DollarCheck.Size = new System.Drawing.Size(18, 19);
            this.label_DollarCheck.TabIndex = 10;
            this.label_DollarCheck.Text = "$";
            // 
            // label_DollarSaving
            // 
            this.label_DollarSaving.AutoSize = true;
            this.label_DollarSaving.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold);
            this.label_DollarSaving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_DollarSaving.Location = new System.Drawing.Point(185, 214);
            this.label_DollarSaving.Name = "label_DollarSaving";
            this.label_DollarSaving.Size = new System.Drawing.Size(18, 19);
            this.label_DollarSaving.TabIndex = 11;
            this.label_DollarSaving.Text = "$";
            // 
            // label_Transaction
            // 
            this.label_Transaction.AutoSize = true;
            this.label_Transaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label_Transaction.ForeColor = System.Drawing.Color.Crimson;
            this.label_Transaction.Location = new System.Drawing.Point(490, 81);
            this.label_Transaction.Name = "label_Transaction";
            this.label_Transaction.Size = new System.Drawing.Size(195, 39);
            this.label_Transaction.TabIndex = 12;
            this.label_Transaction.Text = "Transaction";
            // 
            // label_CtoS
            // 
            this.label_CtoS.AutoSize = true;
            this.label_CtoS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label_CtoS.ForeColor = System.Drawing.Color.SeaGreen;
            this.label_CtoS.Location = new System.Drawing.Point(495, 137);
            this.label_CtoS.Name = "label_CtoS";
            this.label_CtoS.Size = new System.Drawing.Size(96, 20);
            this.label_CtoS.TabIndex = 13;
            this.label_CtoS.Text = "Checkings";
            // 
            // label_WChecking
            // 
            this.label_WChecking.AutoSize = true;
            this.label_WChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_WChecking.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_WChecking.Location = new System.Drawing.Point(444, 164);
            this.label_WChecking.Name = "label_WChecking";
            this.label_WChecking.Size = new System.Drawing.Size(93, 20);
            this.label_WChecking.TabIndex = 14;
            this.label_WChecking.Text = "Widthdraw:";
            // 
            // label_DChecking
            // 
            this.label_DChecking.AutoSize = true;
            this.label_DChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_DChecking.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_DChecking.Location = new System.Drawing.Point(465, 208);
            this.label_DChecking.Name = "label_DChecking";
            this.label_DChecking.Size = new System.Drawing.Size(72, 20);
            this.label_DChecking.TabIndex = 15;
            this.label_DChecking.Text = "Deposit:";
            // 
            // txt_WChecking
            // 
            this.txt_WChecking.Location = new System.Drawing.Point(543, 164);
            this.txt_WChecking.Name = "txt_WChecking";
            this.txt_WChecking.Size = new System.Drawing.Size(100, 20);
            this.txt_WChecking.TabIndex = 16;
            // 
            // txt_DChecking
            // 
            this.txt_DChecking.Location = new System.Drawing.Point(543, 209);
            this.txt_DChecking.Name = "txt_DChecking";
            this.txt_DChecking.Size = new System.Drawing.Size(100, 20);
            this.txt_DChecking.TabIndex = 17;
            // 
            // label_StoC
            // 
            this.label_StoC.AutoSize = true;
            this.label_StoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label_StoC.ForeColor = System.Drawing.Color.Orange;
            this.label_StoC.Location = new System.Drawing.Point(495, 241);
            this.label_StoC.Name = "label_StoC";
            this.label_StoC.Size = new System.Drawing.Size(75, 20);
            this.label_StoC.TabIndex = 18;
            this.label_StoC.Text = "Savings";
            // 
            // txt_DSaving
            // 
            this.txt_DSaving.Location = new System.Drawing.Point(543, 317);
            this.txt_DSaving.Name = "txt_DSaving";
            this.txt_DSaving.Size = new System.Drawing.Size(100, 20);
            this.txt_DSaving.TabIndex = 22;
            // 
            // txt_WSaving
            // 
            this.txt_WSaving.Location = new System.Drawing.Point(543, 272);
            this.txt_WSaving.Name = "txt_WSaving";
            this.txt_WSaving.Size = new System.Drawing.Size(100, 20);
            this.txt_WSaving.TabIndex = 21;
            // 
            // label_DSaving
            // 
            this.label_DSaving.AutoSize = true;
            this.label_DSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_DSaving.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_DSaving.Location = new System.Drawing.Point(465, 316);
            this.label_DSaving.Name = "label_DSaving";
            this.label_DSaving.Size = new System.Drawing.Size(72, 20);
            this.label_DSaving.TabIndex = 20;
            this.label_DSaving.Text = "Deposit:";
            // 
            // label_WSaving
            // 
            this.label_WSaving.AutoSize = true;
            this.label_WSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_WSaving.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_WSaving.Location = new System.Drawing.Point(444, 272);
            this.label_WSaving.Name = "label_WSaving";
            this.label_WSaving.Size = new System.Drawing.Size(93, 20);
            this.label_WSaving.TabIndex = 19;
            this.label_WSaving.Text = "Widthdraw:";
            // 
            // btn_WChecking
            // 
            this.btn_WChecking.ForeColor = System.Drawing.Color.DimGray;
            this.btn_WChecking.Location = new System.Drawing.Point(668, 162);
            this.btn_WChecking.Name = "btn_WChecking";
            this.btn_WChecking.Size = new System.Drawing.Size(75, 23);
            this.btn_WChecking.TabIndex = 24;
            this.btn_WChecking.Text = "Withdraw";
            this.btn_WChecking.UseVisualStyleBackColor = true;
            this.btn_WChecking.Click += new System.EventHandler(this.btn_WChecking_Click);
            // 
            // btn_DChecking
            // 
            this.btn_DChecking.ForeColor = System.Drawing.Color.DimGray;
            this.btn_DChecking.Location = new System.Drawing.Point(668, 205);
            this.btn_DChecking.Name = "btn_DChecking";
            this.btn_DChecking.Size = new System.Drawing.Size(75, 23);
            this.btn_DChecking.TabIndex = 25;
            this.btn_DChecking.Text = "Deposit";
            this.btn_DChecking.UseVisualStyleBackColor = true;
            this.btn_DChecking.Click += new System.EventHandler(this.btn_DChecking_Click);
            // 
            // btn_DSaving
            // 
            this.btn_DSaving.ForeColor = System.Drawing.Color.DimGray;
            this.btn_DSaving.Location = new System.Drawing.Point(668, 313);
            this.btn_DSaving.Name = "btn_DSaving";
            this.btn_DSaving.Size = new System.Drawing.Size(75, 23);
            this.btn_DSaving.TabIndex = 27;
            this.btn_DSaving.Text = "Deposit";
            this.btn_DSaving.UseVisualStyleBackColor = true;
            this.btn_DSaving.Click += new System.EventHandler(this.btn_DSaving_Click);
            // 
            // btn_WSaving
            // 
            this.btn_WSaving.ForeColor = System.Drawing.Color.DimGray;
            this.btn_WSaving.Location = new System.Drawing.Point(668, 270);
            this.btn_WSaving.Name = "btn_WSaving";
            this.btn_WSaving.Size = new System.Drawing.Size(75, 23);
            this.btn_WSaving.TabIndex = 26;
            this.btn_WSaving.Text = "Withdraw";
            this.btn_WSaving.UseVisualStyleBackColor = true;
            this.btn_WSaving.Click += new System.EventHandler(this.btn_WSaving_Click);
            // 
            // label_Transfer
            // 
            this.label_Transfer.AutoSize = true;
            this.label_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label_Transfer.ForeColor = System.Drawing.Color.Purple;
            this.label_Transfer.Location = new System.Drawing.Point(136, 251);
            this.label_Transfer.Name = "label_Transfer";
            this.label_Transfer.Size = new System.Drawing.Size(174, 47);
            this.label_Transfer.TabIndex = 28;
            this.label_Transfer.Text = "Transfer";
            // 
            // txt_Transfer
            // 
            this.txt_Transfer.Location = new System.Drawing.Point(153, 316);
            this.txt_Transfer.Name = "txt_Transfer";
            this.txt_Transfer.Size = new System.Drawing.Size(134, 20);
            this.txt_Transfer.TabIndex = 29;
            // 
            // btn_StoC
            // 
            this.btn_StoC.ForeColor = System.Drawing.Color.DimGray;
            this.btn_StoC.Location = new System.Drawing.Point(87, 342);
            this.btn_StoC.Name = "btn_StoC";
            this.btn_StoC.Size = new System.Drawing.Size(132, 23);
            this.btn_StoC.TabIndex = 30;
            this.btn_StoC.Text = "Saving to Checking";
            this.btn_StoC.UseVisualStyleBackColor = true;
            this.btn_StoC.Click += new System.EventHandler(this.btn_StoC_Click);
            // 
            // btn_CtoS
            // 
            this.btn_CtoS.ForeColor = System.Drawing.Color.DimGray;
            this.btn_CtoS.Location = new System.Drawing.Point(225, 342);
            this.btn_CtoS.Name = "btn_CtoS";
            this.btn_CtoS.Size = new System.Drawing.Size(112, 23);
            this.btn_CtoS.TabIndex = 31;
            this.btn_CtoS.Text = "Checking to Saving";
            this.btn_CtoS.UseVisualStyleBackColor = true;
            this.btn_CtoS.Click += new System.EventHandler(this.btn_CtoS_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CtoS);
            this.Controls.Add(this.btn_StoC);
            this.Controls.Add(this.txt_Transfer);
            this.Controls.Add(this.label_Transfer);
            this.Controls.Add(this.btn_DSaving);
            this.Controls.Add(this.btn_WSaving);
            this.Controls.Add(this.btn_DChecking);
            this.Controls.Add(this.btn_WChecking);
            this.Controls.Add(this.txt_DSaving);
            this.Controls.Add(this.txt_WSaving);
            this.Controls.Add(this.label_DSaving);
            this.Controls.Add(this.label_WSaving);
            this.Controls.Add(this.label_StoC);
            this.Controls.Add(this.txt_DChecking);
            this.Controls.Add(this.txt_WChecking);
            this.Controls.Add(this.label_DChecking);
            this.Controls.Add(this.label_WChecking);
            this.Controls.Add(this.label_CtoS);
            this.Controls.Add(this.label_Transaction);
            this.Controls.Add(this.label_DollarSaving);
            this.Controls.Add(this.label_DollarCheck);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.label_saving);
            this.Controls.Add(this.label_Checking);
            this.Controls.Add(this.label_Balances);
            this.Controls.Add(this.lbl_Saving);
            this.Controls.Add(this.lbl_checking);
            this.Controls.Add(this.lbl_welcome);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "frmAccount";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_checking;
        private System.Windows.Forms.Label lbl_Saving;
        private System.Windows.Forms.Label label_Balances;
        private System.Windows.Forms.Label label_Checking;
        private System.Windows.Forms.Label label_saving;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label label_DollarCheck;
        private System.Windows.Forms.Label label_DollarSaving;
        private System.Windows.Forms.Label label_Transaction;
        private System.Windows.Forms.Label label_CtoS;
        private System.Windows.Forms.Label label_WChecking;
        private System.Windows.Forms.Label label_DChecking;
        private System.Windows.Forms.TextBox txt_WChecking;
        private System.Windows.Forms.TextBox txt_DChecking;
        private System.Windows.Forms.Label label_StoC;
        private System.Windows.Forms.TextBox txt_DSaving;
        private System.Windows.Forms.TextBox txt_WSaving;
        private System.Windows.Forms.Label label_DSaving;
        private System.Windows.Forms.Label label_WSaving;
        private System.Windows.Forms.Button btn_WChecking;
        private System.Windows.Forms.Button btn_DChecking;
        private System.Windows.Forms.Button btn_DSaving;
        private System.Windows.Forms.Button btn_WSaving;
        private System.Windows.Forms.Label label_Transfer;
        private System.Windows.Forms.TextBox txt_Transfer;
        private System.Windows.Forms.Button btn_StoC;
        private System.Windows.Forms.Button btn_CtoS;
    }
}