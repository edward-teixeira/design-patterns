namespace FluentInterfaceExample.Report.Interfaces;

public interface IReportContent
{
    IReportFilter WithFilteredItems(List<int> items);
    IReportExecute WithItems(List<int> items);
}
