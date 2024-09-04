using Payment_StrategyPattern.Interfaces;
using Payment_StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_StrategyPattern.Implementations
{
	public class YapiKrediPaymentService : IPaymentService
	{
		void IPaymentService.Pay(PaymentOptions options)
		{
            Console.WriteLine($"Payment done via Yapi Kredi bank by {options.CardHolderName}");
        }
	}
}
