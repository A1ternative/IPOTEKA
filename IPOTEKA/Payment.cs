using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPOTEKA
{
	class Payment
	{
		public DateTime paymentDate;
		public double creditAmount;
		public double sumPerMonth;
		public double percentsSumPerMonth;
		public double paymentSumPerMounth;

		public Payment(DateTime paymentDate, double creditAmount, double sumPerMonth,
			double percentsSumPerMonth, double paymentSumPerMounth)
		{
			this.paymentDate = paymentDate;
			this.creditAmount = creditAmount;
			this.sumPerMonth = sumPerMonth;
			this.percentsSumPerMonth = percentsSumPerMonth;
			this.paymentSumPerMounth = paymentSumPerMounth;
		}
	}
}
