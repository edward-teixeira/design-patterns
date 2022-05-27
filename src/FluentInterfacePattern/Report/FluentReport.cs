using FluentInterfaceExample.Report.Enums;
using FluentInterfaceExample.Report.Interfaces;

namespace FluentInterfaceExample.Report;

public class FluentReport : IReportContent, IReportFilter, IReportExecute
{
    private readonly ReportType type;
    private List<int> reportItems;

    private FluentReport(ReportType type)
    {
        this.type = type;
    }

    public IReportFilter WithFilteredItems(List<int> items)
    {
        reportItems = items;

        return this;
    }

    public IReportExecute WithItems(List<int> items)
    {
        reportItems = items;

        return this;
    }

    public object Generate()
    {
        // Code to generate report

        return default;
    }

    public async Task<object> GenerateAsync()
    {
        // Code to generate async report

        return default;
    }

    public IReportExecute ByMinimumThreshold(int threshold)
    {
        reportItems = reportItems
            .Where(item => item > threshold)
            .ToList();

        return this;
    }

    public IReportExecute ByMaximumThreshold(int threshold)
    {
        reportItems = reportItems
            .Where(item => item < threshold)
            .ToList();

        return this;
    }

    public static IReportContent Pdf()
    {
        return new FluentReport(ReportType.Pdf);
    }

    public static IReportContent Xml()
    {
        return new FluentReport(ReportType.Xml);
    }

    public static IReportContent Doc()
    {
        return new FluentReport(ReportType.Doc);
    }
}
