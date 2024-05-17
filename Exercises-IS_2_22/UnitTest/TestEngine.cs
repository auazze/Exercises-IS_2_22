using Exercise1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TestEngine
    {
        [TestMethod]
        public void TestStartStop()
        {
            Engine eng = new Engine();
            Assert.AreEqual("WHROOM-WHROOM", eng.GetState());

            eng.Start();
            Assert.AreEqual("STARTED", eng.GetState());

            eng.Stop();
            Assert.AreEqual("STOPPED", eng.GetState());
        }
    }
}
