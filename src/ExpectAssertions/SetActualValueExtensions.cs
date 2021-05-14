using System.Collections.Generic;
using Lsquared.Foundation.CheckAssertions.Exceptions;

namespace Lsquared.Foundation.CheckAssertions
{
    public static class SetActualValueExtensions
    {
        public static ActualValue<ISet<T>> IsProperSubsetOf<T>(this ActualValue<ISet<T>> expectation, ISet<T> expectedSuperset) =>
            expectation.Assert(
                expectation.Value.IsProperSubsetOf(expectedSuperset),
                () => new EqualAssertException($""));

        public static ActualValue<ISet<T>> IsProperSupersetOf<T>(this ActualValue<ISet<T>> expectation, ISet<T> expectedSubset) =>
            expectation.Assert(
                expectation.Value.IsProperSupersetOf(expectedSubset),
                () => new EqualAssertException($""));

        public static ActualValue<ISet<T>> IsSubsetOf<T>(this ActualValue<ISet<T>> expectation, ISet<T> expectedSuperset) =>
            expectation.Assert(
                expectation.Value.IsSubsetOf(expectedSuperset),
                () => new EqualAssertException($""));

        public static ActualValue<ISet<T>> IsSupersetOf<T>(this ActualValue<ISet<T>> expectation, ISet<T> expectedSubset) =>
            expectation.Assert(
                expectation.Value.IsSupersetOf(expectedSubset),
                () => new EqualAssertException($""));
    }
}
