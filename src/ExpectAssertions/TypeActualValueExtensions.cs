using System;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    /// <summary>
    /// Contains extension methods for <see cref="ActualValue{T}"/>.
    /// </summary>
    public static class TypeActualValueExtensions
    {
        public static ActualValue<T> Is<T>(this ActualValue<T> expectation, Type expectedType) =>
            expectation.Assert(
                expectation.Value!.GetType() == expectedType,
                () => new EqualAssertException($""));

        public static ActualValue<T> IsNull<T>(this ActualValue<T> expectation) =>
            expectation.Assert(
                expectation.Value is null,
                () => new EqualAssertException($""));

        public static ActualValue<T> IsSameAs<T>(this ActualValue<T> expectation, object expectedValue) =>
            expectation.Assert(
                expectedValue == (object?)expectation.Value,
                () => new EqualAssertException($""));

        public static ActualValue<T> IsNot<T>(this ActualValue<T> expectation, Type expectedType) =>
            expectation.Assert(
                expectation.Value!.GetType() != expectedType,
                () => new EqualAssertException($""));

        public static ActualValue<T> IsNotNull<T>(this ActualValue<T> expectation) =>
            expectation.Assert(
                expectation.Value is not null,
                () => new EqualAssertException($""));

        public static ActualValue<T> IsNotSameAs<T>(this ActualValue<T> expectation, object expectedValue) =>
            expectation.Assert(
                expectedValue != (object?)expectation.Value,
                () => new EqualAssertException($""));
    }
}
