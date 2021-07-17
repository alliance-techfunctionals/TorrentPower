﻿using System.Collections.Generic;

namespace AT.Print.Utils
{
    public class SingleLTMDBill
    {
       public string unit { get; set; }
        public string L1_BillType { get; set; }
        public string L1_MonthYear { get; set; }
        public string L1_Zone { get; set; }
        public string L1_BU { get; set; }
        public string L1_PC { get; set; }
        public string L1_Route { get; set; }
        public string L1_SubRoute { get; set; }
        public string L1_BillSequenceNo { get; set; }
        public string L1_ReadingSequence { get; set; }
        public string L1_PowerFactorMSGIndicator { get; set; }
        public string L1_FeederName { get; set; }
        public string L1_TODOrNon_TODFlag { get; set; }
        public string L1_AKY_indicator { get; set; }
        public string L1_DisconnectionMSGPrintingIMMEDIATE { get; set; }
        public string L1_BillingCode { get; set; }
        public string L2_Name { get; set; }
        public string L3_Addr1 { get; set; }
        public string L4_Addr2 { get; set; }
        public string L5_Addr3 { get; set; }
        public string L6_SERVDET_SERVNO { get; set; }
        public string L6_SERVDET_SANC_LOAD { get; set; }
        public string L6_ACTUAL_DEMAND { get; set; }
        public string L6_TARIFF_DESCR { get; set; }
        public string L6_EXCESS_DEMAND { get; set; }
        public string L6_SUPPLY_VOLTAGE { get; set; }
        public string L6_MTRDET_LF_PERC { get; set; }
        public string L6_BILL_TYPE { get; set; }
        public string L6_Avg_Power_Factor { get; set; }
        public string L6_bill_demand { get; set; }
        public string L6_MeasureContractDemand { get; set; }
        public string L6_Kvah_Indicator { get; set; }
        public string L6_LT_Metering_Flag { get; set; }
        public string L7_Due_Date { get; set; }
        public string L7_BillDt { get; set; }
        public string L7_PrevReadDt { get; set; }
        public string L7_ReaDt { get; set; }
        public string L7_LastPymtDate { get; set; }
        public string L7_LastPayementAmount { get; set; }
        public string L7_LastPayementMode { get; set; }
        public string L8_FixedCharge { get; set; }
        public string L8_EnergyCharge { get; set; }
        public string L8_ACCharge { get; set; }
        public string L8_GovTax { get; set; }
        public string L8_MinCharge { get; set; }
        public string L8_ServdetTotbBdtOthr { get; set; }
        public string L8_PowerFactorAdj { get; set; }
        public string L8_TODCharges { get; set; }
        public string L8_RegulatoryCharge_1 { get; set; }
        public string L8_RegulatoryCharge_2 { get; set; }
        public string L8_RebateIncurredCurrentMonth { get; set; }
        public string L8_AmountPayableBeforeDueDate { get; set; }
        public string L8_TNo { get; set; }
        public string L8_ParkingAmount { get; set; }
        public string L9_TotDbArr { get; set; }
        public string L9_CurrBillAmt { get; set; }
        public string L9_Int_Tpl { get; set; }
        public string L9_ArrsTpl { get; set; }
        public string L9_CurrBillAmtIntTplArrsTpl { get; set; }
        public string L9_AmountPayable { get; set; }
        public string L9_MessageIndication { get; set; }
        public string L9_MessageFlag { get; set; }
        public string L10_LFincentive { get; set; }
        public string L10_DisconnDate { get; set; }
        public string L10_TotArrUPPCLIntUPPCLIntArrUPPCL { get; set; }
        public string L10_SecDeptBdt { get; set; }
        public string L10_DmdChgPenalty { get; set; }
        public string L10_UPPCL_ArrearAmount { get; set; }
        public string L10_UPPCLIntOnArrearAmount { get; set; }
        public string L10_TheftAmount { get; set; }
        public string L10_Mode { get; set; }
        public string L11_MonYear_1 { get; set; }
        public string L11_KWH_UNITS_1 { get; set; }
        public string L11_MonYear_2 { get; set; }
        public string L11_KWH_UNITS_2 { get; set; }
        public string L11_MonYear_3 { get; set; }
        public string L11_KWH_UNITS_3 { get; set; }
        public string L11_MonYear_4 { get; set; }
        public string L11_KWH_UNITS_4 { get; set; }
        public string L11_MonYear_5 { get; set; }
        public string L11_KWH_UNITS_5 { get; set; }
        public string L11_MonYear_6 { get; set; }
        public string L11_KWH_UNITS_6 { get; set; }
        public string L11_MonYear_7 { get; set; }
        public string L11_KWH_UNITS_7 { get; set; }
        public string L11_MonYear_8 { get; set; }
        public string L11_KWH_UNITS_8 { get; set; }
        public string L11_MonYear_9 { get; set; }
        public string L11_KWH_UNITS_9 { get; set; }
        public string L11_MonYear_10 { get; set; }
        public string L11_KWH_UNITS_10 { get; set; }
        public string L11_MonYear_11 { get; set; }
        public string L11_KWH_UNITS_11 { get; set; }
        public string L11_MonYear_12 { get; set; }
        public string L11_KWH_UNITS_12 { get; set; }
        public string L11_MonYear_13 { get; set; }
        public string L11_KWH_UNITS_13 { get; set; }

