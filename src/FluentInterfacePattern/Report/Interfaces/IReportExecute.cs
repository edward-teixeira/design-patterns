namespace FluentInterfaceExample.Report.Interfaces;

public interface IReportExecute
{
    object Generate();
    Task<object> GenerateAsync();
}
