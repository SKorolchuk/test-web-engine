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
        private readonly StatisticsType _statistics;

        public StatisticsService()
        {
            _statistics = new StatisticsType();
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
            _statistics.CompletedTestsCount++;
            _statistics.LastTestCompleted = date;
            if (_statistics.CompletedTestsCount != null)
                _statistics.AverageTestScore += score.Value/_statistics.CompletedTestsCount.Value;
            else
            {
                _statistics.AverageTestScore = score.Value;
            }
            return true;
        }
    }
}
