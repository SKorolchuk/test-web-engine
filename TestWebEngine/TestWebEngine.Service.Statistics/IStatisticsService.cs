using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestWebEngine.Service.Statistics
{
    [ServiceContract]
    public interface IStatisticsService
    {
        [OperationContract]
        bool UpdateStatistics(DateTime? date, double? score);
    }


    [DataContract]
    public class StatisticsType
    {
        [DataMember]
        public DateTime? LastTestCompleted { get; set; }

        [DataMember]
        public double AverageTestScore { get; set; }

        [DataMember]
        public long? CompletedTestsCount { get; set; }
    }
}
