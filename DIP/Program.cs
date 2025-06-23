
// High Level Modules should not depend on Low Level Modules, Both Should Depend on Abstraction


using System;

public interface IReportGenerator
{
    void Generate();
}



class PDFReportGenerator : IReportGenerator
{
    public void Generate()
    {
        Console.WriteLine("pdf Report Generate (-");
    }
}
class ExcelReportGenerator : IReportGenerator 
{
    public void Generate()
    {
        Console.WriteLine("Excel Report Generate (-");
    }
}

class ReportGenerator
{
    private IReportGenerator _IReportGenerator;
    public ReportGenerator(IReportGenerator IReportGenerator)
    {
        _IReportGenerator = IReportGenerator;
    }
    public void Generate()
    {
        _IReportGenerator.Generate();
    }
}


class Program
{
    static void Main(string[] args)
    {
        ReportGenerator reportGenerator = new ReportGenerator(new ExcelReportGenerator()); // Dependency Injection
        reportGenerator.Generate();
        Console.ReadKey();
    }
}

