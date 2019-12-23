using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;

namespace ServerSide.PredefinedReports {
    public static class ReportsFactory {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>() {
            ["TestReport"] = () => new TestReport()
        };
    }
}
