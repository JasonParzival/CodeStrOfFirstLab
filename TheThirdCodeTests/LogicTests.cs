using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheThirdCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThirdCode.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void DefaultTest()
        {
            string str = "I wanna eat guobaorou with rice and di san xian dad";

            string message = Logic.Message(str);

            Assert.AreEqual("I I wanna wanna eat eat guobaorou guobaorou ant ant san san tat tat ", message);
        }

        [TestMethod()]
        public void DeleteTextTest()
        {
            string str = "Huh at Gor at";

            string message = Logic.Message(str);

            Assert.AreEqual("Huh Huh Gor Gor ", message);
        }

        [TestMethod()]
        public void ReplaceLettersTest()
        {
            string str = "dough downe Irkudsk";

            string message = Logic.Message(str);

            Assert.AreEqual("tough tough towne towne Irkutsk Irkutsk ", message);
        }
    }
}