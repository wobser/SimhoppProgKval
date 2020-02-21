using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.services.Tests
{
    [TestClass()]
    public class JumpHelperTests
    {
        [TestMethod()]
        public void GenerateJumpNameFromCodeTest()
        {
            string JumpCode = "2,0,7,C";
            string Actual = "Back 3 1/2 Somersaults C";
            string result = Server.services.JumpHelper.GenerateJumpNameFromCode(JumpCode);

            Assert.AreEqual(Actual, result);

            JumpCode = "6,1,2,2,Q";
            Actual = "Armstand Forward 1 Somersault 1 Twist Q";
            result = Server.services.JumpHelper.GenerateJumpNameFromCode(JumpCode);
            Assert.AreEqual(Actual, result);

         
        }
    }
}