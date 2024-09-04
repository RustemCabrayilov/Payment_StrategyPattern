using Payment_StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_StrategyPattern.Models
{
	public class PaymentService
	{
		private IPaymentService _paymentService;

		public PaymentService(IPaymentService paymentService)
		{
			_paymentService = paymentService;
		}
		public PaymentService()
		{

		}
		public void SetPaymentService(IPaymentService paymentService)
		{
			this._paymentService = paymentService;
		}
		public void PayViaPaymentService(PaymentOptions paymentOptions)
		{
			_paymentService.Pay(paymentOptions);
		}
	}
}
