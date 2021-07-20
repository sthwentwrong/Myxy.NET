using System;

namespace Myxy.NET
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }


    public class TaskMetadata
    {
        public string Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int FiscalYear { get; set; }
        public int Quarter { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset LastUpdatedDateTime { get; set; }
    }

    public class AzDOMetadata : TaskMetadata
    {
        public int BuildCount { get; set; }
        public int AnalyzedFailureCount { get; set; }
        public int FiledIssueCount { get; set; }
    }
}
