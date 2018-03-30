using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using RoboticsToolData.Repository;
using RoboticsToolData.Model;
using RoboticsTool.Models;
using System.Data;
using System.Web.UI.WebControls;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace RoboticsTool.Controllers
{
    public class RoboticsProcessController : Controller
    {
        // GET: RoboticsProcess
        public ActionResult GetAllUnProcessedRecords()
        {
            try
            {
                RoboticsRepository objrep = new RoboticsRepository();
                List<RoboticsUnProcessedModel> lstunprocessData = new List<RoboticsUnProcessedModel>();
                lstunprocessData = objrep.GetUnProcessedData();
                return View(lstunprocessData);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult GetAllUnProcessedRecords(List<RoboticsUnProcessedModel> lstRobotics)
        {
            try
            {
                RoboticsRepository objrep = new RoboticsRepository();
                if (lstRobotics.Count > 0)
                {
                    var lst = lstRobotics.Where(t => t.IsManualProcessed == true).ToList();
                    foreach (var q in lst)
                    {
                        objrep.updateManualProcessedData(q.Id, q.ConnectionType);
                    }
                }
                List<RoboticsUnProcessedModel> lstunprocessData = new List<RoboticsUnProcessedModel>();
                lstunprocessData = objrep.GetUnProcessedData();
                RoboticProcessViewModel objviewModel = new RoboticProcessViewModel();
                string message = string.Empty;
                message = objviewModel.ExportInRoboticFormat(lstunprocessData);
                ViewBag.Message = message;
                lstunprocessData = new List<RoboticsUnProcessedModel>();
                lstunprocessData = objrep.GetUnProcessedData();
                ModelState.Clear();
                return View(lstunprocessData);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public ActionResult ExportToExcel()
        {
            try
            {
                RoboticsRepository objRep = new RoboticsRepository();
                DataSet dsInvalidData = new DataSet();
                dsInvalidData = objRep.GetInvalidData();
                using (ExcelPackage pck = new ExcelPackage())
                {
                    DataTable dt = new DataTable();

                    ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Invalid_Other_Data");
                    if (dsInvalidData.Tables.Contains("Invalid_Other_Data"))
                    {
                        ws.Cells["A1"].LoadFromDataTable(dsInvalidData.Tables[0], true, TableStyles.Medium15);
                    }
                    else
                    {
                        ws.Cells["A1"].LoadFromDataTable(dt, true, TableStyles.Medium15);
                    }//You can Use TableStyles property of your desire.    
                     //Read the Excel file in a byte array    
                    ExcelWorksheet ws1 = pck.Workbook.Worksheets.Add("Invalid_Hardware_Only_Data");
                    if (dsInvalidData.Tables.Contains("Invalid_Hardware_Only_Data"))
                    {
                        ws1.Cells["A1"].LoadFromDataTable(dsInvalidData.Tables[1], true, TableStyles.Medium15);
                    }
                    else
                    {
                        ws1.Cells["A1"].LoadFromDataTable(dt, true, TableStyles.Medium15);
                    }
                    Byte[] fileBytes = pck.GetAsByteArray();
                    Response.ClearContent();
                    Response.AddHeader("content-disposition", "attachment;filename=Invalid_Data" + DateTime.Now.ToString("M_dd_yyyy_H_M_s") + ".xlsx");
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.BinaryWrite(fileBytes);
                    Response.End();

                }

                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}