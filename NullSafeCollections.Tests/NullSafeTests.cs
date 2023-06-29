using Xunit.Abstractions;

namespace NullSafeCollections.Tests
{
    public class NullSafeTests
    {
        private readonly ITestOutputHelper output;

        public NullSafeTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new[] { 0, 1, 2 })]
        public void CanIterateOverCollection(int[] collection)
        {
            foreach (var item in NullSafe.Array(collection))
            {
                output.WriteLine($"{item}");
            }

            foreach (var item in NullSafe.Collection(collection))
            {
                output.WriteLine($"{item}");
            }

            foreach (var item in NullSafe.Enumerable(collection))
            {
                output.WriteLine($"{item}");
            }

            foreach (var item in NullSafe.List(collection))
            {
                output.WriteLine($"{item}");
            }
        }
    }
}