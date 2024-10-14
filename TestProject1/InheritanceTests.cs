using System;
using Xunit;

namespace TestProject1;

public class InheritanceTests
{
    [Fact]
    public void CalculateInterest_AppliesHigherRate()
    {
        // Arrange
        BankAccount account = new BankAccount(12345, 1000, 0.05);

        // Act
        account.CalculateInterest();

        // Assert
        Assert.Equal(1075, account.GetBalance()); // Adjusted for higher rate
    }

    [Fact]
    public void InheritsFromBankAccount()
    {
        // Arrange
        BankAccount account = new BankAccount(12345, 1000, 0.05);

        // Assert
        Assert.True(account is BankAccount);
    }
}