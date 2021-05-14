using System;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class ArrayActualValueExtensions
    {
        public static ActualValue<T[]> Contains<T>(this ActualValue<T[]> expectation, T expectedValue) =>
            expectation.Assert(
                Array.IndexOf(expectation.Value, expectedValue) >= 0,
                () => new EqualAssertException($""));

        public static ActualValue<T[]> HasLengthOf<T>(this ActualValue<T[]> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Length == expectedLength,
                () => new EqualAssertException($""));

        public static ActualValue<T[]> IsEmpty<T>(this ActualValue<T[]> expectation) =>
            expectation.Assert(
                expectation.Value.Length == 0,
                () => new EqualAssertException($""));

        public static ActualValue<T[]> IsNotEmpty<T>(this ActualValue<T[]> expectation) =>
            expectation.Assert(
                expectation.Value.Length != 0,
                () => new EqualAssertException($""));

        public static ActualValue<T[]> DoesNotContain<T>(this ActualValue<T[]> expectation, T expectedValue) =>
            expectation.Assert(
                Array.IndexOf(expectation.Value, expectedValue) == -1,
                () => new EqualAssertException($""));

        public static ActualValue<T[]> DoesNotHaveLengthOf<T>(this ActualValue<T[]> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Length != expectedLength,
                () => new EqualAssertException($""));
    }
}
