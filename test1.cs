using System;
using System.Diagnostics;
using Xunit;

namespace CrisXUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int val = 3;
            Debug.Assert(val != 2, "Value should not be 3.");
        
        }
    }
}
