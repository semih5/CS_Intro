using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Loan payment planned");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
