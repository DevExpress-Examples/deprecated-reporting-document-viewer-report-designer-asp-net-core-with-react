using DevExpress.XtraReports.Web.ReportDesigner;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSide.Controllers {
    public class ReportDesignerController : Controller {
        public ActionResult GetReportDesignerModel(string reportUrl) {
            string modelJsonScript =
                new ReportDesignerClientSideModelGenerator(HttpContext.RequestServices)
                .GetJsonModelScript(
                    reportUrl,                 // The URL of a report that is opened in the Report Designer when the application starts.
                    null, // Available data sources in the Report Designer that can be added to reports.
                    "DXXRD",   // The URI path of the default controller that processes requests from the Report Designer.
                    "DXXRDV",// The URI path of the default controller that that processes requests from the Web Document Viewer.
                    "DXXQB"      // The URI path of the default controller that processes requests from the Query Builder.
                );
            return Content(modelJsonScript, "application/json");
        }
    }
}
