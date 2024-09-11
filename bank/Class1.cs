using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank
{
    public class BankAccount
    {
        int money = 0;
        public void Deposit(int amount)
        {
            money = money + amount;
        }
        public void Withdraw(int amount)
        {
            if (money >= amount)
            {
                money = money - amount;
            }
            else MessageBox.Show("no money");


        }
        public int GetBalance()
        {

            return money;


        }
    }
}
