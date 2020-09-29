using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
   public class Account
    {
        public static List<Account> BankAccounts=new List<Account>();
        private string baseAccount;
        private string password;
        protected int Money { get; set; }
        
        public delegate void BigMoneyFetchedEventHandler(object sender, BigMoneyArgs e);
        public class BigMoneyArgs:EventArgs
        {
            //有一说一 这里题目要求把账号类也放在arg有些离谱，这明明是sender
            //这样导致派生类中这些委托方法的编写需要new？
            //因为类型参数变化了，但是如果放在sender中就只需要写this
            public Account account;
            public readonly int money;
            public BigMoneyArgs(int money,Account account)
            {
                this.account = account;
                this.money = money;
            }
        }
        public event BigMoneyFetchedEventHandler BigMoneyFetchedEvent;

        public string BaseAccount
        {
            get { return baseAccount; }
            set
            {
                this.baseAccount = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                this.password = value;
            }
        }
        //此处设计不合理，protected意义失去了，但是没找到合适的替代品
        public int GetMoney()
        {
            return this.Money;
        }
        public void SetMoney(int money)
        {
            this.Money = money;
        }
        public Account(string baseAccount,string password)
        {
            this.BaseAccount = baseAccount;
            this.Password = password;
            this.Money = 0;
        }
        public Account(Account act)
        {
            this.BaseAccount = act.BaseAccount;
            this.Password = act.BaseAccount;
            this.Money = act.Money;
        }
        public virtual bool Fetch(int money)
        {
            if (money <= Money)
            {
                this.Money -= money;
                if(money>10000)
                {
                    if(BigMoneyFetchedEvent!=null)
                    {
                        
                        BigMoneyArgs args = new BigMoneyArgs(money,this);
                        BigMoneyFetchedEvent(this, args);
                    }
                }
                return true;
                
            }
            else
                return false;

        }
        public virtual void Deposit(int money)
        {
            this.Money += money;

        }
    }
}
