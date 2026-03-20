// Smart ATM – Console Application

int pin = 1234;
int amount = 30000;
string Acctname = "Raj";

int[] amountwithdraw = {2000,500,1000,5000};

for (int a = 1; a <= 5; a++)
{
    {
        Console.WriteLine("Pls enter your pin");
        int pinentry = int.Parse(Console.ReadLine());

       
            
        if (pinentry == pin)
            for (int i = 0; i < 3; i++)
            {
                {
                    Console.WriteLine(
                        "Menu Options\n(1) Press 1 for Deposit \n (2) Press 2 for Withdraw \n (3) Press 3 To Check Balance \n (4) Press 4 to Exit");


                    int MenuOptions = int.Parse(Console.ReadLine());

                    switch (MenuOptions)
                    {
                                             case 1:
                                                 Console.WriteLine("Input Amount To Deposite \n ");
                                                 int DepositeAmount = int.Parse(Console.ReadLine());
                                                 amount += DepositeAmount;
                                                 if (DepositeAmount > 0)
                                                 {
                                                     Console.WriteLine(
                                                         $"////Deposite Alert///\n Hi {Acctname}, Transaction Succesful.\n TrasactionType = Credit.\n Amount-Deposited = {DepositeAmount}. \n Balance = {amount}.\n Thank you for banking with us.");
                                                 }
                                                 else
                                                 {
                                                     Console.WriteLine("Invalid Transaction");
                                                 }
                     
                                                 break;
                     
                                             case 2:
                                                 for (int j = 1; j <= 3; j++)
                                                 {
                     
                                                     Console.WriteLine("Input Amount To Withdraw \n ");
                                                     int WithdrawAmount = int.Parse(Console.ReadLine());
                                                     amount -= WithdrawAmount;
                     
                                                     if (((amount + WithdrawAmount) > WithdrawAmount) && (WithdrawAmount > 0 ))
                                                         
                                                     { Console.WriteLine($"////Withdraw Alert///\n Hi {Acctname}, Transaction Succesful.\n TrasactionType = Debit.\n Amount-Withdrawn = {WithdrawAmount}. \n Balance = {amount}.\n Thank you for banking with us.");
                                                     }
                                                     else
                                                     {
                                                         Console.WriteLine("Insufficient balance! Try again");
                                                     }
                                                 }
                     
                                                 break;
                                             case 3:
                                                 Console.WriteLine($" Hello {Acctname}, Your Account Balance is {amount} \n ");
                                                 break;
                                             case 4:
                                                 Console.WriteLine("thanks for banking with us");
                                                 break;
                                             case 999:
                                                 Console.WriteLine("Total Deposits: 500\n Total Withdrawals: 300\n Number of Transactions: 2");
                                            break;   
                                         }

                    
                }
            }
        else
        {
            Console.WriteLine("//////////////////\n Invalid Pin");
        }
    }

}


//Console.WriteLine("Enter your account type\n(1) Press 1 Deposit \n (2) Press 2 for Withdraw");