using System;

namespace Lsquared.Foundation.CheckAssertions.Exceptions
{
    /// <summary>
    /// Represents an assert exception when .
    /// </summary>
    public sealed class EqualAssertException : AssertException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EqualAssertException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public EqualAssertException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EqualAssertException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public EqualAssertException(string message, Exception innerException) : base(message, innerException) { }
    }
}
