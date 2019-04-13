using FluentAssertions;
using xlib;
using Xunit;

namespace xunity.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => new Class1().A.Should().Be(2);
    }
}
