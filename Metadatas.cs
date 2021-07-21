using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myxy.NET
{
    public class Metadata
    {
        public string Id { get; set; }
        public DateTime Period { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset LastUpdatedDateTime { get; set; }
        public string CreatedBy { get; set; }

        [NotMapped]
        public int FiscalYear { get; set; }

        [NotMapped]
        public int FiscalQuarter { get; set; }
    }

    public class AzDO : Metadata
    {
        public int AnalyzedBuildCount { get; set; }
        public int AnalyzedFailureCount { get; set; }
        public int FiledIssueCount { get; set; }
    }

    public class E2EOnWindows : E2EBase { }
    public class E2EOnLinux : E2EBase { }
    public class E2EOnMac : E2EBase { }
    public class E2EBase : Metadata
    {
        public int CompletedBuildCount { get; set; }
        public int FiledIssueCount { get; set; }
    }
}
