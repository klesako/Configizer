using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Configizer.Tests
{
    [TestClass]
    public class ConfigizerManualRunner
    {
        [TestMethod]
        public void CsharpOk()
        {
            Program.Apply(@"config\PROD01.csconfig", new [] {"DbPassword=secret password"});
        }

        [TestMethod]
        public void XmlOk()
        {
            Program.Apply(@"config\base.xml", new [] {"DbPassword=secret password"});
        }
    }
}