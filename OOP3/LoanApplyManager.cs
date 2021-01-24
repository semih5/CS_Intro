using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class LoanApplyManager
    {
        public void Apply(ILoanManager loanManager, ILoggerService loggerService)
        {
            loanManager.Calculate();
            loggerService.Log();


        }
        public void DoLoanPreliminaryInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
