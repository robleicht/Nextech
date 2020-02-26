using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Nextech.Tests
{
    [TestClass]
    public class NextechTests
    {
        [TestMethod]
        public void testTitleMapped()
        {
            var adapterModel = new HackerNewsAdapter.Models.Story();
            adapterModel.Title = "test";
            var domainModel = new Nextech.Domain.Models.Story().MapToDomain(adapterModel);

            Assert.AreEqual(domainModel.Title, adapterModel.Title);
        }
        [TestMethod]
        public void testAuthorMapped()
        {
            var adapterModel = new HackerNewsAdapter.Models.Story();
            adapterModel.By = "test";
            var domainModel = new Nextech.Domain.Models.Story().MapToDomain(adapterModel);

            Assert.AreEqual(domainModel.Author, adapterModel.By);
        }
        [TestMethod]
        public void testUrlMapped()
        {
            var adapterModel = new HackerNewsAdapter.Models.Story();
            adapterModel.Url = "test";
            var domainModel = new Nextech.Domain.Models.Story().MapToDomain(adapterModel);

            Assert.AreEqual(domainModel.Url, adapterModel.Url);
        }
    }
}
