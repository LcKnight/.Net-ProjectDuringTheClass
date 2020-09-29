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
    public partial class BaseForm : Form
    {
        enum State
        {
            UnLogined,Logined,Rooted
        }
        private static State state=0;
        private static Account CurrentAccount;
        private static CreditAccount CurrentCreditAccount;
        public BaseForm()
        {
            InitializeComponent();
            //this.LogoutToolStripMenuItem.Visible = false;

        }
        public void TextBoxFixed()
        {
            this.AccounttextBox.Enabled = false;
            this.PasswordtextBox.Enabled = false;
        }
        public void TextBoxThaw()
        {
            this.AccounttextBox.Enabled = true;
            this.PasswordtextBox.Enabled = true;
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (this.AccounttextBox.Text == "root" && this.PasswordtextBox.Text == "123456")
            {
                state = State.Rooted;
                MessageBox.Show("管理员登录成功,点击银行查看用户信息");
                TextBoxFixed();
                this.LogoutToolStripMenuItem.Visible = true;
            }
            else
            {
                int flag = 0;//表示账号列表中是否有当前账号
                foreach (Account act in Account.BankAccounts)
                {
                    if (act.BaseAccount == this.AccounttextBox.Text)
                    {
                        flag = 1;
                        if (act.Password != this.PasswordtextBox.Text)
                        {
                            MessageBox.Show("您输入的密码有误");
                        }
                        else
                        {
                            state = State.Logined;
                            CurrentAccount = act;
                            MessageBox.Show("登陆成功,请使用菜单栏中按钮");
                            TextBoxFixed();
                            this.LogoutToolStripMenuItem.Visible = true;


                        }

                    }
                    
                }

                if (flag == 0)
                {
                    foreach (CreditAccount CA in CreditAccount.CreditAccounts)
                    {
                        if (CA.BaseAccount == this.AccounttextBox.Text)
                        {
                            flag = 1;
                            if (CA.Password != this.PasswordtextBox.Text)
                            {
                                MessageBox.Show("您输入的密码有误");
                            }
                            else
                            {
                                state = State.Logined;
                                CurrentCreditAccount = CA;
                                MessageBox.Show("登陆成功,请使用菜单栏中按钮");
                                TextBoxFixed();
                                this.LogoutToolStripMenuItem.Visible = true;


                            }
                        }
                    }
                }
                if(flag==0)
                {
                    MessageBox.Show("您输入的账号不存在");
                }
            }
        }

        private void Forgetbutton_Click(object sender, EventArgs e)
        {

        }

        private void ATMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (state == State.UnLogined)
            {
                Register form1 = new Register();
                form1.Show();
            }
            if (state == State.Rooted)
            {
                MessageBox.Show("您当前为管理员账号，不可查看ATM，请切换用户账号");
            }
            else if (state == State.Logined)
            {
                
                if (CurrentCreditAccount!=null)
                {
                   ATM form1 = new ATM(CurrentCreditAccount);
                    form1.Show();
                }
                else if(CurrentAccount!=null)
                {
                    ATM form1 = new ATM(CurrentAccount);
                    form1.Show();
                }
                
            }
        }

        private void BankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(state==State.UnLogined)
            {
                Register form1 = new Register();
                form1.Show();
            }
            if(state==State.Rooted)
            {
                BankManager form1 = new BankManager();
                form1.Show();
            }
            else if(state==State.Logined)
            {
                if (CurrentCreditAccount != null)
                {
                    Bank form1 = new Bank(CurrentCreditAccount);
                    form1.Show();
                }
                else if (CurrentAccount != null)
                {
                    Bank form1 = new Bank(CurrentAccount);
                    form1.Show();
                }
            }
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PasswordtextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                this.Loginbutton_Click(sender, e);//触发button事件
            }
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = State.UnLogined;
            CurrentAccount = null;
            CurrentCreditAccount = null;
            TextBoxThaw();
            this.AccounttextBox.Clear();
            this.PasswordtextBox.Clear();
            this.LogoutToolStripMenuItem.Visible = false;
        }
    }
}
