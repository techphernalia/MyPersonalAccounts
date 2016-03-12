using System;
using System.Runtime.Serialization;

namespace com.techphernalia.MyPersonalAccounts.Model.Exceptions
{
    public class InvalidLedgerGroupException : Exception
    {

        public InvalidLedgerGroupException() : base() { }

        public InvalidLedgerGroupException(string message) : base(message) { }

        public InvalidLedgerGroupException(string message, Exception innerException) : base(message, innerException) { }

        protected InvalidLedgerGroupException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
