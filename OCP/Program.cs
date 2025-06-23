using System;


// OCP => Open For Extension Closed For Modification


public class NotificationService
{
    private readonly INotification _INotification;
    public NotificationService(INotification INotification)
    {
        _INotification = INotification;
    }
    public void SendNotification(string to, string message)
    {
        _INotification.Send(to, message);
    }
}


public interface INotification
{
    void Send(string to, string message);
}


public class FaxService : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}


public class SMSService : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }

}

public class EmailService : INotification
{
    public  void Send(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }
}


public class WhatsApp : INotification
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"\nSending WhatsApp Message to {to}: {message}");
    }
}







public class User
{
    private readonly IUser _IUser;
    public User(IUser IUser)
    {
        _IUser = IUser;
    }

    public void GetUserType()
    {
        _IUser.GetUserType();
    }
}


public interface IUser
{
    void GetUserType();
}


public class Admin : IUser
{
    public void GetUserType()
    {
        Console.WriteLine("I am Admin");
    }
}

public class Customer : IUser
{
    public void GetUserType()
    {
        Console.WriteLine("I am Customer");

    }
}

public class PaymentService
{
    private readonly IPayment _IPayment;
    public PaymentService(IPayment iPayment)
    {
        _IPayment = iPayment;
    }

    public void ApplyPaymentService()
    {
        _IPayment.ApplyPaymentService();
    }
}


public interface IPayment
{
    void ApplyPaymentService();
}


public class PayPal : IPayment
{
    public void ApplyPaymentService()
    {
        Console.WriteLine("Pay With PayPal");
    }
}
public class CreditCard : IPayment
{
    public void ApplyPaymentService()
    {
        Console.WriteLine("Pay With Credit Card");

    }
}
public class BankTransfer : IPayment
{
    public void ApplyPaymentService()
    {
        Console.WriteLine("Pay With Bank Transfer");
    }
}
public class Bitcoin : IPayment
{
    public void ApplyPaymentService()
    {
        Console.WriteLine("Pay With Bitcoin");
    }
}




class Program
{
    static void Main()
    {
        PaymentService PayPalSerivce = new PaymentService(new PayPal());
        PayPalSerivce.ApplyPaymentService();
        PaymentService CreditCardSerivce = new PaymentService(new CreditCard());
        CreditCardSerivce.ApplyPaymentService();
        PaymentService BankTransferSerivce = new PaymentService(new BankTransfer());
        BankTransferSerivce.ApplyPaymentService();
        PaymentService BitcoinSerivce = new PaymentService(new Bitcoin());
        BitcoinSerivce.ApplyPaymentService();

        //User Admin = new User(new Admin());
        //Admin.GetUserType();
        //User Customer = new User(new Customer());
        //Customer.GetUserType();

        // Create an instance of the NotificationService

        //NotificationService FaxService = new NotificationService(new FaxService());
        //FaxService.SendNotification("123-456-789", "Fax Message: Important document.");

        //NotificationService EmailService = new NotificationService(new EmailService());
        //EmailService.SendNotification("john@example.com", "Welcome to our service!");

        //NotificationService SMSService = new NotificationService(new SMSService());
        //SMSService.SendNotification("+123456789", "Your OTP code is 1234.");

        //NotificationService WhatsAppService = new NotificationService(new SMSService());
        //WhatsAppService.SendNotification("+123456789", "Welcome To WhatsApp");
        Console.ReadKey();

    }
}
