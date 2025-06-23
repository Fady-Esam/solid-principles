// Violation of ISP: An interface that forces clients to implement methods they don't need
using System;
using System.Drawing;

public interface IPrint
{
    void Print(string content);

}

public interface IScanPrinter
{
    void Scan();

}
public interface IFaxPrinter
{
    void Fax();
}





public class BasicPrinter : IPrint
{
    public void Print(string content)
    {
        Console.WriteLine($"Printing: {content}");
    }
}


public class AdvancedPrinter : IPrint, IScanPrinter, IFaxPrinter
{

    public void Print(string content)
    {
        Console.WriteLine($"Printing: {content}");
    }

    public void Scan()
    {
        Console.WriteLine($"Scanning..");
    }

    public void Fax()
    {
        Console.WriteLine($"Faxing...");
    }
}



public interface ICreditCardPayment
{
    void PayWithCreditCard();
}


public interface IPayPalPayment
{
    void PayWithPayPal();

}

public interface IBitCoinPayment
{
    void PayWithBitcoin();
}



public class CreditCardPayment : ICreditCardPayment
{
    public void PayWithCreditCard()
    {
        Console.WriteLine("Payment with credit card.");
    }
}

public class PayPalPayment : IPayPalPayment
{
    public void PayWithPayPal()
    {
        Console.WriteLine("Payment with PayPal");

    }
}





public class Program
{
    public static void Main()
    {
        CreditCardPayment creditCardPayment = new CreditCardPayment();
        creditCardPayment.PayWithCreditCard();
        // creditCardPayment.PayWithPayPal();
        // creditCardPayment.PayWithBitcoin ();

        PayPalPayment payPalPayment = new PayPalPayment();
        payPalPayment.PayWithPayPal();




        //payPalPayment.PayWithCreditCard();
        // payPalPayment.PayWithBitcoin();
        //BasicPrinter basicPrinter = new BasicPrinter();
        //basicPrinter.Print("Hi, My Name is Fady");

        //AdvancedPrinter advancedPrinter = new AdvancedPrinter();
        //advancedPrinter.Print("Hi, My Name is Fady");
        //advancedPrinter.Scan();
        //advancedPrinter.Fax();

        Console.ReadKey();

    }
}









