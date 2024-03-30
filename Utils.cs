using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public static class Utils
    {
        public static int Id { get; set; }

        public static int GenerateId(int defaultId = 1)
        {
            Id += defaultId;
            return Id;
        }

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
    public class CapacityLimitException : Exception
    {
        public string Message { get; set; } = "Kitab limiti asilmisdir";
        public CapacityLimitException(string message = null)
        {
            Message ??= message;
        }
    }
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
    public class ProductCountIsZeroException : Exception
    {
        public ProductCountIsZeroException(string message) : base(message)
        {
        }
    }
}
