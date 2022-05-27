namespace FluentInterfaceExample.BlobTransfer.Interfaces;

public interface IAzureRead
{
    void FromFile(string filePath);
    Task FromFileAsync(string filePath);
    void FromStream(Stream stream);
    Task FromStreamAsync(Stream stream);
}
