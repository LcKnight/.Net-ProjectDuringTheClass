using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//本页面中需要写一些tryparse 但是我已经累了=。=
//希望不知道是谁看到了 也给个机会 别喷我
namespace Accounts
{
    public partial class BankManager : Form
    {
        enum Flag { Account,CreditAccount };
        private static Flag flag;
        private Account BankAccount;
        private CreditAccount BankCreditAccount;
        public BankManager()
        {
            InitializeComponent();
            FillAccountlistView();
            FillCreditAccountlistView();
        }

        public void FillAccountlistView()
        {
            AccountlistView.Items.Clear();
            if (Account.BankAccounts.Count>0)
            {
                foreach (Account act in Account.BankAccounts)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = act.BaseAccount;
                    lvi.SubItems.Add($"{act.GetMoney()}");
                    this.AccountlistView.Items.Add(lvi);
                }
            }
        }
        public void FillCreditAccountlistView()
        {
            CreditAccountlistView.Items.Clear();
            if (CreditAccount.CreditAccounts.Count>0)
            {
                foreach (CreditAccount act in CreditAccount.CreditAccounts)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = act.BaseAccount;
                    lvi.SubItems.Add($"{act.GetMoney()}");
                    lvi.SubItems.Add($"{act.Credit}");
                    this.CreditAccountlistView.Items.Add(lvi);
                }
            }
        }
        private void AccountlistView_Click(object sender, EventArgs e)
        {
            int selectCount = AccountlistView.SelectedItems.Count; //SelectedItems.Count就是：取得值，表示SelectedItems集合的物件数目。 
            if (selectCount > 0)//若selectCount大於0，说明用户有选中某列。
            {
                NametextBox.Text = AccountlistView.SelectedItems[0].SubItems[0].Text;
                LefttextBox.Text = AccountlistView.SelectedItems[0].SubItems[1].Text;
                flag = Flag.Account;//说明目前选中的是Account
            }
        }

        private void CreditAccountlistView_Click(object sender, EventArgs e)
        {
            int selectCount = CreditAccountlistView.SelectedItems.Count; //SelectedItems.Count就是：取得值，表示SelectedItems集合的物件数目。 
            if (selectCount > 0)//若selectCount大於0，说明用户有选中某列。
            {
                NametextBox.Text = CreditAccountlistView.SelectedItems[0].SubItems[0].Text;
                LefttextBox.Text = CreditAccountlistView.SelectedItems[0].SubItems[1].Text;
                CredittextBox.Text= CreditAccountlistView.SelectedItems[0].SubItems[2].Text;
                flag = Flag.CreditAccount;//说明目前选中的是CreditAccount
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(flag==Flag.Account)
            {
                if(CredittextBox.Text!="" && CredittextBox.Text!="0")
                {
                    foreach(Account account in Account.BankAccounts)
                    {
                        if(account.BaseAccount==NametextBox.Text)
                        {
                            this.BankAccount = account;
                            CreditAccount CA = new CreditAccount(account.BaseAccount,account.Password, Int32.Parse(CredittextBox.Text));
                            CA.SetMoney(Int32.Parse(LefttextBox.Text));
                            CreditAccount.CreditAccounts.Add(CA);
                            
                        }
                    }
                    Account.BankAccounts.Remove(BankAccount);
                }
                else
                {
                    foreach (Account account in Account.BankAccounts)
                    {
                        if (account.BaseAccount == NametextBox.Text)
                        {
                            this.BankAccount = account;

                            account.SetMoney(Int32.Parse(LefttextBox.Text));
                           

                        }
                    }
                }
            }
            else if(flag==Flag.CreditAccount)
            {
                foreach (CreditAccount account in CreditAccount.CreditAccounts)
                {
                    if (account.BaseAccount == NametextBox.Text)
                    {
                        this.BankCreditAccount = account;
                        account.SetMoney(Int32.Parse(LefttextBox.Text));
                        account.Credit = Int32.Parse(CredittextBox.Text);

                    }
                }
                Account.BankAccounts.Remove(BankAccount);
            }
            else
            {
                MessageBox.Show("请选中ListView中的一个项，单击即可");
            }


            //重启本视图，将更新后的Account和CreditAccount更新到视图中
            FillAccountlistView();
            FillCreditAccountlistView();
            this.NametextBox.Text = "";
            this.LefttextBox.Text = "";
            this.CredittextBox.Text = "";
        }
    }
}
