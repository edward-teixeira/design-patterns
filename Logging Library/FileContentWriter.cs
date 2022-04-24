using System.Text;

namespace Logging_Library;

public class FileContentWriter :
    BaseContentWriter
{
    private readonly string _fileName;

    public FileContentWriter(string name)
    {
        _fileName = name;
    }

    protected override bool WriteToMedia(string content)
    {
        using var sourceStream = File.Open(_fileName, FileMode.Append);
        var buffer = Encoding.UTF8.GetBytes(content + "\r\n");
        sourceStream.Write(buffer, 0, buffer.Length);
        return true;
    }
}
