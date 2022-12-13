using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chapter6
{
    class Account
    {
        private double balance;
        public Account(double initialDeposit) { balance = initialDeposit; }
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            lock (this)
            {
                balance+=amount;
            }
        }
    }
    class Teller
    {
        string name;
        Account account;
        double amount;
        public Teller(string name, Account account, double amount)
        {
            this.name=name;
            this.account=account;
            this.amount=amount;
        }
        public void TellerTask()
        {
            account.Deposit(amount);
            Console.WriteLine(name+" : "+account.Balance);
        }
    }
    internal class ExerciseCH6_14_2
    {
        public static void Main()
        {
            Account bong = new Account(3350000);
            Teller t1 = new Teller("kk", bong, 2100000);
            Teller t2 = new Teller("ff", bong, 350000);
            t1.TellerTask();
            t2.TellerTask();
        }
    }
}
