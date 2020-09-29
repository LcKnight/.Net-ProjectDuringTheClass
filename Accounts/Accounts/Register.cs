using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounts
{
    public partial class Register : Form
    {
        private static Account CurrentAccount;
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int flag = 0;//flag指代是否从现有账户中找到了一样的用户名
            if(Account.BankAccounts.Count>=1)
            {
                foreach (Account ac in Account.BankAccounts)
                {
                    if (ac.BaseAccount == AccounttextBox.Text)
                    {
                        flag = 1;
                        break;
                    }

                }
            }
            if(CreditAccount.CreditAccounts.Count>=1)
            {
                foreach (CreditAccount ca in CreditAccount.CreditAccounts)
                {
                    if (ca.BaseAccount == AccounttextBox.Text)
                    {
                        flag = 1;
                        break;
                    }

                }
            }
            if(flag==1)
            {
                MessageBox.Show("此账号已被注册");

            }
            else
            {
                CurrentAccount = new Account(AccounttextBox.Text, PasswordtextBox.Text);
                MessageBox.Show($"注册成功，id:{CurrentAccount.BaseAccount},pwd:{CurrentAccount.Password}");
                Account.BankAccounts.Add(CurrentAccount);
            }
        }

        private void PasswordtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.RegisterButton_Click(sender, e);//触发button事件
            }
        }
    }
}
