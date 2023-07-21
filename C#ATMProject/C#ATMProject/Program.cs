using System;
using System.Runtime.CompilerServices;

public class cardHolder //creating a class for our ATM
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;


    public cardHolder(string cardNum,  int pin, String firstName, String lastName, double balance) //constructor for class and variables
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    //creating getters
    public string getNum() 
    {
        return cardNum;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }

    public string getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    //creating setters to change variables for user
    public void setNum (string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String LastName)
    {
        lastName = LastName;
    }
    public void setBalance(double newbalance)
    {
        balance = newbalance;
    }

    public static void main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the follwoing options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        } //initiallizes the program by giving user options, the following functions are options for the user
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much $ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you for your deposit. Your new balance is: " + currentUser.getBalance());

        }
        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw?");
            double withdraw = Double.Parse(Console.ReadLine());
            // Check if user has enough money
               if(currentUser.getBalance() > withdraw)
            {
                Console.WriteLine("Insuffiecient balance for withdraw");
                
            }
               else {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("You're all set! Thank you!");
                    }
        }
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.getBalance());
        }
    }

    List<cardHolder> cardHolders = new List<cardHolder>();
    


}



