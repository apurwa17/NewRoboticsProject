using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using RoboticsToolData.Model;
using RoboticsToolData.Repository;

namespace RoboticsTool.Models
{
    public class RoboticProcessViewModel
    {
        public string ExportInRoboticFormat(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                string message = string.Empty;
                List<RoboticsUnProcessedModel> lst = new List<RoboticsUnProcessedModel>();
                lst = lstUnprocessedData.Where(q => q.ConnectionType.ToLower() == "add ctn").ToList();
                if (lst != null && lst.Count > 0)
                {
                    message = Export_Add_CTN(lst) + " <br/>";

                }
                lst = lstUnprocessedData.Where(q => q.ConnectionType.ToLower() == "add ctn with hardware").ToList();
                if (lst != null && lst.Count > 0)
                {
                    message = message + Export_Add_CTN_With_Hardware(lst) + " <br/>";
                }
                lst = lstUnprocessedData.Where(q => q.ConnectionType.ToLower() == "resign").ToList();
                if (lst != null && lst.Count > 0)
                {
                    message = message + Export_Resign(lst) + " <br/>";
                }
                lst = lstUnprocessedData.Where(q => q.ConnectionType.ToLower() == "resign with hardware").ToList();
                if (lst != null && lst.Count > 0)
                {
                    message = message + Export_Resign_With_Hardware(lst) + " <br/>";
                }

                lst = lstUnprocessedData.Where(q => q.ConnectionType.ToLower() == "airtime credit").ToList();
                if (lst != null && lst.Count > 0)
                {
                    message = message + Export_Airtime_Credit(lst) + " <br/>";
                }
                lst = lstUnprocessedData.Where(q => q.ConnectionType.ToLower() == "hardware credit").ToList();
                if (lst != null && lst.Count > 0)
                {
                    message = message + Export_Hardware_Credit(lst) + " <br/>";
                }
                lst = lstUnprocessedData.Where(q => q.ConnectionType.ToLower() == "hardware only").ToList();
                if (lst != null && lst.Count > 0)
                {
                    message = message + Export_Hardware_Only(lst) + " <br/>";
                }
                return message;
            }
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: ExportInRoboticFormat";
            }
        }


        public string Export_Add_CTN(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Add CTN";
                dt.Clear();
                dt.Columns.Add("Connection Type");
                dt.Columns.Add("Ref Id");
                dt.Columns.Add("Subscription");
                dt.Columns.Add("Account Name");
                dt.Columns.Add("BAN");
                dt.Columns.Add("Tariff Code");
                dt.Columns.Add("Commitment Length (Months)");
                dt.Columns.Add("Commitment Start Date");
                dt.Columns.Add("SOC Code 1");
                dt.Columns.Add("SOC Code 2");
                dt.Columns.Add("SOC Code 3");
                dt.Columns.Add("SOC Code 4");
                dt.Columns.Add("International Bar Remove?");
                dt.Columns.Add("PAC");
                dt.Columns.Add("Port In Date");
                dt.Columns.Add("Accessory SKU");
                dt.Columns.Add("Accessory Variant");
                dt.Columns.Add("Accessory Charge");
                dt.Columns.Add("Charging Account (Hardware/Airtime)");
                dt.Columns.Add("Sim Card Required");
                dt.Columns.Add("Sim Card SKU Code");
                dt.Columns.Add("Existing SIM No.");
                dt.Columns.Add("Delivery Address");
                dt.Columns.Add("Delivery Type");
                dt.Columns.Add("Delivery Charge(£)");
                dt.Columns.Add("Discount Amount Per Month (£)");
                dt.Columns.Add("Discount Length(Months)");

                foreach (var q in lstUnprocessedData)
                {
                    DataRow dr = dt.NewRow();
                    dr["Connection Type"] = q.ConnectionType;
                    dr["Ref Id"] = q.ReferenceNumber;
                    dr["Subscription"] = q.SubmissionDate;
                    dr["Account Name"] = q.AccountName;
                    dr["BAN"] = q.BAN;
                    dr["Tariff Code"] = q.TariffCode;
                    dr["Commitment Length (Months)"] = q.CommitmentLength;
                    dr["Commitment Start Date"] = q.CommitmentStartDate;
                    dr["SOC Code 1"] = q.SOC1Code;
                    dr["SOC Code 2"] = q.SOC2Code;
                    dr["SOC Code 3"] = q.SOC3Code;
                    dr["SOC Code 4"] = q.SOC4Code;
                    dr["International Bar Remove?"] = q.InternationalBarRemove == true ? "Yes" : "No";
                    dr["PAC"] = q.PACCode;
                    dr["Port In Date"] = q.PortDate;
                    dr["Accessory SKU"] = q.AccessorySKU;
                    dr["Accessory Variant"] = q.AccessoryVariant;
                    dr["Accessory Charge"] = q.AccessoryCharge;
                    dr["Charging Account (Hardware/Airtime)"] = q.ChargingAccount;
                    dr["Sim Card Required"] = q.SimRequired;
                    dr["Sim Card SKU Code"] = q.SimCardSKUCode;
                    dr["Existing SIM No."] = q.ExistingSIMNo;
                    dr["Delivery Address"] = q.DeliveryAddress;
                    dr["Delivery Type"] = q.DeliveryType;
                    dr["Delivery Charge(£)"] = q.DeliveryCharge;
                    dr["Discount Amount Per Month (£)"] = q.Discount;
                    dr["Discount Length(Months)"] = q.DiscountLength;
                    dt.Rows.Add(dr);

                }
                string message = string.Empty;
                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dt.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells[1, dt.Columns.Count])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    }

                    string AddCTNFilePath = ConfigurationManager.AppSettings["AddCTNFilePath"].ToString();
                    //Write it back to the client    
                    if (File.Exists(AddCTNFilePath))
                    {
                        message = "File is already exist to process for 'ADD CTN'";
                        return message;

                    }

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(AddCTNFilePath);
                    objFileStrm.Close();



                    //Write content to excel file    
                    File.WriteAllBytes(AddCTNFilePath, objExcelPackage.GetAsByteArray());

                }

                message = "File 'Add CTN' has processed succussfully.";
                //processed data in database
                RoboticsRepository objrep = new RoboticsRepository();
                objrep.UpdateProcessedDataforAddCTN(lstUnprocessedData);
                return message;
            }
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: Export_Add_CTN";
            }
        }
        public string Export_Add_CTN_With_Hardware(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Add CTN with Hardware";
                dt.Clear();
                dt.Columns.Add("Connection Type");
                dt.Columns.Add("Ref Id");
                dt.Columns.Add("Subscription");
                dt.Columns.Add("Account Name");
                dt.Columns.Add("BAN");
                dt.Columns.Add("Tariff Code");
                dt.Columns.Add("Commitment Length (Months)");
                dt.Columns.Add("Commitment Start Date");
                dt.Columns.Add("SOC Code 1");
                dt.Columns.Add("SOC Code 2");
                dt.Columns.Add("SOC Code 3");
                dt.Columns.Add("SOC Code 4");
                dt.Columns.Add("International Bar Remove?");
                dt.Columns.Add("PAC");
                dt.Columns.Add("Port In Date");
                dt.Columns.Add("Hardware SKU Code");
                dt.Columns.Add("Hardware Variant");
                dt.Columns.Add("Hardware Charge (£)");
                dt.Columns.Add("Accessory SKU");
                dt.Columns.Add("Accessory Variant");
                dt.Columns.Add("Accessory Charge");
                dt.Columns.Add("Charging Account (Hardware/Airtime)");
                dt.Columns.Add("Sim Card Required");
                dt.Columns.Add("Sim Card SKU Code");
                dt.Columns.Add("Existing SIM No.");
                dt.Columns.Add("Delivery Address");
                dt.Columns.Add("Delivery Type");
                dt.Columns.Add("Delivery Charge(£)");
                dt.Columns.Add("Discount Amount Per Month (£)");
                dt.Columns.Add("Discount Length(Months)");

                foreach (var q in lstUnprocessedData)
                {
                    DataRow dr = dt.NewRow();
                    dr["Connection Type"] = q.ConnectionType;
                    dr["Ref Id"] = q.ReferenceNumber;
                    dr["Subscription"] = q.SubmissionDate;
                    dr["Account Name"] = q.AccountName;
                    dr["BAN"] = q.BAN;
                    dr["Tariff Code"] = q.TariffCode;
                    dr["Commitment Length (Months)"] = q.CommitmentLength;
                    dr["Commitment Start Date"] = q.CommitmentStartDate;
                    dr["SOC Code 1"] = q.SOC1Code;
                    dr["SOC Code 2"] = q.SOC2Code;
                    dr["SOC Code 3"] = q.SOC3Code;
                    dr["SOC Code 4"] = q.SOC4Code;
                    dr["International Bar Remove?"] = q.InternationalBarRemove == true ? "Yes" : "No";
                    dr["PAC"] = q.PACCode;
                    dr["Port In Date"] = q.PortDate;
                    dr["Hardware SKU Code"] = q.HardwareSKUCode;
                    dr["Hardware Variant"] = q.HardwareVariant;
                    dr["Hardware Charge (£)"] = q.HardwareCharge;
                    dr["Accessory SKU"] = q.AccessorySKU;
                    dr["Accessory Variant"] = q.AccessoryVariant;
                    dr["Accessory Charge"] = q.AccessoryCharge;
                    dr["Charging Account (Hardware/Airtime)"] = q.ChargingAccount;
                    dr["Sim Card Required"] = q.SimRequired;
                    dr["Sim Card SKU Code"] = q.SimCardSKUCode;
                    dr["Existing SIM No."] = q.ExistingSIMNo;
                    dr["Delivery Address"] = q.DeliveryAddress;
                    dr["Delivery Type"] = q.DeliveryType;
                    dr["Delivery Charge(£)"] = q.DeliveryCharge;
                    dr["Discount Amount Per Month (£)"] = q.Discount;
                    dr["Discount Length(Months)"] = q.DiscountLength;
                    dt.Rows.Add(dr);

                }
                string message = string.Empty;
                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dt.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells[1, dt.Columns.Count])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    }

                    string AddCTNFilewithHWPath = ConfigurationManager.AppSettings["AddCTNWithHardwareFilePath"].ToString();
                    //Write it back to the client    
                    if (File.Exists(AddCTNFilewithHWPath))
                    {
                        message = "File is already exist to process for 'Add CTN With Hardware'";
                        return message;

                    }

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(AddCTNFilewithHWPath);
                    objFileStrm.Close();

                    //Write content to excel file    
                    File.WriteAllBytes(AddCTNFilewithHWPath, objExcelPackage.GetAsByteArray());
                }
                message = "File 'Add CTN With Hardware' has processed succussfully.";
                //processed data in database
                RoboticsRepository objrep = new RoboticsRepository();
                objrep.UpdateProcessedDataforAddCTNWithHWR(lstUnprocessedData);
                return message;
            } 
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: Export_Add_CTN_With_Hardware";
            }
}
        public string Export_Resign(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Resign";
                dt.Clear();
                dt.Columns.Add("Connection Type");
                dt.Columns.Add("Ref Id");
                dt.Columns.Add("Subscription");
                dt.Columns.Add("Account Name");
                dt.Columns.Add("BAN");
                dt.Columns.Add("Tariff Code");
                dt.Columns.Add("Commitment Length (Months)");
                dt.Columns.Add("Commitment Start Date");
                dt.Columns.Add("SOC Code 1");
                dt.Columns.Add("SOC Code 2");
                dt.Columns.Add("SOC Code 3");
                dt.Columns.Add("SOC Code 4");
                dt.Columns.Add("International Bar Remove?");
                dt.Columns.Add("Discount Amount Per Month (£)");
                dt.Columns.Add("Discount Length (Months)");

                foreach (var q in lstUnprocessedData)
                {
                    DataRow dr = dt.NewRow();
                    dr["Connection Type"] = q.ConnectionType;
                    dr["Ref Id"] = q.ReferenceNumber;
                    dr["Subscription"] = q.SubmissionDate;
                    dr["Account Name"] = q.AccountName;
                    dr["BAN"] = q.BAN;
                    dr["Tariff Code"] = q.TariffCode;
                    dr["Commitment Length (Months)"] = q.CommitmentLength;
                    dr["Commitment Start Date"] = q.CommitmentStartDate;
                    dr["SOC Code 1"] = q.SOC1Code;
                    dr["SOC Code 2"] = q.SOC2Code;
                    dr["SOC Code 3"] = q.SOC3Code;
                    dr["SOC Code 4"] = q.SOC4Code;
                    dr["International Bar Remove?"] = q.InternationalBarRemove == true ? "Yes" : "No";
                    dr["Discount Amount Per Month (£)"] = q.Discount;
                    dr["Discount Length (Months)"] = q.DiscountLength;
                    dt.Rows.Add(dr);

                }
                string message = string.Empty;
                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dt.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells[1, dt.Columns.Count])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    }

                    string resignPath = ConfigurationManager.AppSettings["ResignFilePath"].ToString();
                    //Write it back to the client    
                    if (File.Exists(resignPath))
                    {
                        message = "File is already exist to process for 'Resign'";
                        return message;

                    }

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(resignPath);
                    objFileStrm.Close();

                    //Write content to excel file    
                    File.WriteAllBytes(resignPath, objExcelPackage.GetAsByteArray());
                }
                message = "File 'Resign' has processed succussfully.";
                //processed data in database
                RoboticsRepository objrep = new RoboticsRepository();
                objrep.UpdateProcessedDataforResign(lstUnprocessedData);
                return message;
            }  
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: Export_Resign";
            }
}
        public string Export_Resign_With_Hardware(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Resign with Hardware";
                dt.Clear();
                dt.Columns.Add("Connection Type");
                dt.Columns.Add("Ref Id");
                dt.Columns.Add("Subscription");
                dt.Columns.Add("Account Name");
                dt.Columns.Add("BAN");
                dt.Columns.Add("Tariff Code");
                dt.Columns.Add("Commitment Length (Months)");
                dt.Columns.Add("Commitment Start Date");
                dt.Columns.Add("SOC Code 1");
                dt.Columns.Add("SOC Code 2");
                dt.Columns.Add("SOC Code 3");
                dt.Columns.Add("SOC Code 4");
                dt.Columns.Add("International Bar Remove?");
                dt.Columns.Add("Hardware SKU Code");
                dt.Columns.Add("Hardware Variant");
                dt.Columns.Add("Hardware Charge (£)");
                dt.Columns.Add("Accessory SKU");
                dt.Columns.Add("Accessory Variant");
                dt.Columns.Add("Accessory Charge");
                dt.Columns.Add("Charging Account (Hardware/Airtime)");
                dt.Columns.Add("Sim Card Required");
                dt.Columns.Add("Sim Card SKU Code");
                dt.Columns.Add("Existing SIM No.");
                dt.Columns.Add("Delivery Address");
                dt.Columns.Add("Delivery Type");
                dt.Columns.Add("Delivery Charge(£)");
                dt.Columns.Add("Discount Amount Per Month (£)");
                dt.Columns.Add("Discount Length(Months)");

                foreach (var q in lstUnprocessedData)
                {
                    DataRow dr = dt.NewRow();
                    dr["Connection Type"] = q.ConnectionType;
                    dr["Ref Id"] = q.ReferenceNumber;
                    dr["Subscription"] = q.SubmissionDate;
                    dr["Account Name"] = q.AccountName;
                    dr["BAN"] = q.BAN;
                    dr["Tariff Code"] = q.TariffCode;
                    dr["Commitment Length (Months)"] = q.CommitmentLength;
                    dr["Commitment Start Date"] = q.CommitmentStartDate;
                    dr["SOC Code 1"] = q.SOC1Code;
                    dr["SOC Code 2"] = q.SOC2Code;
                    dr["SOC Code 3"] = q.SOC3Code;
                    dr["SOC Code 4"] = q.SOC4Code;
                    dr["International Bar Remove?"] = q.InternationalBarRemove == true ? "Yes" : "No";
                    dr["Hardware SKU Code"] = q.HardwareSKUCode;
                    dr["Hardware Variant"] = q.HardwareVariant;
                    dr["Hardware Charge (£)"] = q.HardwareCharge;
                    dr["Accessory SKU"] = q.AccessorySKU;
                    dr["Accessory Variant"] = q.AccessoryVariant;
                    dr["Accessory Charge"] = q.AccessoryCharge;
                    dr["Charging Account (Hardware/Airtime)"] = q.ChargingAccount;
                    dr["Sim Card Required"] = q.SimRequired;
                    dr["Sim Card SKU Code"] = q.SimCardSKUCode;
                    dr["Existing SIM No."] = q.ExistingSIMNo;
                    dr["Delivery Address"] = q.DeliveryAddress;
                    dr["Delivery Type"] = q.DeliveryType;
                    dr["Delivery Charge(£)"] = q.DeliveryCharge;
                    dr["Discount Amount Per Month (£)"] = q.Discount;
                    dr["Discount Length(Months)"] = q.DiscountLength;
                    dt.Rows.Add(dr);

                }
                string message = string.Empty;
                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dt.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells[1, dt.Columns.Count])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    }

                    string resignWithHWPath = ConfigurationManager.AppSettings["ResignWithHardwareFilePath"].ToString();
                    //Write it back to the client    
                    if (File.Exists(resignWithHWPath))
                    {
                        message = "File is already exist to process for 'Resign With Hardware'";
                        return message;

                    }

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(resignWithHWPath);
                    objFileStrm.Close();

                    //Write content to excel file    
                    File.WriteAllBytes(resignWithHWPath, objExcelPackage.GetAsByteArray());
                }
                message = "File 'Resign With Hardware' has processed succussfully.";
                //processed data in database
                RoboticsRepository objrep = new RoboticsRepository();
                objrep.UpdateProcessedDataforResignWTHWR(lstUnprocessedData);
                return message;
            }
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: Export_Resign_With_Hardware";
            }
        }
        public string Export_Airtime_Credit(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Airtime Credit";
                dt.Clear();
                dt.Columns.Add("Connection Type");
                dt.Columns.Add("Ref Id");
                dt.Columns.Add("Airtime BAN");
                dt.Columns.Add("Hardware BAN");
                dt.Columns.Add("Hardware Fund (£)");
                dt.Columns.Add("Airtime Fund (£)");
                dt.Columns.Add("Buy Out Credit(VAT Exempt)(£)");

                foreach (var q in lstUnprocessedData)
                {
                    DataRow dr = dt.NewRow();
                    dr["Connection Type"] = q.ConnectionType;
                    dr["Ref Id"] = q.ReferenceNumber;
                    dr["Airtime BAN"] = q.AirtimeBAN;
                    dr["Hardware BAN"] = q.HardwareBAN;
                    dr["Hardware Fund (£)"] = q.HardwareFund;
                    dr["Airtime Fund (£)"] = q.AirtimeFund;
                    dr["Buy Out Credit(VAT Exempt)(£)"] = q.BuyOutCredit;
                    dt.Rows.Add(dr);

                }
                string message = string.Empty;
                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dt.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells[1, dt.Columns.Count])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    }

                    string airtimeCreditPath = ConfigurationManager.AppSettings["AirtimeCreditFilePath"].ToString();
                    //Write it back to the client    
                    if (File.Exists(airtimeCreditPath))
                    {
                        message = "File is already exist to process for 'Airtime Credit'";
                        return message;

                    }

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(airtimeCreditPath);
                    objFileStrm.Close();

                    //Write content to excel file    
                    File.WriteAllBytes(airtimeCreditPath, objExcelPackage.GetAsByteArray());
                }
                message = "File 'Airtime Credit' has processed succussfully.";
                //processed data in database
                RoboticsRepository objrep = new RoboticsRepository();
                objrep.UpdateProcessedDataforAirtimeCredit(lstUnprocessedData);
                return message;

            }
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: Export_Airtime_Credit";
            }

}
        public string Export_Hardware_Credit(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Hardware Credit";
                dt.Clear();
                dt.Columns.Add("Connection Type");
                dt.Columns.Add("Ref Id");
                dt.Columns.Add("Airtime BAN");
                dt.Columns.Add("Hardware BAN");
                dt.Columns.Add("Hardware Fund (£)");
                dt.Columns.Add("Airtime Fund (£)");
                dt.Columns.Add("Buy Out Credit(VAT Exempt)(£)");

                foreach (var q in lstUnprocessedData)
                {
                    DataRow dr = dt.NewRow();
                    dr["Connection Type"] = q.ConnectionType;
                    dr["Ref Id"] = q.ReferenceNumber;
                    dr["Airtime BAN"] = q.AirtimeBAN;
                    dr["Hardware BAN"] = q.HardwareBAN;
                    dr["Hardware Fund (£)"] = q.HardwareFund;
                    dr["Airtime Fund (£)"] = q.AirtimeFund;
                    dr["Buy Out Credit(VAT Exempt)(£)"] = q.BuyOutCredit;
                    dt.Rows.Add(dr);

                }
                string message = string.Empty;
                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dt.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells[1, dt.Columns.Count])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    }

                    string hardwareCreditPath = ConfigurationManager.AppSettings["HardwareCreditFilePath"].ToString();
                    //Write it back to the client    
                    if (File.Exists(hardwareCreditPath))
                    {
                        message = "File is already exist to process for 'Hardware Credit'";
                        return message;

                    }

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(hardwareCreditPath);
                    objFileStrm.Close();

                    //Write content to excel file    
                    File.WriteAllBytes(hardwareCreditPath, objExcelPackage.GetAsByteArray());
                }
                message = "File 'Hardware Credit' has processed succussfully.";
                //processed data in database
                RoboticsRepository objrep = new RoboticsRepository();
                objrep.UpdateProcessedDataforHardwareCredit(lstUnprocessedData);
                return message;
            }
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: Export_Hardware_Credit";
            }
        }

        public string Export_Hardware_Only(List<RoboticsUnProcessedModel> lstUnprocessedData)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.TableName = "Hardware Only";
                dt.Clear();
                dt.Columns.Add("Connection Type");
                dt.Columns.Add("Ref Id");
                dt.Columns.Add("Subscription");
                dt.Columns.Add("Account Name");
                dt.Columns.Add("BAN");
                dt.Columns.Add("Hardware SKU Code");
                dt.Columns.Add("Hardware Variant");
                dt.Columns.Add("Hardware Charge (£)");
                dt.Columns.Add("Accessory SKU");
                dt.Columns.Add("Accessory Variant");
                dt.Columns.Add("Accessory Charge");
                dt.Columns.Add("Charging Account (Hardware/Airtime)");
                dt.Columns.Add("Sim Card Required");
                dt.Columns.Add("Sim Card SKU Code");
                dt.Columns.Add("Existing SIM No.");
                dt.Columns.Add("Delivery Address");
                dt.Columns.Add("Delivery Type");
                dt.Columns.Add("Delivery Charge(£)");
                foreach (var q in lstUnprocessedData)
                {
                    DataRow dr = dt.NewRow();
                    dr["Connection Type"] = q.ConnectionType;
                    dr["Ref Id"] = q.ReferenceNumber;
                    dr["Subscription"] = q.SubmissionDate;
                    dr["Account Name"] = q.AccountName;
                    dr["BAN"] = q.BAN;
                    dr["Hardware SKU Code"] = q.HardwareSKUCode;
                    dr["Hardware Variant"] = q.HardwareVariant;
                    dr["Hardware Charge (£)"] = q.HardwareCharge;
                    dr["Accessory SKU"] = q.AccessorySKU;
                    dr["Accessory Variant"] = q.AccessoryVariant;
                    dr["Accessory Charge"] = q.AccessoryCharge;
                    dr["Charging Account (Hardware/Airtime)"] = q.ChargingAccount;
                    dr["Sim Card Required"] = q.SimRequired;
                    dr["Sim Card SKU Code"] = q.SimCardSKUCode;
                    dr["Existing SIM No."] = q.ExistingSIMNo;
                    dr["Delivery Address"] = q.DeliveryAddress;
                    dr["Delivery Type"] = q.DeliveryType;
                    dr["Delivery Charge(£)"] = q.DeliveryCharge;
                    dt.Rows.Add(dr);

                }
                string message = string.Empty;
                using (ExcelPackage objExcelPackage = new ExcelPackage())
                {

                    //Create the worksheet    
                    ExcelWorksheet objWorksheet = objExcelPackage.Workbook.Worksheets.Add(dt.TableName);
                    //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1    
                    objWorksheet.Cells["A1"].LoadFromDataTable(dt, true);
                    objWorksheet.Cells.Style.Font.SetFromFont(new Font("Calibri", 10));
                    objWorksheet.Cells.AutoFitColumns();
                    //Format the header    
                    using (ExcelRange objRange = objWorksheet.Cells[1, dt.Columns.Count])
                    {
                        objRange.Style.Font.Bold = true;
                        objRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        objRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        objRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        objRange.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    }

                    string hardwareOnlyPath = ConfigurationManager.AppSettings["HardwareOnlyFilePath"].ToString();
                    //Write it back to the client    
                    if (File.Exists(hardwareOnlyPath))
                    {
                        message = "File is already exist to process for 'Hardware Only'";
                        return message;

                    }

                    //Create excel file on physical disk    
                    FileStream objFileStrm = File.Create(hardwareOnlyPath);
                    objFileStrm.Close();

                    //Write content to excel file    
                    File.WriteAllBytes(hardwareOnlyPath, objExcelPackage.GetAsByteArray());
                }
                message = "File 'Hardware only' has processed succussfully.";
                //processed data in database
                RoboticsRepository objrep = new RoboticsRepository();
                objrep.UpdateProcessedDataforHardwareOnly(lstUnprocessedData);
                return message;
            }
            catch (Exception ex)
            {
                return ex.ToString() + " Method Name: Export_Hardware_Only";
            }
        }
    }


}