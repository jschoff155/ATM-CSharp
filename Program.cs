// See https://aka.ms/new-console-template for more information

public class cardHolder
{
    String cardNumber;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNumber, int pin, string firstName, string lastName, double balance)
    {
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum()
    {
        return cardNumber;
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
        cardNumber = newCardNum;
    }
    public void setPin(int newPin)
    {
        pin = newPin;
    }
    public void setFirstName(String newFirstName)
    {
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
            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
            Console.Clear();
            Console.WriteLine("Please choose from the following:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }
        
        
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("Please enter deposit amount.");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for choosing Capital Credit Company. New current balance is: " + currentUser.getBalance());
            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("Please enter withdrawal amount: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            if (currentUser.balance < withdrawal)
            {
                Console.WriteLine("Insufficient funds. Please enter an alternative amount");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Your new balance is " + currentUser.balance);
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List <cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1245124875631524", 1794, "Michael", "Douglas", 110148.22));
        cardHolders.Add(new cardHolder("8975127963581278", 1875, "David", "Denver", 101.88));
        cardHolders.Add(new cardHolder("1345278120689468", 8034, "Taylor", "Swift", 15879112.80));
        cardHolders.Add(new cardHolder("9812576380140058", 8849, "David", "McDunnuh", .88));
        cardHolders.Add(new cardHolder("6425138790395154", 9913, "Robert", "Baratheon", 124892));
        cardHolders.Add(new cardHolder("9421308719123814", 8888, "Tywin", "Lanister", 9785213549));
        cardHolders.Add(new cardHolder("1487239248921684", 8134, "Henry", "Tudor", 17842));
        cardHolders.Add(new cardHolder("1234123412341234", 1234, "Tester", "Tester", 1000));

        Console.WriteLine("Welcome to Capital Credit Company.");
        Console.WriteLine("Please enter card number: ");
        String debitCardNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card number not recognized. Please try again"); }
            }
            catch { Console.WriteLine("Card number not recognized. Please try again"); } 
        }
            
        Console.WriteLine("Please enter your PIN: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect PIN. Please try again"); }
            }
            catch
            {
                { Console.WriteLine("Incorrect PIN. Please try again"); }
            }
        }
            

        Console.WriteLine("Welcome " + currentUser.getFirstName() + ".");
        Console.WriteLine("What can we do for you today?");
        int option = 0;
        do
        {
            printOptions();
            {
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { deposit(currentUser); }
                else if (option == 2) { withdraw(currentUser); }
                else if (option == 3) { balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }
            }
        }
        while (option != 4);
        {
            Console.WriteLine("Thank you for Capital Credit Company. Have a great day!");
        }


        }


}

