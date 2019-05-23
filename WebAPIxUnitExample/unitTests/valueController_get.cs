using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;


namespace unitTests
{
    public class valueController_Get
    {
        [Fact]
        public void shouldReturn2Values()
        {
            var controller = new valueController();
            var result = controller.Get();
            Assert.Equal(2, result.Count());

        }
    }
}
