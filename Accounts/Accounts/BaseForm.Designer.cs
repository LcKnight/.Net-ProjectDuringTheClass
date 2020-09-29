namespace Accounts
{
    partial class BaseForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ATMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccounttextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Forgetbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ATMToolStripMenuItem,
            this.BankToolStripMenuItem,
            this.AccountToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ATMToolStripMenuItem
            // 
            this.ATMToolStripMenuItem.Font = new System.Drawing.Font("楷体", 16.2F);
            this.ATMToolStripMenuItem.Name = "ATMToolStripMenuItem";
            this.ATMToolStripMenuItem.Size = new System.Drawing.Size(66, 32);
            this.ATMToolStripMenuItem.Text = "ATM";
            this.ATMToolStripMenuItem.Click += new System.EventHandler(this.ATMToolStripMenuItem_Click);
            // 
            // BankToolStripMenuItem
            // 
            this.BankToolStripMenuItem.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BankToolStripMenuItem.Name = "BankToolStripMenuItem";
            this.BankToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.BankToolStripMenuItem.Text = "银行";
            this.BankToolStripMenuItem.Click += new System.EventHandler(this.BankToolStripMenuItem_Click);
            // 
            // AccountToolStripMenuItem
            // 
            this.AccountToolStripMenuItem.Font = new System.Drawing.Font("楷体", 16.2F);
            this.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem";
            this.AccountToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.AccountToolStripMenuItem.Text = "账户";
            this.AccountToolStripMenuItem.Click += new System.EventHandler(this.AccountToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Font = new System.Drawing.Font("楷体", 16.2F);
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.LogoutToolStripMenuItem.Text = "退出";
            this.LogoutToolStripMenuItem.Visible = false;
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // AccounttextBox
            // 
            this.AccounttextBox.Location = new System.Drawing.Point(330, 124);
            this.AccounttextBox.Name = "AccounttextBox";
            this.AccounttextBox.Size = new System.Drawing.Size(100, 25);
            this.AccounttextBox.TabIndex = 1;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(330, 209);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(100, 25);
            this.PasswordtextBox.TabIndex = 2;
            this.PasswordtextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordtextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(228, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(231, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(497, 245);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "登录";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "没有账户吗？\r\n赶紧去银行注册吧";
            // 
            // Forgetbutton
            // 
            this.Forgetbutton.Location = new System.Drawing.Point(632, 245);
            this.Forgetbutton.Name = "Forgetbutton";
            this.Forgetbutton.Size = new System.Drawing.Size(75, 23);
            this.Forgetbutton.TabIndex = 7;
            this.Forgetbutton.Text = "忘记密码";
            this.Forgetbutton.UseVisualStyleBackColor = true;
            this.Forgetbutton.Click += new System.EventHandler(this.Forgetbutton_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Forgetbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.AccounttextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ATMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountToolStripMenuItem;
        private System.Windows.Forms.TextBox AccounttextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Forgetbutton;
        private System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
    }
}

