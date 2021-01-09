using System;
using System.Runtime.Serialization;

namespace MysecondFormsApp1
{
    [Serializable]
    internal class InvalidAgeValueException : Exception
    {
        public InvalidAgeValueException()
        {
        }

        public InvalidAgeValueException(string message) : base(message)
        {
        }

        public InvalidAgeValueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAgeValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}