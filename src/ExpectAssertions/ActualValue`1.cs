using System;
using System.ComponentModel;

namespace Lsquared.Foundation.CheckAssertions
{
    /// <summary>
    /// Represents a wrapped actual value being checked.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class ActualValue<T>
    {
        /// <summary>
        /// Gets the actual value.
        /// </summary>
        public T Value { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpectThat"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public ActualValue(T value) => Value = value;

        /// <summary>
        /// Checks that condition is meet; otherwise, throw an exception.
        /// </summary>
        /// <param name="condition">If true, condition.</param>
        /// <param name="exceptionFactory">The exception factory.</param>
        /// <returns>An instance of <see cref="ActualValue{T}"/> which allows chaining of other checks.</returns>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public ActualValue<T> Assert(bool condition, Func<Exception> exceptionFactory)
        {
            if (!condition) throw exceptionFactory();
            return this;
        }

        /// <inheritdoc/>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => base.Equals(obj);

        /// <inheritdoc/>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        /// <inheritdoc/>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public override string? ToString() => base.ToString();
    }
}
