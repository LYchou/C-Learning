using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp8_BorrowAndRepay_project
{
    class Person
    {
        public string Name;
        public int Money;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public void borrow(Person lender, int money)
        {
            if (lender.Money >= money)
            {
                Money += money;
                lender.Money -= money;
            }
        }

        public void repay(Person lender, int money)
        {
            Money -= money;
            lender.Money += money;
        }

    }
}
