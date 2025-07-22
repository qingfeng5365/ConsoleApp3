using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace ConsoleApp3.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("LCGS709999.GoodsMovementAss")]
    public partial class GoodsMovementAss
    {
           public GoodsMovementAss(){


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
           [SugarColumn(IsPrimaryKey=true)]
           public string GoodsMovementAssID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MovingFlag {get;set;}

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
           public string BatchID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LocationID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? Quantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? AssQuantity {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string InventoryState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AssItemState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string ValuationState {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? ActPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? ActValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal AssTaxExPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal AssTaxExValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal AssTaxInPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal AssTaxInValue {get;set;}

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
           public decimal InvoiceValue {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string Clearflag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string IsQuality {get;set;}

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
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal Trancosts {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public decimal CancelQuantity {get;set;}

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
           /// Default: 
           /// Nullable:False
           /// </summary>           
           public string CalculateDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string MVConfirm {get;set;}

    }
}
