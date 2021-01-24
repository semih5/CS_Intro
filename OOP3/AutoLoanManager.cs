using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AutoLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Auto Loan payment planned");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
