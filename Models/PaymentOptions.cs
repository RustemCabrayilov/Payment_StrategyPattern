using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_StrategyPattern.Models
{
	public class PaymentOptions
	{
		public string CardNumber { get; set; }
		public string CardHolderName { get; set; }
		public DateTime ExpirationDate { get; set; }
		public string Cvv { get; set; }
        public decimal Amount { get; set; }
    }
}
