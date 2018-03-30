﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticsToolData.Model
{
    public class RoboticsUnProcessedModel
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> SubmissionDate { get; set; }
        public string AgentName { get; set; }
        public string SalesManager { get; set; }
        public string AccountName { get; set; }
        public string EntityKey { get; set; }
        public string SFOpportunityRef { get; set; }
        public string UniqueRef { get; set; }
        public string ConnectionType { get; set; }
        public string CTN { get; set; }
        public string PACCode { get; set; }
        public Nullable<System.DateTime> PortDate { get; set; }
        public string Tariff { get; set; }
        public string TariffCode { get; set; }
        public string VoiceData { get; set; }
        public string LineRental { get; set; }
        public string ContractLength { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountLength { get; set; }
        public string SOC1Code { get; set; }
        public Nullable<decimal> SOC1Charge { get; set; }
        public Nullable<decimal> SOC1Discount { get; set; }
      
        public string SOC2Code { get; set; }
        public Nullable<decimal> SOC2Charge { get; set; }
        public Nullable<decimal> SOC2Discount { get; set; }
        public string SOC3Code { get; set; }
        public Nullable<decimal> SOC3Charge { get; set; }
        public Nullable<decimal> SOC3Discount { get; set; }
        public string SOC4Code { get; set; }
        public Nullable<decimal> SOC4Charge { get; set; }
        public Nullable<decimal> SOC4Discount { get; set; }
        public string SOC5Code { get; set; }
        public Nullable<decimal> SOC5Charge { get; set; }
        public Nullable<decimal> SOC5Discount { get; set; }
        public string SOC6Code { get; set; }
        public Nullable<decimal> SOC6Charge { get; set; }
        public Nullable<decimal> SOC6Discount { get; set; }
        public string SOC7Code { get; set; }
        public Nullable<decimal> SOC7Charge { get; set; }
        public Nullable<decimal> SOC7Discount { get; set; }
        public string SOC8Code { get; set; }
        public Nullable<decimal> SOC8Charge { get; set; }
        public Nullable<decimal> SOC8Discount { get; set; }
        public string SOC9Code { get; set; }
        public Nullable<decimal> SOC9Charge { get; set; }
        public Nullable<decimal> SOC9Discount { get; set; }
        public string SOC10Code { get; set; }
        public Nullable<decimal> SOC10Charge { get; set; }
        public Nullable<decimal> SOC10Discount { get; set; }
        public Nullable<decimal> HardwareFund { get; set; }
        public Nullable<decimal> AirtimeFund { get; set; }
        public Nullable<decimal> BuyOutCredit { get; set; }
        public string HWModel { get; set; }
        public Nullable<decimal> HWCharge { get; set; }
        public string SimSize { get; set; }
        public string ChargingAccount { get; set; }
        public string DeliveryType { get; set; }
        public Nullable<decimal> DeliveryCharge { get; set; }
        public string DeliveryAddress { get; set; }
        public string ProcessMethod { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> IsProcess { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public bool IsManualProcessed { get; set; }
        public string FileName { get; set; }
        public Nullable<int> ReferenceNumber { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ProcessDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string HWBrand { get; set; }
        public Nullable<decimal> HWSLP { get; set; }
        public string SimRequired { get; set; }

        public Nullable<int> CommitmentLength { get; set; }
        public Nullable<System.DateTime> CommitmentStartDate { get; set; }
        public Nullable<bool> InternationalBarRemove { get; set; }
        public string AccessorySKU { get; set; }
        public string AccessoryVariant { get; set; }
        public Nullable<decimal> AccessoryCharge { get; set; }
        public string SimCardSKUCode { get; set; }
        public string ExistingSIMNo { get; set; }
        public string HardwareSKUCode { get; set; }
         public string AirtimeBAN { get; set; }
        public string HardwareBAN { get; set; }
        // Required for Hardwear only
        public string BAN { get; set; }
        public string NTLogin { get; set; }
        public string HardwareVariant { get; set; }
        public Nullable<decimal> HardwareCharge { get; set; }
        public string HardwareColourVariant { get; set; }
        public string AccessoryDescription { get; set; }
        public Nullable<decimal> AccessoryCos { get; set; }
        public string ChargingAccountHardwareORAirtime { get; set; }
    }
}
