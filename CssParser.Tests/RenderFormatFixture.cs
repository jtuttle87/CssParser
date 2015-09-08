using CssParser.Tests.Properties;
using NUnit.Framework;

namespace CssParser.Tests
{
    [TestFixture]
    public class RenderFormatFixture
    {
        [Test]
        public void Stylesheet_Renders_Inline()
        {
            var parser = new Parser();
       
            var css = parser.Parse(Resources.Css3);

            Assert.AreEqual(Resources.Css3Min, css.ToString());
        }
        
    }
}
