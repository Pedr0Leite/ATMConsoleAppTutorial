using System;

public class cardHolder
{
    String cardnum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardnum, int pin, string firstName, string lastName, double balance)
    {
        this.cardnum = cardnum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum() { 
        return cardnum;
    }

    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }
    public double getBalance()
    {
        return balance;

    }

    public void setNum(String newCardNum)
    {
        cardnum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName) { 
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + currentUser.getBalance());
            Console.WriteLine($"Thank you for your deposit. Your new balance is: {currentUser.getBalance()}");

        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawal = Double.Parse(Console.ReadLine());

            if(currentUser.getBalance() < withdrawal) 
            {
            Console.WriteLine("Insuficient Funds....");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("You're good to go! Have a nice day!");

            }
        }

        void balance(cardHolder currentUser) 
        {
        Console.WriteLine($"Current balance: {currentUser.getBalance()} Euro.");
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1", 1234, "John", "Doe", 1233.12));
        cardHolders.Add(new cardHolder("2", 4534, "Ash", "Griffin", 13423.52));
        cardHolders.Add(new cardHolder("3", 7834, "Alex", "Plain", 128953.21));
        cardHolders.Add(new cardHolder("4", 1213, "Roger", "Powers", 3212.15));
        
        //Prompt user
        Console.WriteLine("Welcome to ATM Basic App");
        Console.WriteLine("Please insert your debit card: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardnum == debitCardNum);
                if (currentUser != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Card not recognized in the System. Please try again or contact our support team.");

                }
            }
            catch
            {
                Console.WriteLine("Card not recognized in the System. Please try again or contact our support team.");

            }
        }

            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;
            while (true)
            {

            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin){ break; }
                else
                {
                    Console.WriteLine("Incorrect pin. Please try again.");

                }
            }
            catch
            {
                    Console.WriteLine("Incorrect pin. Please try again.");
            }
        }
        Console.WriteLine($"Welcome {currentUser.getFirstName()}");
        int option = 0;
        do
        {
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {

            }


            if (option == 1)
            {
                deposit(currentUser);
            }
            else if (option == 2)
            {
                withdraw(currentUser);
            }
            else if (option == 3)
            {
                balance(currentUser);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                option = 0;
            }
        } while (option != 4);
        Console.WriteLine("Thank you, have a nice day!");
     }
}