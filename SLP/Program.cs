using System;


public class NotificationService
{
    public enum enNotificationType { Email, SMS, Fax }

    public void SendNotification(string to, string message, enNotificationType enValue)
    {
        switch (enValue)
        {
            case enNotificationType.Fax:
                FaxService.SendFax(to, message);
                break;
            case enNotificationType.SMS:
                SMSService.SendSMS(to, message);
                break;
            case enNotificationType.Email:
                EmailService.SendEmail(to, message);
                break;
        }
    }
}


public class FaxService
{
    public static void SendFax(string to, string message)
    {
        Console.WriteLine($"\nSending Fax to {to}: {message}");
    }
}


public class SMSService
{
    public static void SendSMS(string to, string message)
    {
        Console.WriteLine($"\nSending SMS to {to}: {message}");
    }

}

public class EmailService
{
    public static void SendEmail(string to, string message)
    {
        Console.WriteLine($"\nSending Email to {to}: {message}");
    }
}



class Program
{
    static void Main()
    {
        // Create an instance of the NotificationService

        NotificationService notificationService = new NotificationService();
        notificationService.SendNotification("john@example.com", "Welcome to our service!", NotificationService.enNotificationType.Email);
        notificationService.SendNotification("+123456789", "Your OTP code is 1234.", NotificationService.enNotificationType.SMS);
        notificationService.SendNotification("123-456-789", "Fax Message: Important document.", NotificationService.enNotificationType.Fax);

        Console.ReadKey();

    }
}
