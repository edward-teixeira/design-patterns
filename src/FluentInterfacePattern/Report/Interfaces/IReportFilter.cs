namespace FluentInterfaceExample.Report.Interfaces;

public interface IReportFilter
{
    IReportExecute ByMinimumThreshold(int threshold);
    IReportExecute ByMaximumThreshold(int threshold);
}
