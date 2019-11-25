using System;
using System.Text;

// Нарушение принципа
namespace BAD
{
    static class Encoder
    {
        public static void Run()
        {
            Console.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(Console.ReadLine())));
        }
    }
}

// Соблюдение принципа
namespace GOOD
{
    public static class GoodEncoder
    {
        public static void Run(IReadable input, IWriteable output)
        {
            output.WriteOutput(Convert.ToBase64String(Encoding.ASCII.GetBytes(input.ReadInput())));
        }
    }

    public interface IReadable
    {
        string ReadInput();
    }

    public interface IWriteable
    {
        void WriteOutput(string txt);
    }

    public class ConsoleReader : IReadable
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }

    public class ConsoleWriter : IWriteable
    {
        public void WriteOutput(string txt)
        {
            Console.WriteLine(txt);
        }
    }

}