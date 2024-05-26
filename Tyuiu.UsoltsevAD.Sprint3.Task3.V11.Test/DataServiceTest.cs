using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint3.Task3.V11.Lib;
namespace Tyuiu.UsoltsevAD.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';
            string wait = "s7wre7 v7w77 7";
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            Assert.AreEqual(wait, res);
        }
    }
}
