namespace SaleCalculator
{
    public class Sale
    {
        /// <summary>
        /// 점포 이름
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// 상품 종류
        /// </summary>
        public string ProductCategory { get; set; }
        /// <summary>
        /// 매출액
        /// </summary>
        public int Amount { get; set; }
    }
}
