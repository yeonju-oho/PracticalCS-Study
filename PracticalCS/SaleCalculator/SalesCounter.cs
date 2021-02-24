using System;
using System.Collections.Generic;
using System.IO;

namespace SaleCalculator
{
    class SalesCounter
    {
        private IEnumerable<Sale> mSales;   //

        public SalesCounter(string filePath)
        {
            mSales = ReadSales(filePath);
        }
        

        public IDictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in mSales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
        
        /// <summary>
        /// .csv 파일을 읽어온다. (점포 이름, 상품 종류, 매출액)
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();
            string[] lines = null;
            try
            {
                lines = File.ReadAllLines(filePath);
            }
            catch(Exception error)
            {
                Console.WriteLine("파일 경로에 파일이 없습니다. Message : " + error.Message);
            }
            foreach (var line in lines)
            {
                var items = line.Split(',');
                var sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
