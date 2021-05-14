using System;
using System.Runtime.Serialization;

namespace Lsquared.Foundation.CheckAssertions.Exceptions
{
    /// <summary>
    /// Represents an assert exception.
    /// </summary>
    public abstract class AssertException : Exception
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="AssertException"/> class from being created.
        /// </summary>
        private AssertException() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public AssertException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        public AssertException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssertException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information  about the source or destination.</param>
        protected AssertException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
