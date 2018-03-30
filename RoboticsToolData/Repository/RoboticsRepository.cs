using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboticsToolData.Model;

namespace RoboticsToolData.Repository
{
    public class RoboticsRepository
    {
        public List<RoboticsUnProcessedModel> GetUnProcessedData()
        {
            List<RoboticsUnProcessedModel> lstUnProcessedData = new List<RoboticsUnProcessedModel>();
            try
            {


                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    // tblAddCTN
                    var qAddCTN = entity.tblAddCTNs.Where(qr => qr.IsProcess == false && qr.IsActive == true && qr.IsManualProcessed == false);
                    foreach (var q in qAddCTN)
                    {
                        RoboticsUnProcessedModel objUnProcessedData = new RoboticsUnProcessedModel();
                        objUnProcessedData.Id = q.Id;
                        objUnProcessedData.SubmissionDate = q.SubmissionDate;
                        objUnProcessedData.AgentName = q.AgentName;
                        objUnProcessedData.SalesManager = q.SalesManager;
                        objUnProcessedData.AccountName = q.AccountName;
                        objUnProcessedData.EntityKey = q.EntityKey;
                        objUnProcessedData.SFOpportunityRef = q.SFOpportunityRef;
                        objUnProcessedData.UniqueRef = q.UniqueRef;
                        objUnProcessedData.ConnectionType = q.ConnectionType;
                        objUnProcessedData.CTN = q.CTN;
                        objUnProcessedData.PACCode = q.PACCode;
                        objUnProcessedData.PortDate = q.PortDate;
                        objUnProcessedData.Tariff = q.Tariff;
                        objUnProcessedData.TariffCode = q.TariffCode;
                        objUnProcessedData.VoiceData = q.VoiceData;
                        objUnProcessedData.LineRental = q.LineRental;
                        objUnProcessedData.ContractLength = q.ContractLength;
                        objUnProcessedData.StartDate = q.StartDate;
                        objUnProcessedData.Discount = q.Discount;
                        objUnProcessedData.DiscountLength = q.DiscountLength;
                        objUnProcessedData.SOC1Code = q.SOC1Code;
                        objUnProcessedData.SOC1Charge = q.SOC1Charge;
                        objUnProcessedData.SOC1Discount = q.SOC1Discount;
                        objUnProcessedData.SOC2Code = q.SOC2Code;
                        objUnProcessedData.SOC2Charge = q.SOC2Charge;
                        objUnProcessedData.SOC2Discount = q.SOC2Discount;
                        objUnProcessedData.SOC3Code = q.SOC3Code;
                        objUnProcessedData.SOC3Charge = q.SOC3Charge;
                        objUnProcessedData.SOC3Discount = q.SOC3Discount;
                        objUnProcessedData.SOC4Code = q.SOC4Code;
                        objUnProcessedData.SOC4Charge = q.SOC4Charge;
                        objUnProcessedData.SOC4Discount = q.SOC4Discount;
                        objUnProcessedData.SOC5Code = q.SOC5Code;
                        objUnProcessedData.SOC5Charge = q.SOC5Charge;
                        objUnProcessedData.SOC5Discount = q.SOC5Discount;
                        objUnProcessedData.SOC6Code = q.SOC6Code;
                        objUnProcessedData.SOC6Charge = q.SOC6Charge;
                        objUnProcessedData.SOC6Discount = q.SOC6Discount;
                        objUnProcessedData.SOC7Code = q.SOC7Code;
                        objUnProcessedData.SOC7Charge = q.SOC7Charge;
                        objUnProcessedData.SOC7Discount = q.SOC7Discount;
                        objUnProcessedData.SOC8Code = q.SOC8Code;
                        objUnProcessedData.SOC8Charge = q.SOC8Charge;
                        objUnProcessedData.SOC8Discount = q.SOC8Discount;
                        objUnProcessedData.SOC9Code = q.SOC9Code;
                        objUnProcessedData.SOC9Charge = q.SOC9Charge;
                        objUnProcessedData.SOC9Discount = q.SOC9Discount;
                        objUnProcessedData.SOC10Code = q.SOC10Code;
                        objUnProcessedData.SOC10Charge = q.SOC10Charge;
                        objUnProcessedData.SOC10Discount = q.SOC10Discount;
                        objUnProcessedData.HardwareFund = q.HardwareFund;
                        objUnProcessedData.AirtimeFund = q.AirtimeFund;
                        objUnProcessedData.BuyOutCredit = q.BuyOutCredit;
                        objUnProcessedData.HWModel = q.HWModel;
                        objUnProcessedData.HWCharge = q.HWCharge;
                        objUnProcessedData.SimSize = q.SimSize;
                        objUnProcessedData.ChargingAccount = q.ChargingAccount;
                        objUnProcessedData.DeliveryType = q.DeliveryType;
                        objUnProcessedData.DeliveryCharge = q.DeliveryCharge;
                        objUnProcessedData.DeliveryAddress = q.DeliveryAddress;
                        objUnProcessedData.ProcessMethod = q.ProcessMethod;
                        objUnProcessedData.Comments = q.Comments;
                        objUnProcessedData.IsManualProcessed = q.IsManualProcessed.HasValue ? (bool)q.IsManualProcessed : false;
                        objUnProcessedData.FileName = q.FileName;
                        objUnProcessedData.ReferenceNumber = q.ReferenceNumber;
                        objUnProcessedData.CreatedDate = q.CreatedDate;
                        objUnProcessedData.HWBrand = q.HWBrand;
                        objUnProcessedData.HWSLP = q.HWSLP;
                        objUnProcessedData.SimRequired = q.SimRequired;
                        objUnProcessedData.CommitmentLength = q.CommitmentLength;
                        objUnProcessedData.CommitmentStartDate = q.CommitmentStartDate;
                        objUnProcessedData.InternationalBarRemove = q.InternationalBarRemove;
                        objUnProcessedData.AccessorySKU = q.AccessorySKU;
                        objUnProcessedData.AccessoryVariant = q.AccessoryVariant;
                        objUnProcessedData.AccessoryCharge = q.AccessoryCharge;
                        objUnProcessedData.SimCardSKUCode = q.SimCardSKUCode;
                        objUnProcessedData.ExistingSIMNo = q.ExistingSIMNo;
                        objUnProcessedData.BAN = q.BAN;
                        lstUnProcessedData.Add(objUnProcessedData);

                    }
                    //tblAddCTNWithHardware
                    var qtblAddCTNWithHardware = entity.tblAddCTNWithHardwares.Where(qr => qr.IsProcess == false && qr.IsActive == true && qr.IsManualProcessed == false);
                    foreach (var q in qtblAddCTNWithHardware)
                    {
                        RoboticsUnProcessedModel objUnProcessedData = new RoboticsUnProcessedModel();
                        objUnProcessedData.Id = q.Id;
                        objUnProcessedData.SubmissionDate = q.SubmissionDate;
                        objUnProcessedData.AgentName = q.AgentName;
                        objUnProcessedData.SalesManager = q.SalesManager;
                        objUnProcessedData.AccountName = q.AccountName;
                        objUnProcessedData.EntityKey = q.EntityKey;
                        objUnProcessedData.SFOpportunityRef = q.SFOpportunityRef;
                        objUnProcessedData.UniqueRef = q.UniqueRef;
                        objUnProcessedData.ConnectionType = q.ConnectionType;
                        objUnProcessedData.CTN = q.CTN;
                        objUnProcessedData.PACCode = q.PACCode;
                        objUnProcessedData.PortDate = q.PortDate;
                        objUnProcessedData.Tariff = q.Tariff;
                        objUnProcessedData.TariffCode = q.TariffCode;
                        objUnProcessedData.VoiceData = q.VoiceData;
                        objUnProcessedData.LineRental = q.LineRental;
                        objUnProcessedData.ContractLength = q.ContractLength;
                        objUnProcessedData.StartDate = q.StartDate;
                        objUnProcessedData.Discount = q.Discount;
                        objUnProcessedData.DiscountLength = q.DiscountLength;
                        objUnProcessedData.SOC1Code = q.SOC1Code;
                        objUnProcessedData.SOC1Charge = q.SOC1Charge;
                        objUnProcessedData.SOC1Discount = q.SOC1Discount;
                        objUnProcessedData.SOC2Code = q.SOC2Code;
                        objUnProcessedData.SOC2Charge = q.SOC2Charge;
                        objUnProcessedData.SOC2Discount = q.SOC2Discount;
                        objUnProcessedData.SOC3Code = q.SOC3Code;
                        objUnProcessedData.SOC3Charge = q.SOC3Charge;
                        objUnProcessedData.SOC3Discount = q.SOC3Discount;
                        objUnProcessedData.SOC4Code = q.SOC4Code;
                        objUnProcessedData.SOC4Charge = q.SOC4Charge;
                        objUnProcessedData.SOC4Discount = q.SOC4Discount;
                        objUnProcessedData.SOC5Code = q.SOC5Code;
                        objUnProcessedData.SOC5Charge = q.SOC5Charge;
                        objUnProcessedData.SOC5Discount = q.SOC5Discount;
                        objUnProcessedData.SOC6Code = q.SOC6Code;
                        objUnProcessedData.SOC6Charge = q.SOC6Charge;
                        objUnProcessedData.SOC6Discount = q.SOC6Discount;
                        objUnProcessedData.SOC7Code = q.SOC7Code;
                        objUnProcessedData.SOC7Charge = q.SOC7Charge;
                        objUnProcessedData.SOC7Discount = q.SOC7Discount;
                        objUnProcessedData.SOC8Code = q.SOC8Code;
                        objUnProcessedData.SOC8Charge = q.SOC8Charge;
                        objUnProcessedData.SOC8Discount = q.SOC8Discount;
                        objUnProcessedData.SOC9Code = q.SOC9Code;
                        objUnProcessedData.SOC9Charge = q.SOC9Charge;
                        objUnProcessedData.SOC9Discount = q.SOC9Discount;
                        objUnProcessedData.SOC10Code = q.SOC10Code;
                        objUnProcessedData.SOC10Charge = q.SOC10Charge;
                        objUnProcessedData.SOC10Discount = q.SOC10Discount;
                        objUnProcessedData.HardwareFund = q.HardwareFund;
                        objUnProcessedData.AirtimeFund = q.AirtimeFund;
                        objUnProcessedData.BuyOutCredit = q.BuyOutCredit;
                        objUnProcessedData.HWModel = q.HWModel;
                        objUnProcessedData.HWCharge = q.HWCharge;
                        objUnProcessedData.SimSize = q.SimSize;
                        objUnProcessedData.ChargingAccount = q.ChargingAccount;
                        objUnProcessedData.DeliveryType = q.DeliveryType;
                        objUnProcessedData.DeliveryCharge = q.DeliveryCharge;
                        objUnProcessedData.DeliveryAddress = q.DeliveryAddress;
                        objUnProcessedData.ProcessMethod = q.ProcessMethod;
                        objUnProcessedData.Comments = q.MissingInformation;
                        objUnProcessedData.IsManualProcessed = q.IsManualProcessed.HasValue ? (bool)q.IsManualProcessed : false;
                        objUnProcessedData.FileName = q.FileName;
                        objUnProcessedData.ReferenceNumber = q.ReferenceNumber;
                        objUnProcessedData.CreatedDate = q.CreatedDate;
                        objUnProcessedData.HWBrand = q.HWBrand;
                        objUnProcessedData.HWSLP = q.HWSLP;
                        objUnProcessedData.SimRequired = q.SimRequired;
                        objUnProcessedData.CommitmentLength = q.CommitmentLength;
                        objUnProcessedData.CommitmentStartDate = q.CommitmentStartDate;
                        objUnProcessedData.InternationalBarRemove = q.InternationalBarRemove;
                        objUnProcessedData.AccessorySKU = q.AccessorySKU;
                        objUnProcessedData.AccessoryVariant = q.AccessoryVariant;
                        objUnProcessedData.AccessoryCharge = q.AccessoryCharge;
                        objUnProcessedData.SimCardSKUCode = q.SimCardSKUCode;
                        objUnProcessedData.ExistingSIMNo = q.ExistingSIMNo;
                        objUnProcessedData.BAN = q.BAN;

                        lstUnProcessedData.Add(objUnProcessedData);

                    }
                    // tblResign
                    var qtblResign = entity.tblResigns.Where(qr => qr.IsProcess == false && qr.IsActive == true && qr.IsManualProcessed == false);
                    foreach (var q in qtblResign)
                    {
                        RoboticsUnProcessedModel objUnProcessedData = new RoboticsUnProcessedModel();
                        objUnProcessedData.Id = q.Id;
                        objUnProcessedData.SubmissionDate = q.SubmissionDate;
                        objUnProcessedData.AgentName = q.AgentName;
                        objUnProcessedData.SalesManager = q.SalesManager;
                        objUnProcessedData.AccountName = q.AccountName;
                        objUnProcessedData.EntityKey = q.EntityKey;
                        objUnProcessedData.SFOpportunityRef = q.SFOpportunityRef;
                        objUnProcessedData.UniqueRef = q.UniqueRef;
                        objUnProcessedData.ConnectionType = q.ConnectionType;
                        objUnProcessedData.CTN = q.CTN;
                        objUnProcessedData.PACCode = q.PACCode;
                        objUnProcessedData.PortDate = q.PortDate;
                        objUnProcessedData.Tariff = q.Tariff;
                        objUnProcessedData.TariffCode = q.TariffCode;
                        objUnProcessedData.VoiceData = q.VoiceData;
                        objUnProcessedData.LineRental = q.LineRental;
                        objUnProcessedData.ContractLength = q.ContractLength;
                        objUnProcessedData.StartDate = q.StartDate;
                        objUnProcessedData.Discount = q.Discount;
                        objUnProcessedData.DiscountLength = q.DiscountLength;
                        objUnProcessedData.SOC1Code = q.SOC1Code;
                        objUnProcessedData.SOC1Charge = q.SOC1Charge;
                        objUnProcessedData.SOC1Discount = q.SOC1Discount;
                        objUnProcessedData.SOC2Code = q.SOC2Code;
                        objUnProcessedData.SOC2Charge = q.SOC2Charge;
                        objUnProcessedData.SOC2Discount = q.SOC2Discount;
                        objUnProcessedData.SOC3Code = q.SOC3Code;
                        objUnProcessedData.SOC3Charge = q.SOC3Charge;
                        objUnProcessedData.SOC3Discount = q.SOC3Discount;
                        objUnProcessedData.SOC4Code = q.SOC4Code;
                        objUnProcessedData.SOC4Charge = q.SOC4Charge;
                        objUnProcessedData.SOC4Discount = q.SOC4Discount;
                        objUnProcessedData.SOC5Code = q.SOC5Code;
                        objUnProcessedData.SOC5Charge = q.SOC5Charge;
                        objUnProcessedData.SOC5Discount = q.SOC5Discount;
                        objUnProcessedData.SOC6Code = q.SOC6Code;
                        objUnProcessedData.SOC6Charge = q.SOC6Charge;
                        objUnProcessedData.SOC6Discount = q.SOC6Discount;
                        objUnProcessedData.SOC7Code = q.SOC7Code;
                        objUnProcessedData.SOC7Charge = q.SOC7Charge;
                        objUnProcessedData.SOC7Discount = q.SOC7Discount;
                        objUnProcessedData.SOC8Code = q.SOC8Code;
                        objUnProcessedData.SOC8Charge = q.SOC8Charge;
                        objUnProcessedData.SOC8Discount = q.SOC8Discount;
                        objUnProcessedData.SOC9Code = q.SOC9Code;
                        objUnProcessedData.SOC9Charge = q.SOC9Charge;
                        objUnProcessedData.SOC9Discount = q.SOC9Discount;
                        objUnProcessedData.SOC10Code = q.SOC10Code;
                        objUnProcessedData.SOC10Charge = q.SOC10Charge;
                        objUnProcessedData.SOC10Discount = q.SOC10Discount;
                        objUnProcessedData.HardwareFund = q.HardwareFund;
                        objUnProcessedData.AirtimeFund = q.AirtimeFund;
                        objUnProcessedData.BuyOutCredit = q.BuyOutCredit;
                        objUnProcessedData.HWModel = q.HWModel;
                        objUnProcessedData.HWCharge = q.HWCharge;
                        objUnProcessedData.SimSize = q.SimSize;
                        objUnProcessedData.ChargingAccount = q.ChargingAccount;
                        objUnProcessedData.DeliveryType = q.DeliveryType;
                        objUnProcessedData.DeliveryCharge = q.DeliveryCharge;
                        objUnProcessedData.DeliveryAddress = q.DeliveryAddress;
                        objUnProcessedData.ProcessMethod = q.ProcessMethod;
                        objUnProcessedData.Comments = q.MissingInformation;
                        objUnProcessedData.IsManualProcessed = q.IsManualProcessed.HasValue ? (bool)q.IsManualProcessed : false;
                        objUnProcessedData.FileName = q.FileName;
                        objUnProcessedData.ReferenceNumber = q.ReferenceNumber;
                        objUnProcessedData.CreatedDate = q.CreatedDate;
                        objUnProcessedData.HWBrand = q.HWBrand;
                        objUnProcessedData.HWSLP = q.HWSLP;
                        objUnProcessedData.SimRequired = q.SimRequired;
                        objUnProcessedData.BAN = q.BAN;
                        objUnProcessedData.InternationalBarRemove = q.InternationalBarRemove;
                        objUnProcessedData.HardwareSKUCode = q.HardwareSKUCode;
                        objUnProcessedData.HardwareVariant = q.HardwareVariant;
                        objUnProcessedData.ExistingSIMNo = q.ExistingSIMNo;
                        objUnProcessedData.SimCardSKUCode = q.SimCardSKUCode;


                        lstUnProcessedData.Add(objUnProcessedData);

                    }
                    // tblResignWithHardwares
                    var qtblResignWithHardwares = entity.tblResignWithHardwares.Where(qr => qr.IsProcess == false && qr.IsActive == true && qr.IsManualProcessed == false);
                    foreach (var q in qtblResignWithHardwares)
                    {
                        RoboticsUnProcessedModel objUnProcessedData = new RoboticsUnProcessedModel();
                        objUnProcessedData.Id = q.Id;
                        objUnProcessedData.SubmissionDate = q.SubmissionDate;
                        objUnProcessedData.AgentName = q.AgentName;
                        objUnProcessedData.SalesManager = q.SalesManager;
                        objUnProcessedData.AccountName = q.AccountName;
                        objUnProcessedData.EntityKey = q.EntityKey;
                        objUnProcessedData.SFOpportunityRef = q.SFOpportunityRef;
                        objUnProcessedData.UniqueRef = q.UniqueRef;
                        objUnProcessedData.ConnectionType = q.ConnectionType;
                        objUnProcessedData.CTN = q.CTN;
                        objUnProcessedData.PACCode = q.PACCode;
                        objUnProcessedData.PortDate = q.PortDate;
                        objUnProcessedData.Tariff = q.Tariff;
                        objUnProcessedData.TariffCode = q.TariffCode;
                        objUnProcessedData.VoiceData = q.VoiceData;
                        objUnProcessedData.LineRental = q.LineRental;
                        objUnProcessedData.ContractLength = q.ContractLength;
                        objUnProcessedData.StartDate = q.StartDate;
                        objUnProcessedData.Discount = q.Discount;
                        objUnProcessedData.DiscountLength = q.DiscountLength;
                        objUnProcessedData.SOC1Code = q.SOC1Code;
                        objUnProcessedData.SOC1Charge = q.SOC1Charge;
                        objUnProcessedData.SOC1Discount = q.SOC1Discount;
                        objUnProcessedData.SOC2Code = q.SOC2Code;
                        objUnProcessedData.SOC2Charge = q.SOC2Charge;
                        objUnProcessedData.SOC2Discount = q.SOC2Discount;
                        objUnProcessedData.SOC3Code = q.SOC3Code;
                        objUnProcessedData.SOC3Charge = q.SOC3Charge;
                        objUnProcessedData.SOC3Discount = q.SOC3Discount;
                        objUnProcessedData.SOC4Code = q.SOC4Code;
                        objUnProcessedData.SOC4Charge = q.SOC4Charge;
                        objUnProcessedData.SOC4Discount = q.SOC4Discount;
                        objUnProcessedData.SOC5Code = q.SOC5Code;
                        objUnProcessedData.SOC5Charge = q.SOC5Charge;
                        objUnProcessedData.SOC5Discount = q.SOC5Discount;
                        objUnProcessedData.SOC6Code = q.SOC6Code;
                        objUnProcessedData.SOC6Charge = q.SOC6Charge;
                        objUnProcessedData.SOC6Discount = q.SOC6Discount;
                        objUnProcessedData.SOC7Code = q.SOC7Code;
                        objUnProcessedData.SOC7Charge = q.SOC7Charge;
                        objUnProcessedData.SOC7Discount = q.SOC7Discount;
                        objUnProcessedData.SOC8Code = q.SOC8Code;
                        objUnProcessedData.SOC8Charge = q.SOC8Charge;
                        objUnProcessedData.SOC8Discount = q.SOC8Discount;
                        objUnProcessedData.SOC9Code = q.SOC9Code;
                        objUnProcessedData.SOC9Charge = q.SOC9Charge;
                        objUnProcessedData.SOC9Discount = q.SOC9Discount;
                        objUnProcessedData.SOC10Code = q.SOC10Code;
                        objUnProcessedData.SOC10Charge = q.SOC10Charge;
                        objUnProcessedData.SOC10Discount = q.SOC10Discount;
                        objUnProcessedData.HardwareFund = q.HardwareFund;
                        objUnProcessedData.AirtimeFund = q.AirtimeFund;
                        objUnProcessedData.BuyOutCredit = q.BuyOutCredit;
                        objUnProcessedData.HWModel = q.HWModel;
                        objUnProcessedData.HWCharge = q.HWCharge;
                        objUnProcessedData.SimSize = q.SimSize;
                        objUnProcessedData.ChargingAccount = q.ChargingAccount;
                        objUnProcessedData.DeliveryType = q.DeliveryType;
                        objUnProcessedData.DeliveryCharge = q.DeliveryCharge;
                        objUnProcessedData.DeliveryAddress = q.DeliveryAddress;
                        objUnProcessedData.ProcessMethod = q.ProcessMethod;
                        objUnProcessedData.Comments = q.MissingInformation;
                        objUnProcessedData.IsManualProcessed = q.IsManualProcessed.HasValue ? (bool)q.IsManualProcessed : false;
                        objUnProcessedData.FileName = q.FileName;
                        objUnProcessedData.ReferenceNumber = q.ReferenceNumber;
                        objUnProcessedData.CreatedDate = q.CreatedDate;
                        objUnProcessedData.HWBrand = q.HWBrand;
                        objUnProcessedData.HWSLP = q.HWSLP;
                        objUnProcessedData.SimRequired = q.SimRequired;
                        objUnProcessedData.BAN = q.BAN;
                        objUnProcessedData.InternationalBarRemove = q.InternationalBarRemove;
                        objUnProcessedData.HardwareSKUCode = q.HardwareSKUCode;
                        objUnProcessedData.HardwareVariant = q.HardwareVariant;
                        objUnProcessedData.ExistingSIMNo = q.ExistingSIMNo;
                        objUnProcessedData.SimCardSKUCode = q.SimCardSKUCode;
                        objUnProcessedData.AccessorySKU = q.AccessorySKU;
                        objUnProcessedData.AccessoryVariant = q.AccessoryVariant;
                        objUnProcessedData.AccessoryCharge = q.AccessoryCharge;
                        lstUnProcessedData.Add(objUnProcessedData);

                    }

                    // tblAirtimeCredit
                    var qtblAirtimeCredit = entity.tblAirtimeCredits.Where(qr => qr.IsProcess == false && qr.IsActive == true && qr.IsManualProcessed == false);
                    foreach (var q in qtblAirtimeCredit)
                    {
                        RoboticsUnProcessedModel objUnProcessedData = new RoboticsUnProcessedModel();
                        objUnProcessedData.Id = q.Id;
                        objUnProcessedData.SubmissionDate = q.SubmissionDate;
                        objUnProcessedData.AgentName = q.AgentName;
                        objUnProcessedData.SalesManager = q.SalesManager;
                        objUnProcessedData.AccountName = q.AccountName;
                        objUnProcessedData.EntityKey = q.EntityKey;
                        objUnProcessedData.SFOpportunityRef = q.SFOpportunityRef;
                        objUnProcessedData.UniqueRef = q.UniqueRef;
                        objUnProcessedData.ConnectionType = q.ConnectionType;
                        objUnProcessedData.CTN = q.CTN;
                        objUnProcessedData.PACCode = q.PACCode;
                        objUnProcessedData.PortDate = q.PortDate;
                        objUnProcessedData.Tariff = q.Tariff;
                        objUnProcessedData.TariffCode = q.TariffCode;
                        objUnProcessedData.VoiceData = q.VoiceData;
                        objUnProcessedData.LineRental = q.LineRental;
                        objUnProcessedData.ContractLength = q.ContractLength;
                        objUnProcessedData.StartDate = q.StartDate;
                        objUnProcessedData.Discount = q.Discount;
                        objUnProcessedData.DiscountLength = q.DiscountLength;
                        objUnProcessedData.SOC1Code = q.SOC1Code;
                        objUnProcessedData.SOC1Charge = q.SOC1Charge;
                        objUnProcessedData.SOC1Discount = q.SOC1Discount;
                        objUnProcessedData.SOC2Code = q.SOC2Code;
                        objUnProcessedData.SOC2Charge = q.SOC2Charge;
                        objUnProcessedData.SOC2Discount = q.SOC2Discount;
                        objUnProcessedData.SOC3Code = q.SOC3Code;
                        objUnProcessedData.SOC3Charge = q.SOC3Charge;
                        objUnProcessedData.SOC3Discount = q.SOC3Discount;
                        objUnProcessedData.SOC4Code = q.SOC4Code;
                        objUnProcessedData.SOC4Charge = q.SOC4Charge;
                        objUnProcessedData.SOC4Discount = q.SOC4Discount;
                        objUnProcessedData.SOC5Code = q.SOC5Code;
                        objUnProcessedData.SOC5Charge = q.SOC5Charge;
                        objUnProcessedData.SOC5Discount = q.SOC5Discount;
                        objUnProcessedData.SOC6Code = q.SOC6Code;
                        objUnProcessedData.SOC6Charge = q.SOC6Charge;
                        objUnProcessedData.SOC6Discount = q.SOC6Discount;
                        objUnProcessedData.SOC7Code = q.SOC7Code;
                        objUnProcessedData.SOC7Charge = q.SOC7Charge;
                        objUnProcessedData.SOC7Discount = q.SOC7Discount;
                        objUnProcessedData.SOC8Code = q.SOC8Code;
                        objUnProcessedData.SOC8Charge = q.SOC8Charge;
                        objUnProcessedData.SOC8Discount = q.SOC8Discount;
                        objUnProcessedData.SOC9Code = q.SOC9Code;
                        objUnProcessedData.SOC9Charge = q.SOC9Charge;
                        objUnProcessedData.SOC9Discount = q.SOC9Discount;
                        objUnProcessedData.SOC10Code = q.SOC10Code;
                        objUnProcessedData.SOC10Charge = q.SOC10Charge;
                        objUnProcessedData.SOC10Discount = q.SOC10Discount;
                        objUnProcessedData.HardwareFund = q.HardwareFund;
                        objUnProcessedData.AirtimeFund = q.AirtimeFund;
                        objUnProcessedData.BuyOutCredit = q.BuyOutCredit;
                        objUnProcessedData.HWModel = q.HWModel;
                        objUnProcessedData.HWCharge = q.HWCharge;
                        objUnProcessedData.SimSize = q.SimSize;
                        objUnProcessedData.ChargingAccount = q.ChargingAccount;
                        objUnProcessedData.DeliveryType = q.DeliveryType;
                        objUnProcessedData.DeliveryCharge = q.DeliveryCharge;
                        objUnProcessedData.DeliveryAddress = q.DeliveryAddress;
                        objUnProcessedData.ProcessMethod = q.ProcessMethod;
                        objUnProcessedData.Comments = q.Comments;
                        objUnProcessedData.IsManualProcessed = q.IsManualProcessed.HasValue ? (bool)q.IsManualProcessed : false;
                        objUnProcessedData.FileName = q.FileName;
                        objUnProcessedData.ReferenceNumber = q.ReferenceNumber;
                        objUnProcessedData.CreatedDate = q.CreatedDate;
                        objUnProcessedData.HWBrand = q.HWBrand;
                        objUnProcessedData.HWSLP = q.HWSLP;
                        objUnProcessedData.SimRequired = q.SimRequired;
                        objUnProcessedData.AirtimeBAN = q.AirtimeBAN;
                        objUnProcessedData.HardwareBAN = q.HardwareBAN;
                        objUnProcessedData.HardwareSKUCode = q.HardwareSKUCode;
                        lstUnProcessedData.Add(objUnProcessedData);

                    }
                    // tblHardwareCredit
                    var qtblHardwareCredit = entity.tblHardwareCredits.Where(qr => qr.IsProcess == false && qr.IsActive == true && qr.IsManualProcessed == false);
                    foreach (var q in qtblHardwareCredit)
                    {
                        RoboticsUnProcessedModel objUnProcessedData = new RoboticsUnProcessedModel();
                        objUnProcessedData.Id = q.Id;
                        objUnProcessedData.SubmissionDate = q.SubmissionDate;
                        objUnProcessedData.AgentName = q.AgentName;
                        objUnProcessedData.SalesManager = q.SalesManager;
                        objUnProcessedData.AccountName = q.AccountName;
                        objUnProcessedData.EntityKey = q.EntityKey;
                        objUnProcessedData.SFOpportunityRef = q.SFOpportunityRef;
                        objUnProcessedData.UniqueRef = q.UniqueRef;
                        objUnProcessedData.ConnectionType = q.ConnectionType;
                        objUnProcessedData.CTN = q.CTN;
                        objUnProcessedData.PACCode = q.PACCode;
                        objUnProcessedData.PortDate = q.PortDate;
                        objUnProcessedData.Tariff = q.Tariff;
                        objUnProcessedData.TariffCode = q.TariffCode;
                        objUnProcessedData.VoiceData = q.VoiceData;
                        objUnProcessedData.LineRental = q.LineRental;
                        objUnProcessedData.ContractLength = q.ContractLength;
                        objUnProcessedData.StartDate = q.StartDate;
                        objUnProcessedData.Discount = q.Discount;
                        objUnProcessedData.DiscountLength = q.DiscountLength;
                        objUnProcessedData.SOC1Code = q.SOC1Code;
                        objUnProcessedData.SOC1Charge = q.SOC1Charge;
                        objUnProcessedData.SOC1Discount = q.SOC1Discount;
                        objUnProcessedData.SOC2Code = q.SOC2Code;
                        objUnProcessedData.SOC2Charge = q.SOC2Charge;
                        objUnProcessedData.SOC2Discount = q.SOC2Discount;
                        objUnProcessedData.SOC3Code = q.SOC3Code;
                        objUnProcessedData.SOC3Charge = q.SOC3Charge;
                        objUnProcessedData.SOC3Discount = q.SOC3Discount;
                        objUnProcessedData.SOC4Code = q.SOC4Code;
                        objUnProcessedData.SOC4Charge = q.SOC4Charge;
                        objUnProcessedData.SOC4Discount = q.SOC4Discount;
                        objUnProcessedData.SOC5Code = q.SOC5Code;
                        objUnProcessedData.SOC5Charge = q.SOC5Charge;
                        objUnProcessedData.SOC5Discount = q.SOC5Discount;
                        objUnProcessedData.SOC6Code = q.SOC6Code;
                        objUnProcessedData.SOC6Charge = q.SOC6Charge;
                        objUnProcessedData.SOC6Discount = q.SOC6Discount;
                        objUnProcessedData.SOC7Code = q.SOC7Code;
                        objUnProcessedData.SOC7Charge = q.SOC7Charge;
                        objUnProcessedData.SOC7Discount = q.SOC7Discount;
                        objUnProcessedData.SOC8Code = q.SOC8Code;
                        objUnProcessedData.SOC8Charge = q.SOC8Charge;
                        objUnProcessedData.SOC8Discount = q.SOC8Discount;
                        objUnProcessedData.SOC9Code = q.SOC9Code;
                        objUnProcessedData.SOC9Charge = q.SOC9Charge;
                        objUnProcessedData.SOC9Discount = q.SOC9Discount;
                        objUnProcessedData.SOC10Code = q.SOC10Code;
                        objUnProcessedData.SOC10Charge = q.SOC10Charge;
                        objUnProcessedData.SOC10Discount = q.SOC10Discount;
                        objUnProcessedData.HardwareFund = q.HardwareFund;
                        objUnProcessedData.AirtimeFund = q.AirtimeFund;
                        objUnProcessedData.BuyOutCredit = q.BuyOutCredit;
                        objUnProcessedData.HWModel = q.HWModel;
                        objUnProcessedData.HWCharge = q.HWCharge;
                        objUnProcessedData.SimSize = q.SimSize;
                        objUnProcessedData.ChargingAccount = q.ChargingAccount;
                        objUnProcessedData.DeliveryType = q.DeliveryType;
                        objUnProcessedData.DeliveryCharge = q.DeliveryCharge;
                        objUnProcessedData.DeliveryAddress = q.DeliveryAddress;
                        objUnProcessedData.ProcessMethod = q.ProcessMethod;
                        objUnProcessedData.Comments = q.Comments;
                        objUnProcessedData.IsManualProcessed = q.IsManualProcessed.HasValue ? (bool)q.IsManualProcessed : false;
                        objUnProcessedData.FileName = q.FileName;
                        objUnProcessedData.ReferenceNumber = q.ReferenceNumber;
                        objUnProcessedData.CreatedDate = q.CreatedDate;
                        objUnProcessedData.HWBrand = q.HWBrand;
                        objUnProcessedData.HWSLP = q.HWSLP;
                        objUnProcessedData.SimRequired = q.SimRequired;
                        objUnProcessedData.AirtimeBAN = q.AirtimeBAN;
                        objUnProcessedData.HardwareBAN = q.HardwareBAN;
                        lstUnProcessedData.Add(objUnProcessedData);

                    }

                    // tbl
                    var qtbltblHardwareOnlies = entity.tblHardwareOnlies.Where(qr => qr.IsProcess == false && qr.IsActive == true && qr.IsManualProcessed == false);
                    foreach (var q in qtbltblHardwareOnlies)
                    {
                        RoboticsUnProcessedModel objUnProcessedData = new RoboticsUnProcessedModel();
                        objUnProcessedData.Id = q.Id;
                        objUnProcessedData.SalesManager = q.SalesManager;
                        objUnProcessedData.AccountName = q.AccountName;
                        objUnProcessedData.ConnectionType = q.ConnectionType;
                        objUnProcessedData.CTN = q.CTN;
                        objUnProcessedData.BAN = q.BAN;
                        objUnProcessedData.NTLogin = q.NTLogin;
                        objUnProcessedData.SimSize = q.SimCardSize;
                        objUnProcessedData.DeliveryType = q.DeliveryType;
                        objUnProcessedData.DeliveryCharge = q.DeliveryCharge;
                        objUnProcessedData.DeliveryAddress = q.DeliveryAddress;
                        objUnProcessedData.IsManualProcessed = q.IsManualProcessed.HasValue ? (bool)q.IsManualProcessed : false;
                        objUnProcessedData.FileName = q.FileName;
                        objUnProcessedData.ReferenceNumber = q.ReferenceNumber;
                        objUnProcessedData.CreatedDate = q.CreatedDate;
                        objUnProcessedData.HWBrand = q.HardwareBrand;
                        objUnProcessedData.HWSLP = q.HardwareSLP;
                        objUnProcessedData.HardwareCharge = q.HardwareCharge;
                        objUnProcessedData.HardwareVariant = q.HardwareVariant;
                        objUnProcessedData.HardwareColourVariant = q.HardwareColourVariant;
                        objUnProcessedData.AccessoryDescription = q.AccessoryDescription;
                        objUnProcessedData.AccessoryCos = q.AccessoryCost;
                        objUnProcessedData.ChargingAccountHardwareORAirtime = q.ChargingAccountHardwareORAirtime;
                        objUnProcessedData.SimRequired = q.SimCardRequired;
                        objUnProcessedData.Comments = q.AdditionalComments;
                        objUnProcessedData.SubmissionDate = q.Subscription;
                        objUnProcessedData.HardwareSKUCode = q.HardwareSKUCode;
                        objUnProcessedData.AccessorySKU = q.AccessorySKU;
                        objUnProcessedData.AccessoryVariant = q.AccessoryVariant;
                        objUnProcessedData.SimCardSKUCode = q.SimCardSKUCode;
                        objUnProcessedData.ExistingSIMNo = q.ExistingSIMNo;
                        lstUnProcessedData.Add(objUnProcessedData);


                    }

                }
                return lstUnProcessedData;
            }
            catch (Exception ex)
            {
                return lstUnProcessedData;
            }
        }

