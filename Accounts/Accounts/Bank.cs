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
    public partial class Bank : Form
    {
        private Account CurrentAccount;
        private CreditAccount CurrentCreditAccount;
        private Random rd;
        public Bank(Account account)
        {
            this.CurrentAccount = account;
            InitializeComponent();
            Textlabel.Text = ($"{account.BaseAccount}用户");
            LeftLabel.Text = ($"{account.GetMoney()}");
            label1.Hide();
            CreditLabel.Hide();
            rd = new Random();
            //注册Account的事件
            CurrentAccount.BigMoneyFetchedEvent += BigMoneyFetched;
        }
        public Bank(CreditAccount account)
        {
            this.CurrentCreditAccount = account;
            InitializeComponent();
            Textlabel.Text = ($"{account.BaseAccount}用户");
            LeftLabel.Text = ($"{account.GetMoney()}");
            CreditLabel.Text = ($"{account.Credit}");
            rd = new Random();
            //注册CreditAccount的事件
            CurrentCreditAccount.BigMoneyFetchedEvent += BigCreditMoneyFetched;
        }
        //订阅器
        public void BigMoneyFetched(object sender, Account.BigMoneyArgs args)
        {
            Account act = (Account)sender;
            MessageBox.Show($"{act.BaseAccount},您的账号取走了{args.money}");
        }
        //订阅器
        public void BigCreditMoneyFetched(object sender, CreditAccount.BigMoneyArgs args)
        {
            CreditAccount act = (CreditAccount)sender;
            MessageBox.Show($"{act.BaseAccount},您的账号取走了{args.money}");
        }
        private void MoneyFetchbutton_Click(object sender, EventArgs e)
        {
            int money;
            if (Int32.TryParse(FetchMoneytextBox.Text, out money) == true)
            {
                if (CurrentCreditAccount != null)
                {
                    if (CurrentCreditAccount.Fetch(money))
                    {
                        this.LeftLabel.Text = CurrentCreditAccount.GetMoney().ToString();
                        this.CreditLabel.Text = CurrentCreditAccount.Credit.ToString();
                    }
                    else
                    {
                        MessageBox.Show("您的余额不足");
                    }
                }
                else
                {
                    if (CurrentAccount.Fetch(money))
                    {
                        this.LeftLabel.Text = CurrentAccount.GetMoney().ToString();

                    }
                    else
                    {
                        MessageBox.Show("您的余额不足");
                    }
                }
            }
            else
            {
                MessageBox.Show("您的输入不是正确的格式");
            }
        }

        private void MoneyDepositbutton_Click(object sender, EventArgs e)
        {
            int money;
            if (Int32.TryParse(MoneyDeposittextBox.Text, out money) == true)
            {
                if (CurrentCreditAccount != null)
                {
                    CurrentCreditAccount.Deposit(money);
                    this.LeftLabel.Text = CurrentCreditAccount.GetMoney().ToString();
                    this.CreditLabel.Text = CurrentCreditAccount.Credit.ToString();
                }
                else
                {
                    CurrentAccount.Deposit(money);
                    this.LeftLabel.Text = CurrentAccount.GetMoney().ToString();
                }
            }
            else
            {
                MessageBox.Show("您的输入不是正确的格式");
            }
        }

        ~Bank()
        {
            if (CurrentCreditAccount != null)
            {
                foreach (CreditAccount CA in CreditAccount.CreditAccounts)
                {
                    if (CA.BaseAccount == CurrentCreditAccount.BaseAccount)
                    {
                        CA.Credit = CurrentCreditAccount.Credit;
                        CA.SetMoney(CurrentCreditAccount.GetMoney());
                        break;
                    }

                }
            }
            else
            {
                foreach (Account CA in Account.BankAccounts)
                {
                    if (CA.BaseAccount == CurrentAccount.BaseAccount)
                    {

                        CA.SetMoney(CurrentCreditAccount.GetMoney());
                        break;
                    }

                }
            }
        }
    }
}
