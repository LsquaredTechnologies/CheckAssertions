namespace Lsquared.Foundation.CheckAssertions
{
    /// <summary>
    /// The check.
    /// </summary>
    public static class Expect
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <returns>An instance <see cref="ActualValue{T}"/>.</returns>
        public static ActualValue<T> That<T>(T value) =>
            new(value);
    }
}