        public string L12_MTRSNO_METER1 { get; set; }
        public string L12_MTRSNO_METER_2_IF_AVAILABLE { get; set; }
        public string L13_M1_KWH_PRESREAD { get; set; }
        public string L13_M1_KVA_PRESREAD { get; set; }
        public string L14_M1_KWH_PASTREAD { get; set; }
        public string L14_M1_KVA_PASTREAD { get; set; }
        public string L15_M1_MultiplyingFactor_1 { get; set; }
        public string L15_M1_MultiplyingFactor_2 { get; set; }
        public string L15_Purpose { get; set; }
        public string L16_M1_KWH_UNITS { get; set; }
        public string L16_M1_KVA_UNITS { get; set; }
        public string L17_M2_KWH_PRESREAD { get; set; }
        public string L17_M2_KVA_PRESREAD { get; set; }
        public string L18_M2_KWH_PASTREAD { get; set; }
        public string L18_M2_KVA_PASTREAD { get; set; }
        public string L19_M2_Multiplying_Factor_1 { get; set; }
        public string L19_M2_Multiplying_Factor_2 { get; set; }
        public string L20_M2_KWH_UNITS { get; set; }
        public string L20_M2_KVA_UNITS { get; set; }
        public string L21_MonYear_1 { get; set; }
        public string L21_KVA_UNITS_1 { get; set; }
        public string L21_MonYear_2 { get; set; }
        public string L21_KVA_UNITS_2 { get; set; }
        public string L21_MonYear_3 { get; set; }
        public string L21_KVA_UNITS_3 { get; set; }
        public string L21_MonYear_4 { get; set; }
        public string L21_KVA_UNITS_4 { get; set; }
        public string L21_MonYear_5 { get; set; }
        public string L21_KVA_UNITS_5 { get; set; }
        public string L21_MonYear_6 { get; set; }
        public string L21_KVA_UNITS_6 { get; set; }
        public string L21_MonYear_7 { get; set; }
        public string L21_KVA_UNITS_7 { get; set; }
        public string L21_MonYear_8 { get; set; }
        public string L21_KVA_UNITS_8 { get; set; }
        public string L21_MonYear_9 { get; set; }
        public string L21_KVA_UNITS_9 { get; set; }
        public string L21_MonYear_10 { get; set; }
        public string L21_KVA_UNITS_10 { get; set; }
        public string L21_MonYear_11 { get; set; }
        public string L21_KVA_UNITS_11 { get; set; }
        public string L21_MonYear_12 { get; set; }
        public string L21_KVA_UNITS_12 { get; set; }
        public string L21_MonYear_13 { get; set; }
        public string L21_KVA_UNITS_13 { get; set; }

