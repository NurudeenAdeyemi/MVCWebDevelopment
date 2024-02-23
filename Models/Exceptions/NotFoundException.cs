namespace WebDevelopment.Models.Exceptions
{
    using System;

    // Custom exception class
    public class NotFoundException : Exception
    {
        // Constructors
        public NotFoundException() : base() { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception innerException)
            : base(message, innerException) { }

        // You can add additional properties or methods as needed
    }

}
