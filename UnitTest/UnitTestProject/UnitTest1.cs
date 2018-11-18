using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PG.Duplicates.Service;

namespace PG.Duplicates.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        PG.Duplicates.Service.Duplicates duplicateService;

        [TestInitialize]
        public void SetUp()
        {
            duplicateService = new PG.Duplicates.Service.Duplicates();
        }

        [TestMethod]
        public void TestWithNullValue()
        {
            var returnIntArray = duplicateService.findDuplicates(null);
            Assert.IsNotNull(returnIntArray);
        }

        [TestMethod]
        public void TestWithNegativeValue()
        {
            var returnIntArray = duplicateService.findDuplicates(-1);
            Assert.IsNull(returnIntArray);
        }

        [TestMethod]
        public void TestWithValidInt()
        {
            var mock = new Mock<IRandomListGenerator>();
            mock.Setup(p => p.GenerateListWithNElements(3)).Returns(new System.Collections.Generic.List<int> { 2, 3, 3, 2 });
            var _duplicateService = new PG.Duplicates.Service.Duplicates(mock.Object);
            var returnIntArray = _duplicateService.findDuplicates(3);
            Assert.IsNotNull(returnIntArray);
            Assert.IsTrue(returnIntArray.Length.Equals(2), "Length is not as expected:2, actual:" + returnIntArray.Length);
            Assert.IsTrue(returnIntArray[0] == 2);
            Assert.IsTrue(returnIntArray[1] == 3);
            _duplicateService = null;
        }

        [TestMethod]
        public void TestWithValidInt4()
        {
            var mock = new Mock<IRandomListGenerator>();
            mock.Setup(p => p.GenerateListWithNElements(4)).Returns(new System.Collections.Generic.List<int> { 3, 2, 1, 1, 4 });
            var _duplicateService = new PG.Duplicates.Service.Duplicates(mock.Object);
            var returnIntArray = _duplicateService.findDuplicates(4);
            Assert.IsNotNull(returnIntArray);
            Assert.IsTrue(returnIntArray.Length.Equals(1), "Length is not as expected:1, actual:" + returnIntArray.Length);
            Assert.IsTrue(returnIntArray[0] == 1);
            _duplicateService = null;
        }

        [TestCleanup]
        public void TearDown()
        {
            duplicateService = null;
        }
    }
}
