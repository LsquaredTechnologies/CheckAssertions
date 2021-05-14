using System;
using System.Text.RegularExpressions;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class StringActualValueExtensions
    {
        public static ActualValue<string> Contains(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                expectation.Value.Contains(expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<string> Contains(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                expectation.Value.Contains(expectedValue, comparison),
                () => new EqualAssertException($""));

        public static ActualValue<string> EndsWith(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                expectation.Value.EndsWith(expectedValue, StringComparison.OrdinalIgnoreCase),
                () => new EqualAssertException($""));

        public static ActualValue<string> EndsWith(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                expectation.Value.EndsWith(expectedValue, comparison),
                () => new EqualAssertException($""));

        public static ActualValue<string> Equals(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                string.Equals(expectedValue, expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string> Equals(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                string.Equals(expectedValue, expectation.Value, comparison),
                () => new EqualAssertException($""));

        public static ActualValue<string> HasLengthOf(this ActualValue<string> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Length == expectedLength,
                () => new EqualAssertException($""));

        public static ActualValue<string> IsEmpty(this ActualValue<string> expectation) =>
            expectation.Assert(
                expectation.Value.Length == 0,
                () => new EqualAssertException($""));

        public static ActualValue<string?> IsNullOrEmpty(this ActualValue<string?> expectation) =>
            expectation.Assert(
                string.IsNullOrEmpty(expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string?> IsNullOrWhitespace(this ActualValue<string?> expectation) =>
            expectation.Assert(
                string.IsNullOrWhiteSpace(expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string> IsNotEmpty(this ActualValue<string> expectation) =>
            expectation.Assert(
                expectation.Value.Length != 0,
                () => new EqualAssertException($""));

        public static ActualValue<string?> IsNotNullNorEmpty(this ActualValue<string?> expectation) =>
            expectation.Assert(
                !string.IsNullOrEmpty(expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string?> IsNotNullNorWhitespace(this ActualValue<string?> expectation) =>
            expectation.Assert(
                !string.IsNullOrWhiteSpace(expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string> Matches(this ActualValue<string> expectation, string expectedPattern) =>
            expectation.Assert(
                Regex.IsMatch(expectation.Value, expectedPattern),
                () => new EqualAssertException($""));

        public static ActualValue<string> Matches(this ActualValue<string> expectation, Regex expectedRegex) =>
            expectation.Assert(
                expectedRegex.IsMatch(expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string> StartsWith(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                expectation.Value.StartsWith(expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<string> StartsWith(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                expectation.Value.StartsWith(expectedValue, comparison),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotContain(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                !expectation.Value.Contains(expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotContain(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                !expectation.Value.Contains(expectedValue, comparison),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotEndWith(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                !expectation.Value.EndsWith(expectedValue, StringComparison.OrdinalIgnoreCase),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotEndWith(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                !expectation.Value.EndsWith(expectedValue, comparison),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotEqual(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                !string.Equals(expectedValue, expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotEqual(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                !string.Equals(expectedValue, expectation.Value, comparison),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotHaveLengthOf(this ActualValue<string> expectation, int expectedLength) =>
            expectation.Assert(
                expectation.Value.Length != expectedLength,
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotMatch(this ActualValue<string> expectation, string expectedPattern) =>
            expectation.Assert(
                !Regex.IsMatch(expectation.Value, expectedPattern),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotMatch(this ActualValue<string> expectation, Regex expectedRegex) =>
            expectation.Assert(
                !expectedRegex.IsMatch(expectation.Value),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotStartWith(this ActualValue<string> expectation, string expectedValue) =>
            expectation.Assert(
                !expectation.Value.StartsWith(expectedValue),
                () => new EqualAssertException($""));

        public static ActualValue<string> DoesNotStartWith(this ActualValue<string> expectation, string expectedValue, StringComparison comparison) =>
            expectation.Assert(
                !expectation.Value.StartsWith(expectedValue, comparison),
                () => new EqualAssertException($""));
    }
}
