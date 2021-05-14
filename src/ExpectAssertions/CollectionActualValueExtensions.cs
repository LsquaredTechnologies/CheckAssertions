using System;
using System.Collections.Generic;
using System.Linq;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class CollectionActualValueExtensions
    {
        public static ActualValue<ICollection<T>> Contains<T>(this ActualValue<ICollection<T>> expectation, T expectedValue) =>
            expectation.Assert(
                expectation.Value.Contains(expectedValue, EqualityComparer<T>.Default),
                () => new EqualAssertException($""));

        public static ActualValue<ICollection<T>> Contains<T>(this ActualValue<ICollection<T>> expectation, T expectedValue, IEqualityComparer<T> comparer) =>
            expectation.Assert(
                expectation.Value.Contains(expectedValue, comparer),
                () => new EqualAssertException($""));

        public static ActualValue<ICollection<T>> HasLengthOf<T>(this ActualValue<ICollection<T>> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Count == expectedLength,
                () => new EqualAssertException($""));

        public static ActualValue<ICollection<T>> IsEmpty<T>(this ActualValue<ICollection<T>> expectation) =>
            expectation.Assert(
                expectation.Value.Count == 0,
                () => new EqualAssertException($""));

        public static ActualValue<ICollection<T>> IsNotEmpty<T>(this ActualValue<ICollection<T>> expectation) =>
            expectation.Assert(
                expectation.Value.Count != 0,
                () => new EqualAssertException($""));

        public static ActualValue<ICollection<T>> DoesNotContain<T>(this ActualValue<ICollection<T>> expectation, T expectedValue) =>
            expectation.Assert(
                !expectation.Value.Contains(expectedValue, EqualityComparer<T>.Default),
                () => new EqualAssertException($""));

        public static ActualValue<ICollection<T>> DoesNotContain<T>(this ActualValue<ICollection<T>> expectation, T expectedValue, IEqualityComparer<T> comparer) =>
            expectation.Assert(
                !expectation.Value.Contains(expectedValue, comparer),
                () => new EqualAssertException($""));

        public static ActualValue<ICollection<T>> DoesNotHaveLengthOf<T>(this ActualValue<ICollection<T>> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Count != expectedLength,
                () => new EqualAssertException($""));
    }
}
