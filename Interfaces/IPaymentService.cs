using Payment_StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_StrategyPattern.Interfaces
{
   public interface IPaymentService
    {
        void Pay(PaymentOptions options);
    }
}
