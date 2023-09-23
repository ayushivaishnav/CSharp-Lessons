using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace program1.Practice
{
    class Bank
    {
        public int Id;
        public string name;
        public string Address;
    }
    class Branch
    {
        public int BranchId;
        public string BranchName;
        public string BranchAddress;
        public string BranchCity;
        public string BranchZipCode;

        List<Customer> CustomerList = new List<Customer>();

        public Branch(int bankid, int branchid)
        {
            //BankId=bankid; 
            BranchId = branchid;

        }

    }

    class Customer
    {
        public readonly int Id;


    }
    public enum AccountType
    {

    }
    class Account
    {
        public readonly long AccountNumber;
        public readonly int CustomerId;
        public AccountType TypeOfAccount;
        public const float MIN_Balance = 2000f;
        public const float MAX_Balance = 2000000f;
        private float currentBalance = 0;

        public float CurrentBalance
        {
            get=> currentBalance;
            set
            {
                if((CurrentBalance-value)<1)
                {
                    throw new Exception("Insufficient Balance");
                }
                if((currentBalance+value)>MAX_Balance)
                {
                    throw new Exception("Very large Balance");
                }
                currentBalance = value;
            }
        }
        public enum MessagePriority
        {
          Normal=0,
          Urgent=1,
          Low=2,
          High=3

        }
        class Message
        {
            public string To = string.Empty;
            public string From = string.Empty;
            public string Subject = string.Empty;
            public string Body = string.Empty;
            public string Attachment = string.Empty;

        }
        class AccountController
        {
            private readonly Account account;
            //public AccountController(Account account)
            //{
            //    this.account=Account;

            //}

            public void DoWithdral(int accountno, float amount)
            {
                if(accountno==0)
                {
                    throw new Exception("Amount must be greater than 0");
                }
                if(amount<50)
                {
                    throw new Exception("Amount to withdraw must be >50");
                }
                if(account==null)
                {
                    throw new Exception("Account not found");
                }
                try
                {
                    account.currentBalance -= amount;
                    Console.WriteLine($"withdraw successful your balance{account.currentBalance}");
                }
                catch (Exception e)
                {
                    throw new Exception($"ERROR!!! - {e.Message}");
                }
            }


            //public void DoDepositl(int accountno, float amount)
            //{
            //    if (accountno == 0)
            //    {
            //        throw new Exception("Amount must be > than 0");
            //    }
            //    if (amount < 50)
            //    {
            //        throw new Exception("Amount to withdraw must be >50");
            //    }
            //    if (account == null)
            //    {
            //        throw new Exception("Account not found");
            //    }
            //    try
            //    {
            //        account.currentBalance -= amount;
            //        Console.WriteLine($"Deposited successful your balance{account.currentBalance}");
            //    }
            //    catch (Exception e)
            //    {
            //        throw new Exception($"ERROR!!! - {e.Message}");
            //    }
            //}
        }
         interface IMessageCreater
        {
            void SendSMS(long phoneNo, string msg);
            void SendEmail(string emailAddress, string msg);
            void RecieveEmai(string msg);
            void RecieveEmail( string msg);

        }
        class MessageControler : IMessageCreater
        {
            public void RecieveEmai(string msg)
            {
                throw new NotImplementedException();
            }

            public void RecieveEmail(string msg)
            {
                throw new NotImplementedException();
            }

            public void SendEmail(string emailAddress, string msg)
            {
                throw new NotImplementedException();
            }

            public void SendSMS(long phoneNo, string msg)
            {
                throw new NotImplementedException();
            }
        }

    }
}
