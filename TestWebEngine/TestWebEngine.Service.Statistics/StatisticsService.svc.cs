using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestWebEngine.Service.Statistics
{
    public class StatisticsService : IStatisticsService
    {
        private static readonly StatisticsType Statistics;

        static StatisticsService()
        {
            Statistics = new StatisticsType();
        }

        public bool UpdateStatistics(DateTime? date, double? score)
        {
            if (date == null)
            {
                throw new ArgumentNullException("date");
            }
            else if (score == null)
            {
                throw new ArgumentNullException("score");
            }
            if (Statistics.CompletedTestsCount != null)
            {
                Statistics.CompletedTestsCount++;
            }
            else
            {
                Statistics.CompletedTestsCount = 1;
            }
            Statistics.LastTestCompleted = date;
            if (Statistics.CompletedTestsCount != null)
                Statistics.AverageTestScore += score.Value/Statistics.CompletedTestsCount.Value;
            else
            {
                Statistics.AverageTestScore = score.Value;
            }
            return true;
        }

        public StatisticsType GetStatistics()
        {
            return Statistics;
        }
    }
}
