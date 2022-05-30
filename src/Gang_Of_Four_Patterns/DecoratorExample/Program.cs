// See https://aka.ms/new-console-template for more information
using DecoratorExample;

DataSource source = new FileDataSource("myfile.txt");
source.Write("The target file has been written with plain data.");

source = new CompressionDecorator(source);
source.Write("The target file has been written with compressed data.");
source = new EncryptionDecorator(source);
// The source variable now contains this:
// Encryption > Compression > FileDataSource
source.Write("The file has been written with compressed and encrypted data");

// Read -> Decompress -> Decrypt
source.Read();

Console.ReadKey();
