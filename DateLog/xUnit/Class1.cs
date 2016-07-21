using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnit
{
    public class Class1
    {
        [Fact]
        public void WriteTxt_null_false()
        {
            report re = new report();
            Assert.Equal(re.Writetxt("hi", null), true);
        }
    }
}
