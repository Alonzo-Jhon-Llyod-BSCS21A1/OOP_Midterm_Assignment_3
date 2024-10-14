using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1;

public class BankAccount
{
    private int _balance;
    private double _interestRate;

    public BankAccount(int accountNumber, int initialBalance, double interestRate = 0.0)
    {
        _balance = initialBalance;
        _interestRate = interestRate;
    }

    public void Deposit(int amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }
        _balance += amount;
    }

    public void Withdraw(int amount, bool isOtherBank)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }

        var penalty = isOtherBank ? 20 : 0;
        if (amount + penalty > _balance)
        {
            throw new InvalidOperationException("Insufficient funds for this withdrawal");
        }

        _balance -= (amount + penalty);
    }

    public void CalculateInterest()
    {
        var interest = _balance * _interestRate;
        _balance += (int)interest; // Assuming only whole numbers are added
    }

    public int GetBalance()
    {
        return _balance;
    }

   

}



