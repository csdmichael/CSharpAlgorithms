using System;
using System.IO;
using System.Text;

public class DecoratorStream : Stream
{
    private Stream stream;
    private string prefix;

    public override bool CanSeek { get { return false; } }
    public override bool CanWrite { get { return true; } }
    public override long Length { get; }
    public override long Position { get; set; }
    public override bool CanRead { get { return false; } }

    public DecoratorStream(Stream stream, string prefix) : base()
    {
        this.stream = stream;
        this.prefix = prefix;
    }

    public override void SetLength(long length)
    {
        this.stream.SetLength(length);
    }

    public override void Write(byte[] bytes, int offset, int count)
    {
        byte[] prefixBytes = System.Text.Encoding.UTF8.GetBytes(this.prefix);

        this.stream.SetLength(prefixBytes.Length + bytes.Length);
        byte[] combined = new byte[this.stream.Length];

        System.Buffer.BlockCopy(prefixBytes, 0, combined, 0, prefixBytes.Length);
        System.Buffer.BlockCopy(bytes, 0, combined, prefixBytes.Length, bytes.Length);

        this.stream.Write(combined, offset, prefixBytes.Length + bytes.Length);
    }

    public override int Read(byte[] bytes, int offset, int count)
    {
        return this.stream.Read(bytes, offset, count);
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        return this.stream.Seek(offset, origin);
    }

    public override void Flush()
    {
        stream.Flush();
    }

    /*
    public static void Main(string[] args)
    {

        byte[] message = new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x2c, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21 };
        using (MemoryStream stream = new MemoryStream())
        {
            using (DecoratorStream decoratorStream = new DecoratorStream(stream, "First line: "))
            {
                decoratorStream.Write(message, 0, message.Length);
                stream.Position = 0;
                Console.WriteLine(new StreamReader(stream).ReadLine());  //should print "First line: Hello, world!"
                Console.ReadLine();
            }
        }
    }
    */
}