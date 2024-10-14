using System;
namespace ClassLibrary1;

public class Order
{
    public string OrderId { get; set; }
    // Additional properties for Order can be added here
}

public class Customer
{
    public List<Order> Orders { get; private set; } = new List<Order>();

    public void AddOrder(Order order)
    {
        Orders.Add(order);
    }

    public List<Order> GetOrders()
    {
        return Orders;
    }
}
public class EmailSender
{
    public bool SendEmail(string message)
    {
        // Logic to send an email
        // Here we'll just simulate sending an email
        Console.WriteLine($"Email sent with message: {message}");
        return true; // Indicate that the email was sent successfully
    }
}

public class OrderProcessor
{
    private readonly EmailSender _emailSender;

    public OrderProcessor(EmailSender emailSender)
    {
        _emailSender = emailSender;
    }

    public bool ProcessOrder(Order order)
    {
        // Logic to process the order
        // For this example, we'll simulate order processing and sending an email
        string emailMessage = $"Order processed for {order}"; // Customize this message as needed
        return _emailSender.SendEmail(emailMessage);
    }
}


