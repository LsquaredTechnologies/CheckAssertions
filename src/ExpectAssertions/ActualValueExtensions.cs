using System;
using System.Collections.Generic;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class ActualValueExtensions
    {
        public static ActualValue<T> And<T>(this ActualValue<T> expectation) => expectation;

        public static ActualValue<T> IsEqualTo<T>(this ActualValue<T> expectation, T expectedValue) =>
            expectation.Assert(
                EqualityComparer<T>.Default.Equals(expectation.Value, expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<T> IsEqualTo<T>(this ActualValue<T> expectation, T expectedValue, IEqualityComparer<T> comparer) =>
            expectation.Assert(
                comparer.Equals(expectation.Value, expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<T> IsNotEqualTo<T>(this ActualValue<T> expectation, T expectedValue) =>
            expectation.Assert(
                !EqualityComparer<T>.Default.Equals(expectation.Value, expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<T> IsNotEqualTo<T>(this ActualValue<T> expectation, T expectedValue, IEqualityComparer<T> comparer) =>
            expectation.Assert(
                !comparer.Equals(expectation.Value, expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<T> Satisfies<T>(this ActualValue<T> expectation, Func<T, bool> check) =>
            expectation.Assert(
                check(expectation.Value),
                () => new EqualAssertException($""));
    }
}
