namespace WebAPI.Models
{
    using
    System.ComponentModel.DataAnnotations.Schema;

    public class Stockboards_master
    {
        public string category {get; set;}
        public string? buyer {get; set;}
        public string? supplier {get; set;}
        public int ProductCode {get; set;}
        public string Description {get; set;}
        public string UnitSize {get; set;}
        public string? ProductGroup {get; set;}
        public string? ProductSubGroup {get; set;}
        public string PickingGroup {get; set;}
        public string? temp {get; set;}
        public decimal YesterdayWOWSales {get; set;}
        public decimal YesterdayWOWSalesCustomer {get; set;}
        public decimal YesterdayWOWSalesDepot {get; set;}
        public decimal YesterdaySales {get; set;}
        public decimal YesterdaySalesCustomer {get; set;}
        public decimal YesterdaySalesDepot {get; set;}
        public decimal YesterdayShortPOP {get; set;}
        public decimal YesterdayCustomerShortPOP {get; set;}
        public decimal YesterdayDepotShortPOP {get; set;}
        public decimal YesterdayShortNA {get; set;}
        public decimal YesterdayCustomerShortNA {get; set;}
        public decimal YesterdayDepotShortNA {get; set;}
        public decimal YesterdayWaste {get; set;}
        public decimal YesterdayReceived {get; set;}
        public decimal OutstandingQty {get; set;}
        public decimal OpeningStock {get; set;}
        public decimal TodaysShortPOP {get; set;}
        public decimal TodaysCustomerShortPOP {get; set;}
        public decimal TodaysDepotShortPOP {get; set;}
        public decimal TodaysShortNA {get; set;}
        public decimal TodaysCustomerShortNA {get; set;}
        public decimal TodaysDepotShortNA {get; set;}
        public decimal TodaysWaste {get; set;}
        public decimal ExpectedStock {get; set;}
        public decimal ReceivedStock {get; set;}
        public int QCHoldStock {get; set;}
        public decimal? TodaysGrossStock {get; set;}
        public decimal TodaysSales {get; set;}
        public decimal TodaysSalesCustomer {get; set;}
        public decimal TodaysSalesDepot {get; set;}
        public decimal TodaysForecastDepot {get; set;}
        public decimal? CurrentClosingStock {get; set;}
        public decimal? ForecastClosingStock {get; set;}
        [Column("Expected Receipts +1")]  
        public decimal ExpectedReceiptsPlus1 {get; set;}
        [Column("Actual Sales +1")]  
        public decimal ActualSalesPlus1 {get; set;}
        [Column("Actual Sales Customer +1")]  
        public decimal ActualSalesCustomerPlus1 {get; set;}
        [Column("Actual Sales Depot +1")]  
        public decimal ActualSalesDepotPlus1 {get; set;}
        [Column("Forecast Sales Depot +1")]  
        public decimal ForecastSalesDepotPlus1 {get; set;}
        [Column("Short POP +1")]  
        public decimal ShortPOPPlus1 {get; set;}
        [Column("Short NA +1")] 
        public decimal ShortNAPlus1 {get; set;}
        [Column("Waste +1")]  
        public decimal WastePlus1 {get; set;}
        [Column("Expected Receipts +2")]  
        public decimal ExpectedReceiptsPlus2 {get; set;}
        [Column("Actual Sales +2")]  
        public decimal ActualSalesPlus2 {get; set;}
        [Column("Actual Sales Customer +2")] 
        public decimal ActualSalesCustomerPlus2 {get; set;}
        [Column("Actual Sales Depot +2")]  
        public decimal ActualSalesDepotPlus2 {get; set;}
        [Column("Forecast Sales Depot +2")]  
        public decimal ForecastSalesDepotPlus2 {get; set;}
        [Column("Short POP +2")]  
        public decimal ShortPOPPlus2 {get; set;}
        [Column("Short NA +2")]  
        public decimal ShortNAPlus2 {get; set;}
        [Column("Waste +2")]  
        public decimal WastePlus2 {get; set;}
        [Column("Expected Receipts +3")]  
        public decimal ExpectedReceiptsPlus3 {get; set;}
        [Column("Actual Sales +3")]  
        public decimal ActualSalesPlus3 {get; set;}
        [Column("Actual Sales Customer +3")]  
        public decimal ActualSalesCustomerPlus3 {get; set;}
        [Column("Actual Sales Depot +3")]  
        public decimal ActualSalesDepotPlus3 {get; set;}
        [Column("Forecast Sales Depot +3")]  
        public decimal ForecastSalesDepotPlus3 {get; set;}
        [Column("Short POP +3")]  
        public decimal ShortPOPPlus3 {get; set;}
        [Column("Short NA +3")]  
        public decimal ShortNAPlus3 {get; set;}
        [Column("Waste +3")]  
        public decimal WastePlus3 {get; set;}
        [Column("Expected Receipts +4")]  
        public decimal ExpectedReceiptsPlus4 {get; set;}
        [Column("Actual Sales +4")]  
        public decimal ActualSalesPlus4 {get; set;}
        [Column("Actual Sales Customer +4")]  
        public decimal ActualSalesCustomerPlus4 {get; set;}
        [Column("Actual Sales Depot +4")]  
        public decimal ActualSalesDepotPlus4 {get; set;}
        [Column("Forecast Sales Depot +4")]  
        public decimal ForecastSalesDepotPlus4 {get; set;}
        [Column("Short POP +4")]  
        public decimal ShortPOPPlus4 {get; set;}
        [Column("Short NA +4")]  
        public decimal ShortNAPlus4 {get; set;}
        [Column("Waste +4")]  
        public decimal WastePlus4 {get; set;}
        [Column("Expected Receipts +5")]  
        public decimal ExpectedReceiptsPlus5 {get; set;}
        [Column("Actual Sales +5")]  
        public decimal ActualSalesPlus5 {get; set;}
        [Column("Actual Sales Customer +5")]  
        public decimal ActualSalesCustomerPlus5 {get; set;}
        [Column("Actual Sales Depot +5")]  
        public decimal ActualSalesDepotPlus5 {get; set;}
        [Column("Forecast Sales Depot +5")]  
        public decimal ForecastSalesDepotPlus5 {get; set;}
        [Column("Short POP +5")]  
        public decimal ShortPOPPlus5 {get; set;}
        [Column("Short NA +5")]  
        public decimal ShortNAPlus5 {get; set;}
        [Column("Waste +5")]  
        public decimal WastePlus5 {get; set;}
        [Column("Expected Receipts +6")]  
        public decimal ExpectedReceiptsPlus6 {get; set;}
        [Column("Actual Sales +6")]  
        public decimal ActualSalesPlus6 {get; set;}
        [Column("Actual Sales Customer +6")]  
        public decimal ActualSalesCustomerPlus6 {get; set;}
        [Column("Actual Sales Depot +6")]  
        public decimal ActualSalesDepotPlus6 {get; set;}
        [Column("Forecast Sales Depot +6")]  
        public decimal ForecastSalesDepotPlus6 {get; set;}
        [Column("Short POP +6")]  
        public decimal ShortPOPPlus6 {get; set;}
        [Column("Short NA +6")]  
        public decimal ShortNAPlus6 {get; set;}
        [Column("Waste +6")]  
        public decimal WastePlus6 {get; set;}
        [Column("Expected Receipts +7")]  
        public decimal ExpectedReceiptsPlus7 {get; set;}
        [Column("Actual Sales +7")]  
        public decimal ActualSalesPlus7 {get; set;}
        [Column("Short NA +7")]  
        public decimal ShortNAPlus7 {get; set;}
        [Column("Actual Sales Customer +7")]  
        public decimal ActualSalesCustomerPlus7 {get; set;}
        [Column("Actual Sales Depot +7")]  
        public decimal ActualSalesDepotPlus7 {get; set;}
        [Column("Forecast Sales Depot +7")]  
        public decimal ForecastSalesDepotPlus7 {get; set;}
        [Column("Expected Receipts +8")]  
        public decimal ExpectedReceiptsPlus8 {get; set;}
        [Column("Actual Sales +8")]  
        public decimal ActualSalesPlus8 {get; set;}
        [Column("Short NA +8")]  
        public decimal ShortNAPlus8 {get; set;}
        [Column("Actual Sales Customer +8")]  
        public decimal ActualSalesCustomerPlus8 {get; set;}
        [Column("Actual Sales Depot +8")]  
        public decimal ActualSalesDepotPlus8 {get; set;}
        [Column("Forecast Sales Depot +8")]  
        public decimal ForecastSalesDepotPlus8 {get; set;}
        [Column("Expected Receipts +9")]  
        public decimal ExpectedReceiptsPlus9 {get; set;}
        [Column("Actual Sales +9")]  
        public decimal ActualSalesPlus9 {get; set;}
        [Column("Short NA +9")]  
        public decimal ShortNAPlus9 {get; set;}
        [Column("Actual Sales Customer +9")]  
        public decimal ActualSalesCustomerPlus9 {get; set;}
        [Column("Actual Sales Depot +9")]  
        public decimal ActualSalesDepotPlus9 {get; set;}
        [Column("Forecast Sales Depot +9")]  
        public decimal ForecastSalesDepotPlus9 {get; set;}
        [Column("Expected Receipts +10")]  
        public decimal ExpectedReceiptsPlus10 {get; set;}
        [Column("Actual Sales +10")]  
        public decimal ActualSalesPlus10 {get; set;}
        [Column("Short NA +10")]  
        public decimal ShortNAPlus10 {get; set;}
        [Column("Actual Sales Customer +10")]  
        public decimal ActualSalesCustomerPlus10 {get; set;}
        [Column("Actual Sales Depot +10")]  
        public decimal ActualSalesDepotPlus10 {get; set;}
        [Column("Forecast Sales Depot +10")]  
        public decimal ForecastSalesDepotPlus10 {get; set;}
        [Column("Expected Receipts +11")]  
        public decimal ExpectedReceiptsPlus11 {get; set;}
        [Column("Actual Sales +11")]  
        public decimal ActualSalesPlus11 {get; set;}
        [Column("Short NA +11")]  
        public decimal ShortNAPlus11 {get; set;}
        [Column("Actual Sales Customer +11")]  
        public decimal ActualSalesCustomerPlus11 {get; set;}
        [Column("Actual Sales Depot +11")]  
        public decimal ActualSalesDepotPlus11 {get; set;}
        [Column("Forecast Sales Depot +11")]  
        public decimal ForecastSalesDepotPlus11 {get; set;}
        [Column("Expected Receipts +12")]  
        public decimal ExpectedReceiptsPlus12 {get; set;}
        [Column("Actual Sales +12")]  
        public decimal ActualSalesPlus12 {get; set;}
        [Column("Short NA +12")]  
        public decimal ShortNAPlus12 {get; set;}
        [Column("Actual Sales Customer +12")]  
        public decimal ActualSalesCustomerPlus12 {get; set;}
        [Column("Actual Sales Depot +12")]  
        public decimal ActualSalesDepotPlus12 {get; set;}
        [Column("Forecast Sales Depot +12")]  
        public decimal ForecastSalesDepotPlus12 {get; set;}
        [Column("Expected Receipts +13")]  
        public decimal ExpectedReceiptsPlus13 {get; set;}
        [Column("Actual Sales +13")]  
        public decimal ActualSalesPlus13 {get; set;}
        [Column("Short NA +13")]  
        public decimal ShortNAPlus13 {get; set;}
        [Column("Actual Sales Customer +13")]  
        public decimal ActualSalesCustomerPlus13 {get; set;}
        [Column("Actual Sales Depot +13")]  
        public decimal ActualSalesDepotPlus13 {get; set;}
        [Column("Forecast Sales Depot +13")]  
        public decimal ForecastSalesDepotPlus13 {get; set;}
        [Column("Expected Receipts +14")]  
        public decimal ExpectedReceiptsPlus14 {get; set;}
        [Column("Short NA +14")]  
        public decimal ShortNAPlus14 {get; set;}
        [Column("Forecast Sales Depot +14")]  
        public decimal ForecastSalesDepotPlus14 {get; set;}
        [Column("Expected Receipts +15")]  
        public decimal ExpectedReceiptsPlus15 {get; set;}
        [Column("Short NA +15")]  
        public decimal ShortNAPlus15 {get; set;}
        [Column("Forecast Sales Depot +15")]  
        public decimal ForecastSalesDepotPlus15 {get; set;}
        [Column("Expected Receipts +16")]  
        public decimal ExpectedReceiptsPlus16 {get; set;}
        [Column("Short NA +16")]  
        public decimal ShortNAPlus16 {get; set;}
        [Column("Forecast Sales Depot +16")]  
        public decimal ForecastSalesDepotPlus16 {get; set;}
        [Column("Expected Receipts +17")]  
        public decimal ExpectedReceiptsPlus17 {get; set;}
        [Column("Short NA +17")]  
        public decimal ShortNAPlus17 {get; set;}
        [Column("Forecast Sales Depot +17")]  
        public decimal ForecastSalesDepotPlus17 {get; set;}
        [Column("Expected Receipts +18")]  
        public decimal ExpectedReceiptsPlus18 {get; set;}
        [Column("Short NA +18")]  
        public decimal ShortNAPlus18 {get; set;}
        [Column("Forecast Sales Depot +18")]  
        public decimal ForecastSalesDepotPlus18 {get; set;}
        [Column("Expected Receipts +19")]  
        public decimal ExpectedReceiptsPlus19 {get; set;}
        [Column("Short NA +19")]  
        public decimal ShortNAPlus19 {get; set;}
        [Column("Forecast Sales Depot +19")]  
        public decimal ForecastSalesDepotPlus19 {get; set;}
        [Column("Expected Receipts +20")]  
        public decimal ExpectedReceiptsPlus20 {get; set;}
        [Column("Short NA +20")]  
        public decimal ShortNAPlus20 {get; set;}
        [Column("Forecast Sales Depot +20")]  
        public decimal ForecastSalesDepotPlus20 {get; set;}
        public decimal OrdersWeek1 {get; set;}
        public decimal OrdersWeek2 {get; set;}
        public decimal OrdersWeek3 {get; set;}
        public decimal OrdersWeek4 {get; set;}
        public decimal OrdersWeek5 {get; set;}
        public decimal OrdersWeek6 {get; set;}
        public decimal CustomerOrdersWeek1 {get; set;}
        public decimal CustomerOrdersWeek2 {get; set;}
        public decimal CustomerOrdersWeek3 {get; set;}
        public decimal CustomerOrdersWeek4 {get; set;}
        public decimal CustomerOrdersWeek5 {get; set;}
        public decimal CustomerOrdersWeek6 {get; set;}
        public decimal DepotOrdersWeek1 {get; set;}
        public decimal DepotOrdersWeek2 {get; set;}
        public decimal DepotOrdersWeek3 {get; set;}
        public decimal DepotOrdersWeek4 {get; set;}
        public decimal DepotOrdersWeek5 {get; set;}
        public decimal DepotOrdersWeek6 {get; set;}
        public decimal NAWeek1 {get; set;}
        public decimal NAWeek2 {get; set;}
        public decimal NAWeek3 {get; set;}
        public decimal NAWeek4 {get; set;}
        public decimal NAWeek5 {get; set;}
        public decimal NAWeek6 {get; set;}
        public decimal POPWeek1 {get; set;}
        public decimal POPWeek2 {get; set;}
        public decimal POPWeek3 {get; set;}
        public decimal POPWeek4 {get; set;}
        public decimal POPWeek5 {get; set;}
        public decimal POPWeek6 {get; set;}
        public decimal TodaysAdjustments {get; set;}
        public decimal YesterdaysAdjustments {get; set;}
        [Column("Day-2 Adjustments")]
        public decimal DayMinus2Adjustments {get; set;}
        [Column("Day-3 Adjustments")]
        public decimal DayMinus3Adjustments {get; set;}
        [Column("Day-4 Adjustments")]
        public decimal DayMinus4Adjustments {get; set;}
        [Column("Day-5 Adjustments")]
        public decimal DayMinus5Adjustments {get; set;}
        public DateTime Updated {get; set;}
        public decimal WOWShortPOP {get; set;}
        public decimal WOWCustomerShortPOP {get; set;}
        public decimal WOWDepotShortPOP {get; set;}
        public decimal WOWShortNA {get; set;}
        public decimal WOWCustomerShortNA {get; set;}
        public decimal WOWDepotShortNA {get; set;}
        public decimal PalletStock {get; set;}
        public decimal UnallocatedStock {get; set;}
        public decimal AllocatedStock {get; set;}
        public string Depot {get; set;}
    }
}
