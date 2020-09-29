namespace Accounts
{
    partial class ATM
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
            this.CreditLabel = new System.Windows.Forms.Label();
            this.LeftLabel = new System.Windows.Forms.Label();
            this.MoneyDeposittextBox = new System.Windows.Forms.TextBox();
            this.FetchMoneytextBox = new System.Windows.Forms.TextBox();
            this.MoneyDepositbutton = new System.Windows.Forms.Button();
            this.MoneyFetchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Textlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.Location = new System.Drawing.Point(283, 352);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(55, 15);
            this.CreditLabel.TabIndex = 17;
            this.CreditLabel.Text = "label4";
            // 
            // LeftLabel
            // 
            this.LeftLabel.AutoSize = true;
            this.LeftLabel.Location = new System.Drawing.Point(280, 207);
            this.LeftLabel.Name = "LeftLabel";
            this.LeftLabel.Size = new System.Drawing.Size(55, 15);
            this.LeftLabel.TabIndex = 16;
            this.LeftLabel.Text = "label3";
            // 
            // MoneyDeposittextBox
            // 
            this.MoneyDeposittextBox.Location = new System.Drawing.Point(455, 337);
            this.MoneyDeposittextBox.Name = "MoneyDeposittextBox";
            this.MoneyDeposittextBox.Size = new System.Drawing.Size(100, 25);
            this.MoneyDeposittextBox.TabIndex = 15;
            // 
            // FetchMoneytextBox
            // 
            this.FetchMoneytextBox.Location = new System.Drawing.Point(455, 243);
            this.FetchMoneytextBox.Name = "FetchMoneytextBox";
            this.FetchMoneytextBox.Size = new System.Drawing.Size(100, 25);
            this.FetchMoneytextBox.TabIndex = 14;
            // 
            // MoneyDepositbutton
            // 
            this.MoneyDepositbutton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.MoneyDepositbutton.Location = new System.Drawing.Point(597, 333);
            this.MoneyDepositbutton.Name = "MoneyDepositbutton";
            this.MoneyDepositbutton.Size = new System.Drawing.Size(100, 38);
            this.MoneyDepositbutton.TabIndex = 13;
            this.MoneyDepositbutton.Text = "存钱";
            this.MoneyDepositbutton.UseVisualStyleBackColor = true;
            this.MoneyDepositbutton.Click += new System.EventHandler(this.MoneyDepositbutton_Click);
            // 
            // MoneyFetchbutton
            // 
            this.MoneyFetchbutton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.MoneyFetchbutton.Location = new System.Drawing.Point(597, 227);
            this.MoneyFetchbutton.Name = "MoneyFetchbutton";
            this.MoneyFetchbutton.Size = new System.Drawing.Size(100, 41);
            this.MoneyFetchbutton.TabIndex = 12;
            this.MoneyFetchbutton.Text = "取钱";
            this.MoneyFetchbutton.UseVisualStyleBackColor = true;
            this.MoneyFetchbutton.Click += new System.EventHandler(this.MoneyFetchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(103, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "信用额度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(122, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "余额";
            // 
            // Textlabel
            // 
            this.Textlabel.AutoSize = true;
            this.Textlabel.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Textlabel.Location = new System.Drawing.Point(122, 79);
            this.Textlabel.Name = "Textlabel";
            this.Textlabel.Size = new System.Drawing.Size(157, 28);
            this.Textlabel.TabIndex = 9;
            this.Textlabel.Text = "金泽辉用户";
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.LeftLabel);
            this.Controls.Add(this.MoneyDeposittextBox);
            this.Controls.Add(this.FetchMoneytextBox);
            this.Controls.Add(this.MoneyDepositbutton);
            this.Controls.Add(this.MoneyFetchbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Textlabel);
            this.Name = "ATM";
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditLabel;
        private System.Windows.Forms.Label LeftLabel;
        private System.Windows.Forms.TextBox MoneyDeposittextBox;
        private System.Windows.Forms.TextBox FetchMoneytextBox;
        private System.Windows.Forms.Button MoneyDepositbutton;
        private System.Windows.Forms.Button MoneyFetchbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Textlabel;
    }
}