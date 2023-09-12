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
}