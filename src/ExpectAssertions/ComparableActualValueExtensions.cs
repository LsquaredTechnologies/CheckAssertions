using System;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class ComparableActualValueExtensions
    {
        public static ActualValue<T> IsBetween<T>(this ActualValue<T> expectation, T low, T high) where T : IComparable =>
            expectation.Assert(
                expectation.Value.CompareTo(low) >= 0 && expectation.Value.CompareTo(high) <= 0,
                () => new EqualAssertException($""));
    }
}
