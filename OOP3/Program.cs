using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalLoanManager personalLoanManager = new PersonalLoanManager();
            AutoLoanManager autoLoanManager = new AutoLoanManager();
            MortgageManager mortgageManager = new MortgageManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            LoanApplyManager loanApplyManager = new LoanApplyManager();
            loanApplyManager.Apply(mortgageManager, fileLoggerService);

            List<ILoanManager> loans = new List<ILoanManager>() {mortgageManager, autoLoanManager };
            //loanApplyManager.DoLoanPreliminaryInformation(loans);

        }
    }
}
