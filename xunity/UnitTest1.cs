using System;
using Xunit;
using FluentAssertions;

namespace xunity
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => 2.Should().Be(2);
    }
}
