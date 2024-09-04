using Payment_StrategyPattern.Implementations;
using Payment_StrategyPattern.Interfaces;
using Payment_StrategyPattern.Models;

namespace Payment_StrategyPattern
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			var paymentService = new PaymentService();
			char opt = 'n';
			do
			{
				Console.Write("Choose bank to pay (1: Garanti, 2: Yapı Kredi): ");
				var bank = Console.ReadLine();

				IPaymentService bankPaymentService = null;

				switch (bank)
				{
					case "1":
						bankPaymentService = new GarantiBankPaymentService();
						break;
					case "2":
						bankPaymentService = new YapiKrediPaymentService();
						break;
					default:
						Console.WriteLine("Choose proper Bank please");
						break;
				}

				paymentService.SetPaymentService(bankPaymentService);
				paymentService.PayViaPaymentService(new()
				{
					CardNumber = "1234123412341234",
					CardHolderName = "Poyraz Karayel",
					ExpirationDate = DateTime.Now,
					Cvv = "123",
					Amount = 1000
				});
				Console.WriteLine("Do you want to continue ?(y/n)");
				opt = char.Parse(Console.ReadLine().ToLower());
			} while (opt == 'y');

		}
	}
}
