
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestClass20Dic
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
         public void TestCount()
        {
            Lunestdd tex = new Lunestdd("Same bed but it feels just a little bit bigger now Our song on the radio but it don't sound the same");
            Assert.AreEqual(23, tex.ContadorText());
        }
      
        

    }
}