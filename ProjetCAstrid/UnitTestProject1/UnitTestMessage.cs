using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetCAstrid;
using System;
using NMock;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestMessage
    {
        [TestMethod]
        public void AddTest()
        {
            FakeDate fake = new FakeDate();
            fake.dateToReturn = new DateTime(2018, 08, 20, 9, 13, 18);
            Message test = new Message(fake);
            string result = test.GetMessage;
            Assert.IsTrue(result.Contains("Bonjour"));
        }

        [TestMethod]
        public void AddTest2()
        {
            FakeDate fake = new FakeDate();
            fake.dateToReturn = new DateTime(2018, 08, 20, 15, 03, 18);
            Message test = new Message(fake);
            string result = test.GetMessage;
            Assert.IsTrue(result.Contains("Bonne Après - Midi"));
        }

        [TestMethod]
        public void AddTest3()
        {
            FakeDate fake = new FakeDate();
            fake.dateToReturn = new DateTime(2018, 08, 20, 19, 30, 28);
            Message test = new Message(fake);
            string result = test.GetMessage;
            Assert.IsTrue(result.Contains("Bonsoir"));
        }

        [TestMethod]
        public void AddTest4()
        {
            FakeDate fake = new FakeDate();
            fake.dateToReturn = new DateTime(2018, 08, 20, 7, 30, 28);
            Message test = new Message(fake);
            string result = test.GetMessage;
            Assert.IsTrue(result.Contains("Bon Week-end "));
        }

        [TestMethod]
        public void AddTest5_WithMock()
        {
            MockFactory mockFactory = new MockFactory();
            Mock<Idate> mockIdate = mockFactory.CreateMock<Idate>();
            mockIdate.Expects.Any.GetProperty(_ => _.date).WillReturn(new DateTime(2018, 08, 20, 7, 30, 28));
            Message test = new Message(mockIdate.MockObject);
            string result = test.GetMessage;
            Assert.IsTrue(result.Contains("Bon Week-end "));
        }
    }
}
