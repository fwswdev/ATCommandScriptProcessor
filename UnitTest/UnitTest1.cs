using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AT_Command_Script_Processor;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScriptProcessingTest()
        {
            IAtScriptProcessing iAtScriptProc = new AtScriptProcessing();
            string [] arrayString = new string[]
                {
                    "//asdfasda",
                    "__@HEX = 0xAA|True|530|This is a comment",
                    "AT To Send|False|500|This is a comment"
                };

            var ret = iAtScriptProc.ProcessArrayString(arrayString);
            Assert.AreEqual(2, ret.Count);

            Assert.AreEqual(true, ret[0].IsSpecialCommand);
            Assert.AreEqual(0xAA, ret[0].ByteToSend);
            Assert.AreEqual(true, ret[0].ReceiveData);
            Assert.AreEqual(530, ret[0].Delay);

            Assert.AreEqual(false, ret[1].IsSpecialCommand);
            Assert.AreEqual("AT To Send", ret[1].ATCommandToSend);
            Assert.AreEqual(false, ret[1].ReceiveData);
            Assert.AreEqual(500, ret[1].Delay);
        }
    }
}