        public bool updateManualProcessedData(int id, string ConnectionType)
        {
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    switch (ConnectionType.ToLower())
                    {
                        case "add ctn":
                            tblAddCTN objtblAddCTN = new tblAddCTN();
                            objtblAddCTN = entity.tblAddCTNs.Where(q => q.Id == id).FirstOrDefault();
                            if (objtblAddCTN != null)
                            {
                                objtblAddCTN.IsManualProcessed = true;
                                objtblAddCTN.IsProcess = true;
                                entity.Entry(objtblAddCTN).State = System.Data.Entity.EntityState.Modified;
                                entity.SaveChanges();

                            }
                            break;

                        case "add ctn with hardware":
                            tblAddCTNWithHardware objtblAddCTNHW = new tblAddCTNWithHardware();
                            objtblAddCTNHW = entity.tblAddCTNWithHardwares.Where(q => q.Id == id).FirstOrDefault();
                            if (objtblAddCTNHW != null)
                            {
                                objtblAddCTNHW.IsManualProcessed = true;
                                objtblAddCTNHW.IsProcess = true;
                                entity.Entry(objtblAddCTNHW).State = System.Data.Entity.EntityState.Modified;
                                entity.SaveChanges();

                            }
                            break;
                        case "resign":
                            tblResign objtblResign = new tblResign();
                            objtblResign = entity.tblResigns.Where(q => q.Id == id).FirstOrDefault();
                            if (objtblResign != null)
                            {
                                objtblResign.IsManualProcessed = true;
                                objtblResign.IsProcess = true;
                                entity.Entry(objtblResign).State = System.Data.Entity.EntityState.Modified;
                                entity.SaveChanges();

                            }
                            break;
                        case "resign with hardware":
                            tblResignWithHardware objtblResignHW = new tblResignWithHardware();
                            objtblResignHW = entity.tblResignWithHardwares.Where(q => q.Id == id).FirstOrDefault();
                            if (objtblResignHW != null)
                            {
                                objtblResignHW.IsManualProcessed = true;
                                objtblResignHW.IsProcess = true;
                                entity.Entry(objtblResignHW).State = System.Data.Entity.EntityState.Modified;
                                entity.SaveChanges();

                            }
                            break;
                        case "airtime credit":
                            tblAirtimeCredit objtblAirtimeCredit = new tblAirtimeCredit();
                            objtblAirtimeCredit = entity.tblAirtimeCredits.Where(q => q.Id == id).FirstOrDefault();
                            if (objtblAirtimeCredit != null)
                            {
                                objtblAirtimeCredit.IsManualProcessed = true;
                                objtblAirtimeCredit.IsProcess = true;
                                entity.Entry(objtblAirtimeCredit).State = System.Data.Entity.EntityState.Modified;
                                entity.SaveChanges();

                            }
                            break;
                        case "hardware credit":
                            tblHardwareCredit objtblHardwareCredit = new tblHardwareCredit();
                            objtblHardwareCredit = entity.tblHardwareCredits.Where(q => q.Id == id).FirstOrDefault();
                            if (objtblHardwareCredit != null)
                            {
                                objtblHardwareCredit.IsManualProcessed = true;
                                objtblHardwareCredit.IsProcess = true;
                                entity.Entry(objtblHardwareCredit).State = System.Data.Entity.EntityState.Modified;
                                entity.SaveChanges();

                            }
                            break;
                        case "hardware only":
                            tblHardwareOnly objtblHardwareOnly = new tblHardwareOnly();
                            objtblHardwareOnly = entity.tblHardwareOnlies.Where(q => q.Id == id).FirstOrDefault();
                            if (objtblHardwareOnly != null)
                            {
                                objtblHardwareOnly.IsManualProcessed = true;
                                objtblHardwareOnly.IsProcess = true;
                                entity.Entry(objtblHardwareOnly).State = System.Data.Entity.EntityState.Modified;
                                entity.SaveChanges();

                            }
                            break;
                        default:
                            break;


                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateProcessedDataforAddCTN(List<RoboticsUnProcessedModel> lstrobolst)
        {
           
            bool updated = false;
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    foreach (var qr in lstrobolst)
                    {
                        tblAddCTN objtbladdCTN = new tblAddCTN();
                        objtbladdCTN = entity.tblAddCTNs.Where(q => q.Id == qr.Id).First();
                        objtbladdCTN.IsProcess = true;
                        objtbladdCTN.ProcessDate = DateTime.Now;
                        entity.Entry(objtbladdCTN).State = System.Data.Entity.EntityState.Modified;
                        entity.SaveChanges();
                        updated = true;

                    }
                    return updated;

                }
            }
            catch (Exception ex)
            {
                return updated;
            }
        }

