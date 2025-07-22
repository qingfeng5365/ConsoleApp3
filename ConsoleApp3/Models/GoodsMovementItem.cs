using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace ConsoleApp3.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("LCGS709999.GoodsMovementItem")]
    public partial class GoodsMovementItem
    {
           public GoodsMovementItem(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GoodsMovementID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string GoodsMovementItemID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           //public string ID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MaterialID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField1Code {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField1Name {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField2Code {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField2Name {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField3Code {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField3Name {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField4Code {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField4Name {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField5 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField5Code {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FlexField5Name {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string BatchNumCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? TargInpQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? ActInpQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecPriUnitID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? AssTargInpQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? AssActInpQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecSecUnitID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecInvState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? TargOutQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? ActOutQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssPriUnitID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? AssTargOutQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? AssActOutQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssSecUnitID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssInvState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? QuantityBalance {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? AssQuanBalance {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? QuantityVariance {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? AssQuanVariance {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BillItemState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string ShipFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string IssValItemState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string RecValItemState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? InpPlaPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? InpPlaValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? InpActPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? InpActValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? OutPlaPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? OutPlaValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? OutActPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? OutActValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? PlaValBalance {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? ActValBalance {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string ValuationFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string InvoiceVerFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? InvoicePrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? InvoiceValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal InvoiceInValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string VarComFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:Z
           /// Nullable:True
           /// </summary>           
           public string RecSpeStock {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecOfObject {get;set;}

           /// <summary>
           /// Desc:
           /// Default:Z
           /// Nullable:True
           /// </summary>           
           public string IssSpeStock {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssOfObject {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string ClearFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DrawQuotaAccID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CostCenterID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WorkCenterID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecOperDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecOperTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssOperDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssOperTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string IsConversion {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string DeSaleCost {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string SaleCostFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal SaleCostQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal SaleCostValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string MVConfirm {get;set;}

           /// <summary>
           /// Desc:
           /// Default:B
           /// Nullable:False
           /// </summary>           
           public string BillingFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal ReqInvoiceQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal InvoiceQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal RetInvoiceQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal CancelQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal ReturnQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string MoveVarFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DoneClearDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DoneClearYear {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DoneClearPeriod {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomField1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomField2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomField3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomField4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomField5 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CustomField6 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CustomField7 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CustomField8 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal CurrentPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal SourcePrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal TaxRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal TaxExPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal TaxExValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal TaxInPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal TaxInValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal TaxValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal Trancosts {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string ConversionFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal PriSecConvRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal PriSysConvRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string PriSysCompFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal SecSysConvRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string SecSysCompFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PrimaryPrecision {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SecondaryPrecision {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SysUnitPrecision {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SecSysUnitPrecision {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConvOrgID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConvWHID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string SelectFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReferBillCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal BarCodeMatchNumber {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string IMItemFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string MVItemFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CreditBaseDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:-1
           /// Nullable:False
           /// </summary>           
           public int CreditDays {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FixedDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:-1
           /// Nullable:False
           /// </summary>           
           public int MonthsPlus {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CreditEndDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal BilledValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string TaxType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string ConversionType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal OraTaxExPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal OraTaxExValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal OraTaxInValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal OraTaxInPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal OraTaxValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FirstBillType {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FirstBillID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string FirstBillItemID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string SumValueFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal OraBasePrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CalculateDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           //public byte[] RowV {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UnmatchClearFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? HandleQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string ZCFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? ZCQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? RedRefQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string DeliveryType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPReqBillID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPReqBillItemID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string IsUPRec {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CertificateMessage {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal ReturnReqQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HandleReason {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string ItemIsInvApp {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string ItemIsRecon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HandleTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string BCTaskedFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaskTimeStamp {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField9 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField10 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField11 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField13 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField12 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField14 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField15 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField16 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal CustomField17 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField18 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField19 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField20 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal CustomField21 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField22 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField23 {get;set;}

    }
}
