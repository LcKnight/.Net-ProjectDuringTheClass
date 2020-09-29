namespace Accounts
{
    partial class BankManager
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
            this.AccountlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditAccountlistView = new System.Windows.Forms.ListView();
            this.CreditNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditMoneycolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.LefttextBox = new System.Windows.Forms.TextBox();
            this.CredittextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountlistView
            // 
            this.AccountlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.AccountlistView.FullRowSelect = true;
            this.AccountlistView.GridLines = true;
            this.AccountlistView.HideSelection = false;
            this.AccountlistView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AccountlistView.Location = new System.Drawing.Point(82, 98);
            this.AccountlistView.Name = "AccountlistView";
            this.AccountlistView.Size = new System.Drawing.Size(277, 192);
            this.AccountlistView.TabIndex = 0;
            this.AccountlistView.UseCompatibleStateImageBehavior = false;
            this.AccountlistView.View = System.Windows.Forms.View.Details;
            this.AccountlistView.Click += new System.EventHandler(this.AccountlistView_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户名";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "余额";
            this.columnHeader2.Width = 193;
            // 
            // CreditAccountlistView
            // 
            this.CreditAccountlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CreditNamecolumnHeader,
            this.CreditMoneycolumnHeader,
            this.CreditcolumnHeader});
            this.CreditAccountlistView.GridLines = true;
            this.CreditAccountlistView.HideSelection = false;
            this.CreditAccountlistView.Location = new System.Drawing.Point(392, 98);
            this.CreditAccountlistView.Name = "CreditAccountlistView";
            this.CreditAccountlistView.Size = new System.Drawing.Size(291, 192);
            this.CreditAccountlistView.TabIndex = 1;
            this.CreditAccountlistView.UseCompatibleStateImageBehavior = false;
            this.CreditAccountlistView.View = System.Windows.Forms.View.Details;
            this.CreditAccountlistView.Click += new System.EventHandler(this.CreditAccountlistView_Click);
            // 
            // CreditNamecolumnHeader
            // 
            this.CreditNamecolumnHeader.Text = "用户名";
            this.CreditNamecolumnHeader.Width = 82;
            // 
            // CreditMoneycolumnHeader
            // 
            this.CreditMoneycolumnHeader.Text = "余额";
            this.CreditMoneycolumnHeader.Width = 67;
            // 
            // CreditcolumnHeader
            // 
            this.CreditcolumnHeader.Text = "信用额度";
            this.CreditcolumnHeader.Width = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(304, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "管理员界面";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(103, 336);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 25);
            this.NametextBox.TabIndex = 3;
            // 
            // LefttextBox
            // 
            this.LefttextBox.Location = new System.Drawing.Point(338, 336);
            this.LefttextBox.Name = "LefttextBox";
            this.LefttextBox.Size = new System.Drawing.Size(100, 25);
            this.LefttextBox.TabIndex = 4;
            // 
            // CredittextBox
            // 
            this.CredittextBox.Location = new System.Drawing.Point(534, 336);
            this.CredittextBox.Name = "CredittextBox";
            this.CredittextBox.Size = new System.Drawing.Size(100, 25);
            this.CredittextBox.TabIndex = 5;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(593, 386);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "修改";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户名";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(360, 303);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 15);
            this.label.TabIndex = 8;
            this.label.Text = "余额";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "信用额度";
            // 
            // BankManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CredittextBox);
            this.Controls.Add(this.LefttextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreditAccountlistView);
            this.Controls.Add(this.AccountlistView);
            this.Name = "BankManager";
            this.Text = "BankManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AccountlistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView CreditAccountlistView;
        private System.Windows.Forms.ColumnHeader CreditNamecolumnHeader;
        private System.Windows.Forms.ColumnHeader CreditMoneycolumnHeader;
        private System.Windows.Forms.ColumnHeader CreditcolumnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox LefttextBox;
        private System.Windows.Forms.TextBox CredittextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
    }
}