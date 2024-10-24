using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Exceptions
{
    internal class EmptyFileExtensionException : Exception
    {
            private const string DefaultMessage = "File extension cannot be empty";
            public EmptyFileExtensionException() : base(DefaultMessage) { }
            public EmptyFileExtensionException(string message) : base(message) { }

        }
}
