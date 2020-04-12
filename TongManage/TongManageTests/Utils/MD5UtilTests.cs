using Microsoft.VisualStudio.TestTools.UnitTesting;
using TongManage.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongManage.Utils.Tests
{
    [TestClass()]
    public class MD5UtilTests
    {
        [TestMethod()]
        public void MD5EncryptTest()
        {
            string r=MD5Util.MD5Encrypt("123456");
            Console.WriteLine(r);
        }
    }
}