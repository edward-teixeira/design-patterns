namespace FluentInterfaceExample.BlobTransfer.Interfaces;

public interface IAzureBlob
{
    IAzureAction OnBlob(string blobBlockPath);
}
