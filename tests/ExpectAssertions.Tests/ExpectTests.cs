using Xunit;

namespace Lsquared.Foundation.CheckAssertions.Tests
{
    public sealed class ExpectTests
    {
        [Fact]
        public void That_True_IsTrue() =>
            Expect.That(true).IsTrue().And().IsNotFalse();

        [Fact]
        public void That_False_IsFalse() =>
            Expect.That(false).IsFalse().And().IsNotTrue();

        [Fact]
        public void That_String_IsEqualToSameString() =>
            Expect.That("same").IsEqualTo("same").And().IsNotEqualTo("other");

        [Fact]
        public void That_String_IsEmpty() =>
            Expect.That("").IsNotNull().And().IsEmpty();

        [Fact]
        public void That_Zero_IsEqualToZero() =>
            Expect.That(0).IsEqualTo(0).And().IsNotEqualTo(1);

        [Fact]
        public void That_ZeroAsDouble_IsEqualToZero() =>
            Expect.That(0.0).IsEqualTo(0).And().IsNotEqualTo(1);

        [Fact]
        public void That_Three_IsBetweenTwoAndFour() =>
            Expect.That(3).IsBetween(2, 4).And().Is(typeof(int));

        [Fact]
        public void That_String_MatchesPattern() =>
            Expect.That("foo bar").Matches(@"fo{2}\sbar");

        [Fact]
        public void That_Array_HasSpecifiedLength() =>
            Expect.That(new int[] { 1, 2, 3 }).HasLengthOf(3)/*.And().IsEqualTo(new int[] { 1, 2, 3 })*/; // TODO

        [Fact]
        public void That_Array_ContainsSpecifiedValue() =>
            Expect.That(new int[] { 1, 2, 3 }).Contains(2).And().Contains(3);

        [Fact]
        public void That_Object_IsNotSameAsAnotherObject()
        {
            object obj1 = new();
            object obj2 = new();
            Expect.That(obj1).IsSameAs(obj1).And().IsNotSameAs(obj2);
        }
    }
}
