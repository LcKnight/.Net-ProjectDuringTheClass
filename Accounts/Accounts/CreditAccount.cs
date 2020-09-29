using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class CreditAccount : Account
    {
        public static List<CreditAccount> CreditAccounts = new List<CreditAccount>();
        private int credit;
        public int Credit
        {
            get { return credit; }
            set
            {
                this.credit = value;
            }
        }

        public CreditAccount(string baseAccount,string password,int credit):base(baseAccount,password)
        {
            
            this.Credit = credit;
        }
        public new delegate void BigMoneyFetchedEventHandler(object sender, BigMoneyArgs e);
        //有一说一 这里题目要求把账号类也放在arg里面就离谱，这明明是sender
        //这样导致派生类中这些委托方法的编写需要new？
        //因为类型参数变化了，但是如果放在sender中就只需要写this
        public new class BigMoneyArgs : EventArgs
        {
            public Account account;
            public readonly int money;
            public BigMoneyArgs(int money, CreditAccount account)
            {
                this.account = account;
                this.money = money;
            }
        }
        public new event BigMoneyFetchedEventHandler BigMoneyFetchedEvent;
        public override bool Fetch(int money)
        {
            if (money <= Money+Credit)
            {
                if(money>10000)
                {
                    if(BigMoneyFetchedEvent != null)
                    {
                        
                        BigMoneyFetchedEvent(this,new BigMoneyArgs(money, this));
                    }
                }
                if(this.Money<money)
                {
                    this.Money = 0;
                    this.Credit -= money - Money;
                    return true;
                }
                else
                {
                    this.Money -= money;
                    return true;
                }
            }
            else
                return false;
        }
    }
}
