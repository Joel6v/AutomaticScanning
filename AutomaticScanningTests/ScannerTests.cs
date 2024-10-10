using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomaticScanning;

namespace AutomaticScanningTests
{
    [TestClass]
    public class ScannerTests
    {
        [TestMethod]
        public void GetAllScannersList()
        {
            var scanner = new Scanner();
            Assert.AreEqual(true, scanner.ScannerListCount >= 1);
        }
    }
}