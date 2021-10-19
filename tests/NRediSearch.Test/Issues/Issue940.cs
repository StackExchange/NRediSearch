using Xunit;

namespace NRediSearch.Tests
{
    public class Issue940
    {
        [Fact]
        public void Paging_Boxing()
        {
            for(int i = -20; i < 100; i++)
            {
                var boxed = i.Boxed();
                Assert.Equal(i, (int)boxed);
            }
        }
    }
}