        public string L22_TOD1_KWH { get; set; }
        public string L22_TOD2_KWH { get; set; }
        public string L22_TOD3_KWH { get; set; }
        public string L22_TOD4_KWH { get; set; }

        public string L23_TOD1_KW { get; set; }
        public string L23_TOD2_KW { get; set; }
        public string L23_TOD3_KW { get; set; }
        public string L23_TOD4_KW { get; set; }

        public string L24_TOD1_KWH { get; set; }
        public string L24_TOD2_KWH { get; set; }
        public string L24_TOD3_KWH { get; set; }
        public string L24_TOD4_KWH { get; set; }

        public string L25_TOD1_KW { get; set; }
        public string L25_TOD2_KW { get; set; }
        public string L25_TOD3_KW { get; set; }
        public string L25_TOD4_KW { get; set; }

        public string L26_MESSAGE1 { get; set; }
        public string L27_MESSAGE2 { get; set; }
        public string L28_MESSAGE3 { get; set; }
        public string L29_MESSAGE4 { get; set; }
        public string L30_MESSAGE5 { get; set; }
        public string L31_MESSAGE6 { get; set; }
        public string L32_BarCode { get; set; }
        public string L33_MESSAGE7 { get; set; }
        public string L34_MESSAGE8 { get; set; }
        public string L35_MESSAGE9 { get; set; }
        public string L36_MESSAGE10 { get; set; }
        public string L37_MonYear_1 { get; set; }
        public string L37_PowerFactor_1 { get; set; }
        public string L37_MonYear_2 { get; set; }
        public string L37_PowerFactor_2 { get; set; }
        public string L37_MonYear_3 { get; set; }
        public string L37_PowerFactor_3 { get; set; }
        public string L37_MonYear_4 { get; set; }
        public string L37_PowerFactor_4 { get; set; }
        public string L37_MonYear_5 { get; set; }
        public string L37_PowerFactor_5 { get; set; }
        public string L37_MonYear_6 { get; set; }
        public string L37_PowerFactor_6 { get; set; }
        public string L37_MonYear_7 { get; set; }
        public string L37_PowerFactor_7 { get; set; }
        public string L37_MonYear_8 { get; set; }
        public string L37_PowerFactor_8 { get; set; }
        public string L37_MonYear_9 { get; set; }
        public string L37_PowerFactor_9 { get; set; }
        public string L37_MonYear_10 { get; set; }
        public string L37_PowerFactor_10 { get; set; }
        public string L37_MonYear_11 { get; set; }
        public string L37_PowerFactor_11 { get; set; }
        public string L37_MonYear_12 { get; set; }
        public string L37_PowerFactor_12 { get; set; }
        public string L37_MonYear_13 { get; set; }
        public string L37_PowerFactor_13 { get; set; }

        public string TopPanel_Row_1 { get; set; }
        public string TopPanel_Row_2 { get; set; }
        public string TopPanel_Row_3 { get; set; }
        public string TopPanel_Row_4 { get; set; }
        public string TopPanel_Row_5 { get; set; }
        public string TopPanel_Row_6 { get; set; }
        public string TopPanel { get; set; }
        public string Sap_Zone { get; set; }
        public string Sap_LotNo { get; set; }
        public string Sap_GrpNo { get; set; }
        public string lblSapratorNote { get; set; }
        public string MVPicture { get; set; }

        public System.Data.DataTable KWHgrph { get; set; }
        public System.Data.DataTable KVAgrph { get; set; }
        public System.Data.DataTable PFgrph { get; set; }

        public List<BillDetails> BillDetails { get; set; }
        public System.Data.DataTable dtMessage { get; set; }
        public decimal L8_ParkingAmountCeilied { get; internal set; }
        public decimal L8_AmountPayableBeforeDueDateCeilied { get; internal set; }
        public decimal L10_TotArrUPPCLIntUPPCLIntArrUPPCLCeilied { get; internal set; }

        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }
        //public string BillType { get; set; }

        //public string OwnerAddress_1 { get; set; }
        //public string OwnerAddress_2 { get; set; }
    }
}
