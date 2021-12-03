using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerClass
{
    /// <summary>
    /// 采购请求
    /// </summary>
    public class PurchaseRequest
    {
        public double Amount { get; set; }
        public string ProductName { get; set; }

        public PurchaseRequest(double amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }
    }
}
