using System;
using System.Runtime.Serialization;

namespace ProiectPSSC.Domain.Models
{
	[Serializable]
	public class InvalidatedOrder : Exception
	{
        public InvalidatedOrder()
        {
        }

        public InvalidatedOrder(string? message) : base(message)
        {
        }

        public InvalidatedOrder(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public InvalidatedOrder(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

