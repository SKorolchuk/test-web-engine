using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestWebEngine.Web.Extentions.StatisticsServices;

namespace TestWebEngine.Web.Tests
{
    [TestFixture]
    class StatisticsServiceTest
    {
        [Test]
        public void UpdateStatisticsTest()
        {
            var client = new StatisticsServiceClient("BasicHttpBinding_IStatisticsService");
            DateTime currentDateTime = DateTime.Now;
            const double score = 54.23;
            client.UpdateStatistics(currentDateTime, score);
            var stat = client.GetStatistics();

            Assert.IsNotNull(stat);
            Assert.AreEqual(stat.LastTestCompleted, currentDateTime);
            Assert.AreEqual(stat.CompletedTestsCount, 1);
            Assert.AreEqual(stat.AverageTestScore, score);
        }
    }
}
