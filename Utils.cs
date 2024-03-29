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
    }
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message)
        {
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
