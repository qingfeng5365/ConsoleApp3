using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace ConsoleApp3.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("LCGS709999.GoodsMovement")]
    public partial class GoodsMovement
    {
           public GoodsMovement(){


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
           /// Nullable:True
           /// </summary>           
           public string CreateDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GoodsMovementCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WbsID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BusinessType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string SourceTypeCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MoveTypeID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SysMoveTypeID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecMoveTypeID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurOrgID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurDepID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurEmpID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SupplierID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecFiscalYear {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecFiscalPeriod {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecYearperiod {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReceiptDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecOrgID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecHandler {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecWHID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecWHEmpID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SalesCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SalesOrgID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SalesDepID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SalesEmpID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CustomerID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:True
           /// </summary>           
           public string AttorneyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:True
           /// </summary>           
           public string DischannelID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssFiscalYear {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssFiscalPeriod {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssYearperiod {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssOrgID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssHandler {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssWHID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssWHEmpID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecCheckFlow {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecAccountBy {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecAccountDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssCheckFlow {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssAccountBy {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssAccountDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecLastChgDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssLastChgDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecCreator {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Creator {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Note {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string IsTransport {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string ShipFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BillState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string RecValState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string IssValState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:01
           /// Nullable:True
           /// </summary>           
           public string ValState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string IsRed {get;set;}

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
           public string ChargeOffBillID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecValCheckFlow {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecValAccountBy {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecValAccountDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssValCheckFlow {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssValAccountBy {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssValAccountDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecDestination {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProOrgID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProDepID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProEmpID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProductID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConOrgID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConDepID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConEmpID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ConUseID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UnloadPortID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProducerID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UseDepID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string IsInit {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:True
           /// </summary>           
           public string MeasureParameter {get;set;}

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
           public string MVAdjustWay {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string MVConfirm {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string MVFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string IMFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string OnRoadARState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string CoFlag {get;set;}

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
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string GRIRFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecCheckor {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecChecktime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssCheckor {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssChecktime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LastChgName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal AllActValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IsPerTally {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecAccountTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssAccountTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string IsBudgetary {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string SNState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MVFiscalYear {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MVFiscalPeriod {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RecCostScopeID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IssCostScopeID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BillSupplierID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PaySupplierID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BillCustomerID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayCustomerID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Prouseid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField1code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField1name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField2code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField2name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField3code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField3name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField4code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField4name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField5 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField5code {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PFlexField5name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Pbatchnumcode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TotalTaxInValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TotalTaxExValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? TotalTaxValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? AllPlanValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InvoiceRoute {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProductSpecs {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string OraCurrencyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public decimal ExchangeRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? OPBomQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PurDepartmentID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string PAccTypeCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BaseValueType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           //public byte[] RowV {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string IssRTallyFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string RecRTallyFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string IssBTallyFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string RecBTallyFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SecLevel {get;set;}

           /// <summary>
           /// Desc:
           /// Default:newid()
           /// Nullable:False
           /// </summary>           
           public string BillGuid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UnmatchClearFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BargainPathID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:True
           /// </summary>           
           public string BillingNotifyFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CCCostCenterID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string RecBizCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string IssBizCompanyID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string IsRecon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string PostToYSYFFlag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PostBy {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PostDate {get;set;}

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
           public string CustomField11 {get;set;}

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
           //public string FILEID {get;set;}

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
           public string CustomField13 {get;set;}

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
           public string CustomField17 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField16 {get;set;}

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
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField21 {get;set;}

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

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField24 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField25 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField26 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField27 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField29 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField28 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField30 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField32 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField31 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField33 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField35 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField34 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField36 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField38 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField37 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField39 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField40 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SignMessage {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CerBase64String {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField41 {get;set;}

           /// <summary>
           /// Desc:
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CustomField42 {get;set;}

    }
}
