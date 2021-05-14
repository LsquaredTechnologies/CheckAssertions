using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class DictionaryActualValueExtensions
    {
        public static ActualValue<IDictionary<TKey, TValue>> ContainsKey<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, TKey expectedKey) =>
            expectation.Assert(
                expectation.Value.ContainsKey(expectedKey),
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> Contains<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, TValue expectedValue) =>
            expectation.Assert(
                expectation.Value.Values.Contains(expectedValue, EqualityComparer<TValue>.Default),
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> Contains<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, TValue expectedValue, IEqualityComparer<TValue> comparer) =>
            expectation.Assert(
                expectation.Value.Values.Contains(expectedValue, comparer ?? EqualityComparer<TValue>.Default),
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> HasLengthOf<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Count == expectedLength,
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> IsEmpty<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation) =>
            expectation.Assert(
                expectation.Value.Count == 0,
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> IsNotEmpty<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation) =>
            expectation.Assert(
                expectation.Value.Count != 0,
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> DoesNotContainKey<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, TKey expectedKey) =>
            expectation.Assert(
                !expectation.Value.ContainsKey(expectedKey),
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> DoesNotContainValue<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, TValue expectedValue) =>
            expectation.Assert(
                !expectation.Value.Values.Contains(expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> DoesNotContainValue<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, TValue expectedValue, IEqualityComparer<TValue> comparer) =>
            expectation.Assert(
                !expectation.Value.Values.Contains(expectedValue, comparer),
                () => new EqualAssertException($""));

        public static ActualValue<IDictionary<TKey, TValue>> DoesNotHaveLengthOf<TKey, TValue>(this ActualValue<IDictionary<TKey, TValue>> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Count != expectedLength,
                () => new EqualAssertException($""));
    }
}