        public bool UpdateProcessedDataforAddCTNWithHWR(List<RoboticsUnProcessedModel> lstrobolst)
        {
            bool updated = false;
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    foreach (var qr in lstrobolst)
                    {
                        tblAddCTNWithHardware objtbladdCTNWHHardware = new tblAddCTNWithHardware();
                        objtbladdCTNWHHardware = entity.tblAddCTNWithHardwares.Where(q => q.Id == qr.Id).First();
                        objtbladdCTNWHHardware.IsProcess = true;
                        objtbladdCTNWHHardware.ProcessDate = DateTime.Now;
                        entity.Entry(objtbladdCTNWHHardware).State = System.Data.Entity.EntityState.Modified;
                        entity.SaveChanges();
                        updated = true;

                    }
                    return updated;
                }
            }
            catch (Exception ex)
            {
                return updated;
            }
        }

        public bool UpdateProcessedDataforResign(List<RoboticsUnProcessedModel> lstrobolst)
        {
            bool updated = false;
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    foreach (var qr in lstrobolst)
                    {
                        tblResign objtblResigns = new tblResign();
                        objtblResigns = entity.tblResigns.Where(q => q.Id == qr.Id).First();
                        objtblResigns.IsProcess = true;
                        objtblResigns.ProcessDate = DateTime.Now;
                        entity.Entry(objtblResigns).State = System.Data.Entity.EntityState.Modified;
                        entity.SaveChanges();
                        updated = true;

                    }
                    return updated;
                }
            }
            catch (Exception ex)
            {
                return updated;
            }
        }

        public bool UpdateProcessedDataforResignWTHWR(List<RoboticsUnProcessedModel> lstrobolst)
        {
            bool updated = false;
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    foreach (var qr in lstrobolst)
                    {
                        tblResignWithHardware objtblResignWTHWR = new tblResignWithHardware();
                        objtblResignWTHWR = entity.tblResignWithHardwares.Where(q => q.Id == qr.Id).First();
                        objtblResignWTHWR.IsProcess = true;
                        objtblResignWTHWR.ProcessDate = DateTime.Now;
                        entity.Entry(objtblResignWTHWR).State = System.Data.Entity.EntityState.Modified;
                        entity.SaveChanges();
                        updated = true;

                    }
                    return updated;
                }
            } 
            catch (Exception ex)
            {
                return updated;
            }
}

        public bool UpdateProcessedDataforAirtimeCredit(List<RoboticsUnProcessedModel> lstrobolst)
        {
            bool updated = false;
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    foreach (var qr in lstrobolst)
                    {
                        tblAirtimeCredit objtblAirtimeCredit = new tblAirtimeCredit();
                        objtblAirtimeCredit = entity.tblAirtimeCredits.Where(q => q.Id == qr.Id).First();
                        objtblAirtimeCredit.IsProcess = true;
                        objtblAirtimeCredit.ProcessDate = DateTime.Now;
                        entity.Entry(objtblAirtimeCredit).State = System.Data.Entity.EntityState.Modified;
                        entity.SaveChanges();
                        updated = true;

                    }
                    return updated;
                }
            }
            catch (Exception ex)
            {
                return updated;
            }
        }

        public bool UpdateProcessedDataforHardwareCredit(List<RoboticsUnProcessedModel> lstrobolst)
        {
            bool updated = false;
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    foreach (var qr in lstrobolst)
                    {
                        tblHardwareCredit objtblhwrCredit = new tblHardwareCredit();
                        objtblhwrCredit = entity.tblHardwareCredits.Where(q => q.Id == qr.Id).First();
                        objtblhwrCredit.IsProcess = true;
                        objtblhwrCredit.ProcessDate = DateTime.Now;
                        entity.Entry(objtblhwrCredit).State = System.Data.Entity.EntityState.Modified;
                        entity.SaveChanges();
                        updated = true;

                    }
                    return updated;
                }
            }
            catch (Exception ex)
            {
                return updated;
            }
        }

        public bool UpdateProcessedDataforHardwareOnly(List<RoboticsUnProcessedModel> lstrobolst)
        {
            bool updated = false;
            try
            {
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    foreach (var qr in lstrobolst)
                    {
                        tblHardwareOnly objtblhwrOnly = new tblHardwareOnly();
                        objtblhwrOnly = entity.tblHardwareOnlies.Where(q => q.Id == qr.Id).First();
                        objtblhwrOnly.IsProcess = true;
                        objtblhwrOnly.ProcessDate = DateTime.Now;
                        entity.Entry(objtblhwrOnly).State = System.Data.Entity.EntityState.Modified;
                        entity.SaveChanges();
                        updated = true;

                    }
                    return updated;
                }
            }
            catch (Exception ex)
            {
                return updated;
            }
        }

        public DataSet GetInvalidData()
        {
            DataSet ds = new DataSet();
            try
            {
                //  List<tblInvalidData> lsttblInvalidData=new List<tblInvalidData>();
                using (RoboticDataEntities entity = new RoboticDataEntities())
                {
                    var qryInvalid = entity.tblInvalidDatas.Where(q => q.IsActive == true).ToList();
                    if (qryInvalid != null && qryInvalid.Count > 0)
                    {
                        DataTable dt = new DataTable();
                        dt.TableName = "Invalid_Other_Data";
                        dt.Clear();
                        dt.Columns.Add("Submission_Date");
                        dt.Columns.Add("Agent_Name");
                        dt.Columns.Add("Sales_Manager");
                        dt.Columns.Add("Account_Name");
                        dt.Columns.Add("Entity_Key");
                        dt.Columns.Add("1SF_Opportunity_Ref");
                        dt.Columns.Add("Unique_Ref");
                        dt.Columns.Add("Connection_Type");
                        dt.Columns.Add("CTN");
                        dt.Columns.Add("PAC_Code");
                        dt.Columns.Add("Port_Date");
                        dt.Columns.Add("Tariff");
                        dt.Columns.Add("Tariff_Code");
                        dt.Columns.Add("Voice_Data");
                        dt.Columns.Add("Line_Rental");
                        dt.Columns.Add("Contract_Length");
                        dt.Columns.Add("Start_Date");
                        dt.Columns.Add("Discount");
                        dt.Columns.Add("Discount_Length");
                        dt.Columns.Add("SOC1_Code");
                        dt.Columns.Add("SOC1_Charge");
                        dt.Columns.Add("SOC1_Discount");
                        dt.Columns.Add("SOC2_Code");
                        dt.Columns.Add("SOC2_Charge");
                        dt.Columns.Add("SOC2_Discount");
                        dt.Columns.Add("SOC3_Code");
                        dt.Columns.Add("SOC3_Charge");
                        dt.Columns.Add("SOC3_Discount");
                        dt.Columns.Add("SOC4_Code");
                        dt.Columns.Add("SOC4_Charge");
                        dt.Columns.Add("SOC4_Discount");
                        dt.Columns.Add("SOC5_Code");
                        dt.Columns.Add("SOC5_Charge");
                        dt.Columns.Add("SOC5_Discount");
                        dt.Columns.Add("SOC6_Code");
                        dt.Columns.Add("SOC6_Charge");
                        dt.Columns.Add("SOC6_Discount");
                        dt.Columns.Add("SOC7_Code");
                        dt.Columns.Add("SOC7_Charge");
                        dt.Columns.Add("SOC7_Discount");
                        dt.Columns.Add("SOC8_Code");
                        dt.Columns.Add("SOC8_Charge");
                        dt.Columns.Add("SOC8_Discount");
                        dt.Columns.Add("SOC9_Code");
                        dt.Columns.Add("SOC9_Charge");
                        dt.Columns.Add("SOC9_Discount");
                        dt.Columns.Add("SOC10_Code");
                        dt.Columns.Add("SOC10_Charge");
                        dt.Columns.Add("SOC10_Discount");
                        dt.Columns.Add("Hardware_Fund");
                        dt.Columns.Add("Airtime_Fund");
                        dt.Columns.Add("BuyOut_Credit");
                        dt.Columns.Add("HW_Brand");
                        dt.Columns.Add("HW_Model");
                        dt.Columns.Add("HW_SLP");
                        dt.Columns.Add("HW_Charge");
                        dt.Columns.Add("Sim_Required");
                        dt.Columns.Add("Sim_Size");
                        dt.Columns.Add("Charging_Account");
                        dt.Columns.Add("Delivery_Type");
                        dt.Columns.Add("Delivery_Charge");
                        dt.Columns.Add("Delivery_Address");
                        dt.Columns.Add("Process_Method");
                        dt.Columns.Add("Comments");
                        dt.Columns.Add("Missing Information");

                        foreach (var q in qryInvalid)
                        {
                            DataRow dr = dt.NewRow();
                            dr["Submission_Date"] = q.SubmissionDate;
                            dr["Agent_Name"] = q.AgentName;
                            dr["Sales_Manager"] = q.SalesManager;
                            dr["Account_Name"] = q.AccountName;
                            dr["Entity_Key"] = q.EntityKey;
                            dr["1SF_Opportunity_Ref"] = q.SFOpportunityRef;
                            dr["Unique_Ref"] = q.UniqueRef;
                            dr["Connection_Type"] = q.ConnectionType;
                            dr["CTN"] = q.CTN;
                            dr["PAC_Code"] = q.PACCode;
                            dr["Port_Date"] = q.PortDate;
                            dr["Tariff"] = q.Tariff;
                            dr["Tariff_Code"] = q.TariffCode;
                            dr["Voice_Data"] = q.VoiceData;
                            dr["Line_Rental"] = q.LineRental;
                            dr["Contract_Length"] = q.ContractLength;
                            dr["Start_Date"] = q.StartDate;
                            dr["Discount"] = q.Discount;
                            dr["Discount_Length"] = q.DiscountLength;
                            dr["SOC1_Code"] = q.SOC1Code;
                            dr["SOC1_Charge"] = q.SOC1Charge;
                            dr["SOC1_Discount"] = q.SOC1Discount;
                            dr["SOC2_Code"] = q.SOC2Code;
                            dr["SOC2_Charge"] = q.SOC2Charge;
                            dr["SOC2_Discount"] = q.SOC2Discount;
                            dr["SOC3_Code"] = q.SOC3Code;
                            dr["SOC3_Charge"] = q.SOC3Charge;
                            dr["SOC3_Discount"] = q.SOC3Discount;
                            dr["SOC4_Code"] = q.SOC4Code;
                            dr["SOC4_Charge"] = q.SOC4Charge;
                            dr["SOC4_Discount"] = q.SOC4Discount;
                            dr["SOC5_Code"] = q.SOC5Code;
                            dr["SOC5_Charge"] = q.SOC5Charge;
                            dr["SOC5_Discount"] = q.SOC5Discount;
                            dr["SOC6_Code"] = q.SOC6Code;
                            dr["SOC6_Charge"] = q.SOC6Charge;
                            dr["SOC6_Discount"] = q.SOC6Discount;
                            dr["SOC7_Code"] = q.SOC7Code;
                            dr["SOC7_Charge"] = q.SOC7Charge;
                            dr["SOC7_Discount"] = q.SOC7Discount;
                            dr["SOC8_Code"] = q.SOC8Code;
                            dr["SOC8_Charge"] = q.SOC8Charge;
                            dr["SOC8_Discount"] = q.SOC8Discount;
                            dr["SOC9_Code"] = q.SOC9Code;
                            dr["SOC9_Charge"] = q.SOC9Charge;
                            dr["SOC9_Discount"] = q.SOC9Discount;
                            dr["SOC10_Code"] = q.SOC10Code;
                            dr["SOC10_Charge"] = q.SOC10Charge;
                            dr["SOC10_Discount"] = q.SOC10Discount;
                            dr["Hardware_Fund"] = q.HardwareFund;
                            dr["Airtime_Fund"] = q.AirtimeFund;
                            dr["BuyOut_Credit"] = q.BuyOutCredit;
                            dr["HW_Brand"] = q.HWBrand;
                            dr["HW_Model"] = q.HWModel;
                            dr["HW_SLP"] = q.HWSLP;
                            dr["HW_Charge"] = q.HWCharge;
                            dr["Sim_Required"] = q.SimRequired;
                            dr["Sim_Size"] = q.SimSize;
                            dr["Charging_Account"] = q.ChargingAccount;
                            dr["Delivery_Type"] = q.DeliveryType;
                            dr["Delivery_Charge"] = q.DeliveryCharge;
                            dr["Delivery_Address"] = q.DeliveryAddress;
                            dr["Process_Method"] = q.ProcessMethod;
                            dr["Comments"] = q.Comments;
                            dr["Missing Information"] = q.MissingInformation;

                            dt.Rows.Add(dr);

                        }
                        ds.Tables.Add(dt);
                    }
                    //Hardware only Invalid Data


                    var qryinvalidHWROnly = entity.tblInvalidHardwareOnlies.Where(q => q.IsActive == true).ToList();
                    if (qryinvalidHWROnly != null && qryinvalidHWROnly.Count > 0)
                    {
                        DataTable dtInvalidHardware = new DataTable();
                        dtInvalidHardware.TableName = "Invalid_Hardware_Only_Data";
                        dtInvalidHardware.Clear();
                        dtInvalidHardware.Columns.Add("CTN");
                        dtInvalidHardware.Columns.Add("Account Name");
                        dtInvalidHardware.Columns.Add("BAN");
                        dtInvalidHardware.Columns.Add("NT Login");
                        dtInvalidHardware.Columns.Add("Sales Manager");
                        dtInvalidHardware.Columns.Add("Hardware Brand");
                        dtInvalidHardware.Columns.Add("Hardware Variant");
                        dtInvalidHardware.Columns.Add("Hardware SLP");
                        dtInvalidHardware.Columns.Add("Hardware Charge (£)");
                        dtInvalidHardware.Columns.Add("Sim Card Required");
                        dtInvalidHardware.Columns.Add("Sim Card Size");
                        dtInvalidHardware.Columns.Add("Hardware Colour Variant");
                        dtInvalidHardware.Columns.Add("Accessory Description");
                        dtInvalidHardware.Columns.Add("Accessory Cost");
                        dtInvalidHardware.Columns.Add("Charging Account (Hardware/Airtime)");
                        dtInvalidHardware.Columns.Add("Delivery Address");
                        dtInvalidHardware.Columns.Add("Delivery Type");
                        dtInvalidHardware.Columns.Add("Delivery Charge (£)");
                        dtInvalidHardware.Columns.Add("Additional Comments");

                        foreach (var q in qryinvalidHWROnly)
                        {
                            DataRow dr = dtInvalidHardware.NewRow();
                            dr["CTN"] = q.CTN;
                            dr["Account Name"] = q.AccountName;
                            dr["BAN"] = q.BAN;
                            dr["NT Login"] = q.NTLogin;
                            dr["Sales Manager"] = q.SalesManager;
                            dr["Hardware Brand"] = q.HardwareBrand;
                            dr["Hardware Variant"] = q.HardwareVariant;
                            dr["Hardware SLP"] = q.HardwareSLP;
                            dr["Hardware Charge (£)"] = q.HardwareCharge;
                            dr["Sim Card Required"] = q.SimCardRequired;
                            dr["Sim Card Size"] = q.SimCardSize;
                            dr["Hardware Colour Variant"] = q.HardwareColourVariant;
                            dr["Accessory Description"] = q.AccessoryDescription;
                            dr["Accessory Cost"] = q.AccessoryCost;
                            dr["Charging Account (Hardware/Airtime)"] = q.ChargingAccountHardwareORAirtime;
                            dr["Delivery Address"] = q.DeliveryAddress;
                            dr["Delivery Type"] = q.DeliveryType;
                            dr["Delivery Charge (£)"] = q.DeliveryCharge;
                            dr["Additional Comments"] = q.AdditionalComments;
                            dtInvalidHardware.Rows.Add(dr);
                        }
                        ds.Tables.Add(dtInvalidHardware);
                    }
                }
                return ds;
            }
            catch (Exception ex)
            {
                return ds;
            }
        }
    }
}
