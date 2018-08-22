namespace DailyHome.App.Models
{
    /// <summary>
    /// 消費清單
    /// </summary>
    public class Consumption
    {
        /// <summary>
        /// ID
        /// </summary>
        /// <returns></returns>
        public string CID{get;set;}

        /// <summary>
        /// m 名稱
        /// </summary>
        /// <returns></returns>
        public string Name{get;set;}
        /// <summary>
        /// 說明
        /// </summary>
        /// <returns></returns>
        public string Description{get;set;}

        /// <summary>
        /// 購買者
        /// </summary>
        /// <returns></returns>
        public string Owners{get;set;}

        /// <summary>
        /// 價格
        /// </summary>
        /// <returns></returns>
        public string Prize{get;set;}
        /// <summary>
        /// 數量
        /// </summary>
        /// <returns></returns>
        public decimal Qty{get;set;}
        /// <summary>
        /// 金額
        /// </summary>
        /// <returns></returns>
        public decimal Amt{get;set;}

        /// <summary>
        /// 折扣
        /// </summary>
        /// <returns></returns>
        public decimal Discount{get;set;}
        /// <summary>
        /// 花費金額
        /// </summary>
        /// <returns></returns>
        public decimal SetAmt{get;set;}

        /// <summary>
        /// 付款者
        /// </summary>
        /// <returns></returns>
        public string PayBy{get;set;}

        /// <summary>
        ///  付款方式
        /// </summary>
        /// <returns></returns>
        public string PayType{get;set;}

        /// <summary>
        /// 付款日期
        /// </summary>
        /// <returns></returns>
        public string PayDate{get;set;}
        
    }
}