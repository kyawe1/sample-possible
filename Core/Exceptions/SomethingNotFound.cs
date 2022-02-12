using System;
using System.Runtime.Serialization;

namespace Core.Exceptions
{
    public class SomethingNotFound : Exception
    {
        public SomethingNotFound()
        {
        }

        public SomethingNotFound(string message) : base(message)
        {
        }

        public SomethingNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SomethingNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
