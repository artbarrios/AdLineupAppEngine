using AdLineup.Models;
using AdLineupAppEngine.Models;
using AdLineupAppEngine.Web_Data;
using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AdLineupAppEngine
{
    public class ReportsController : ApiController
    {

        // GET /api/reports/SampleReport
        [Route("api/reports/SampleReport")]
        [HttpGet]
        public IHttpActionResult SampleReport()
        {
            try
            {
                // create report object, Url is the public location where it can be viewed with a browser
                Report report = new Report();
                report.Name = "SampleReport";
                report.Filename = "SampleReport";
                report.SaveFormat = WdSaveFormat.wdFormatPDF;
                report.Extension = AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat);
                report.Url = AppCommon.BuildUrl(AppCommon.GetAppEngineUrl(), report.Filename + "." + AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat), AppCommon.GetAppEnginePort());
                // generate the report
                ReportManager.GenerateReport(report);
                // return the report properties
                return Ok(report);
            }
            catch (Exception e)
            {
                string message = AppCommon.AppendInnerExceptionMessages("ReportsController.SampleReport = " + e.Message, e);
                AppCommon.Log(message, EventLogEntryType.Error);
                throw new Exception(message);
            }
        } // SampleReport()

        // GET /api/reports/CustomersIndexPrinterFriendly
        [Route("api/reports/CustomersIndexPrinterFriendly")]
        [HttpGet]
        public IHttpActionResult CustomersIndexPrinterFriendly()
        {
            try
            {
                // create report object, Url is the public location where it can be viewed with a browser
                Report report = new Report();
                report.Name = "CustomersIndexPrinterFriendly";
                report.Filename = "CustomersIndexPrinterFriendly";
                report.SaveFormat = WdSaveFormat.wdFormatPDF;
                report.Extension = AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat);
                report.Url = AppCommon.BuildUrl(AppCommon.GetAppEngineUrl(), report.Filename + "." + AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat), AppCommon.GetAppEnginePort());
                // generate the report
                ReportManager.GenerateReport(report);
                // return the report properties
                return Ok(report);
            }
            catch (Exception e)
            {
                string message = AppCommon.AppendInnerExceptionMessages("ReportsController.CustomersIndexPrinterFriendly = " + e.Message, e);
                AppCommon.Log(message, EventLogEntryType.Error);
                throw new Exception(message);
            }
        } // CustomersIndexPrinterFriendly()

        // GET /api/reports/AdsIndexPrinterFriendly
        [Route("api/reports/AdsIndexPrinterFriendly")]
        [HttpGet]
        public IHttpActionResult AdsIndexPrinterFriendly()
        {
            try
            {
                // create report object, Url is the public location where it can be viewed with a browser
                Report report = new Report();
                report.Name = "AdsIndexPrinterFriendly";
                report.Filename = "AdsIndexPrinterFriendly";
                report.SaveFormat = WdSaveFormat.wdFormatPDF;
                report.Extension = AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat);
                report.Url = AppCommon.BuildUrl(AppCommon.GetAppEngineUrl(), report.Filename + "." + AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat), AppCommon.GetAppEnginePort());
                // generate the report
                ReportManager.GenerateReport(report);
                // return the report properties
                return Ok(report);
            }
            catch (Exception e)
            {
                string message = AppCommon.AppendInnerExceptionMessages("ReportsController.AdsIndexPrinterFriendly = " + e.Message, e);
                AppCommon.Log(message, EventLogEntryType.Error);
                throw new Exception(message);
            }
        } // AdsIndexPrinterFriendly()

        // GET /api/reports/BillboardsIndexPrinterFriendly
        [Route("api/reports/BillboardsIndexPrinterFriendly")]
        [HttpGet]
        public IHttpActionResult BillboardsIndexPrinterFriendly()
        {
            try
            {
                // create report object, Url is the public location where it can be viewed with a browser
                Report report = new Report();
                report.Name = "BillboardsIndexPrinterFriendly";
                report.Filename = "BillboardsIndexPrinterFriendly";
                report.SaveFormat = WdSaveFormat.wdFormatPDF;
                report.Extension = AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat);
                report.Url = AppCommon.BuildUrl(AppCommon.GetAppEngineUrl(), report.Filename + "." + AppCommon.GetExtensionFromWdSaveFormat(report.SaveFormat), AppCommon.GetAppEnginePort());
                // generate the report
                ReportManager.GenerateReport(report);
                // return the report properties
                return Ok(report);
            }
            catch (Exception e)
            {
                string message = AppCommon.AppendInnerExceptionMessages("ReportsController.BillboardsIndexPrinterFriendly = " + e.Message, e);
                AppCommon.Log(message, EventLogEntryType.Error);
                throw new Exception(message);
            }
        } // BillboardsIndexPrinterFriendly()

    }
}

