using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
