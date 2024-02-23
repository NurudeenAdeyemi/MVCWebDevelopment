namespace WebDevelopment.Models.Exceptions
{
    using System;

    // Custom exception class
    public class BadRequestException : Exception
    {
        // Constructors
        public BadRequestException() : base() { }

        public BadRequestException(string message) : base(message) { }

        public BadRequestException(string message, Exception innerException)
            : base(message, innerException) { }

        // You can add additional properties or methods as needed
    }

}
