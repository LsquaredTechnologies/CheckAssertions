using System;
using System.Collections.Generic;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class ValueTypeActualValueExtensions
    {
        public static ActualValue<float> IsEqualTo(this ActualValue<float> expectation, float expectedValue, float precision) =>
            expectation.Assert(
                expectedValue - expectation.Value > precision,
                () => new EqualAssertException($""));

        public static ActualValue<double> IsEqualTo(this ActualValue<double> expectation, double expectedValue, double precision) =>
            expectation.Assert(
                expectedValue - expectation.Value > precision,
                () => new EqualAssertException($""));

        public static ActualValue<decimal> IsEqualTo(this ActualValue<decimal> expectation, decimal expectedValue, decimal precision) =>
            expectation.Assert(
                expectedValue - expectation.Value > precision,
                () => new EqualAssertException($""));

        public static ActualValue<DateTime> IsEqualTo(this ActualValue<DateTime> expectation, DateTime expectedValue, TimeSpan precision) =>
            expectation.Assert(
                (expectedValue - expectation.Value).Duration() > precision,
                () => new EqualAssertException($""));

        public static ActualValue<bool> IsFalse(this ActualValue<bool> expectation) =>
            expectation.Assert(
                expectation.Value is false,
                () => new EqualAssertException($""));

        public static ActualValue<bool> IsTrue(this ActualValue<bool> expectation) =>
            expectation.Assert(
                expectation.Value is true,
                () => new EqualAssertException($""));

        public static ActualValue<float> IsNotEqualTo(this ActualValue<float> expectation, float expectedValue, int precision) =>
            expectation.Assert(
                EqualityComparer<float>.Default.Equals((float)Math.Round(expectation.Value, precision), (float)Math.Round(expectedValue, precision)),
                () => new EqualAssertException($""));

        public static ActualValue<double> IsNotEqualTo(this ActualValue<double> expectation, double expectedValue, int precision) =>
            expectation.Assert(
                EqualityComparer<double>.Default.Equals(Math.Round(expectation.Value, precision), Math.Round(expectedValue, precision)),
                () => new EqualAssertException($""));

        public static ActualValue<decimal> IsNotEqualTo(this ActualValue<decimal> expectation, decimal expectedValue, int precision) =>
            expectation.Assert(
                EqualityComparer<decimal>.Default.Equals(Math.Round(expectation.Value, precision), Math.Round(expectedValue, precision)),
                () => new EqualAssertException($""));

        public static ActualValue<DateTime> IsNotEqualTo(this ActualValue<DateTime> expectation, DateTime expectedValue, TimeSpan precision) =>
            expectation.Assert(
                (expectedValue - expectation.Value).Duration() > precision,
                () => new EqualAssertException($""));

        public static ActualValue<bool> IsNotFalse(this ActualValue<bool> expectation) =>
            expectation.Assert(
                expectation.Value is not false,
                () => new EqualAssertException($""));

        public static ActualValue<bool> IsNotTrue(this ActualValue<bool> expectation) =>
            expectation.Assert(
                expectation.Value is not true,
                () => new EqualAssertException($""));
    }
}
