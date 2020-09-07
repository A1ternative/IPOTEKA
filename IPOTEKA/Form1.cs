using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPOTEKA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//параметры с формы
			double creditAmount;
			double annualPercentage;
			int morgageTerm;
			DateTime startDate;
			double sumPerMonth;

			//считывание ввода
			creditAmount = Convert.ToDouble(creditAmountText.Text);
			annualPercentage = Convert.ToDouble(annualPercentageText.Text) / 100;
			startDate = Convert.ToDateTime(startDateText.Text);
			morgageTerm = Convert.ToInt32(morgageTermText.Text);
			//sumPerMonth = Convert.ToDouble(paymentText.Text);

			//параметры для расчетов
			double percentsSumPerMonth;
			double paymentSumPerMounth;
			DateTime paymentDate;

			Payment payment;
			var payments = new List<Payment>();

			int paymentsCountPerYear = 12;
			double percentsPerMonth = annualPercentage / paymentsCountPerYear;
			int TotalPaymentsCount = paymentsCountPerYear * morgageTerm;

			paymentDate = startDate;

			sumPerMonth = creditAmount *
				percentsPerMonth * Math.Pow(1 + percentsPerMonth, TotalPaymentsCount) /
				(Math.Pow(1 + percentsPerMonth, TotalPaymentsCount) - 1);
			

			switch (paymentWhen.Text)
			{
				case "Каждые 2 недели":
					{
						sumPerMonth = Math.Round(sumPerMonth / 2, 2);
						/*sumPerMonth делится пополам, потому что платеж вносится каждые 2 недели
						по хорошему это уже не sumPerMonth, a sumPer14Days */
						percentsPerMonth = annualPercentage / 26; //потому что в году будет (х*2+2) лишних платежа

						while (creditAmount > 0)
						{
							percentsSumPerMonth = Math.Round(creditAmount * percentsPerMonth, 2);
							paymentSumPerMounth = Math.Round(sumPerMonth - percentsSumPerMonth, 2);

							payment = new Payment(paymentDate, creditAmount, sumPerMonth,
								percentsSumPerMonth, paymentSumPerMounth);
							payments.Add(payment);

							//указываем дату нового платежа только когда произведен текущий
							//остаток по платежу меняется только когда произведен текущий платеж
							paymentDate = paymentDate.AddDays(14);
							creditAmount -= paymentSumPerMounth;
							creditAmount = Math.Round(creditAmount, 2);
						}

						BindingSource bs = new BindingSource();
						bs.DataSource = serializePayment(payments);
						dataGridView1.DataSource = bs;
					}
					break;

				case "Каждый месяц":
					{
						sumPerMonth = Math.Round(sumPerMonth, 2);
						while (creditAmount > 0)
						{
							percentsSumPerMonth = Math.Round(creditAmount * percentsPerMonth, 2);
							paymentSumPerMounth = Math.Round(sumPerMonth - percentsSumPerMonth, 2);

							payment = new Payment(paymentDate, creditAmount, sumPerMonth,
								percentsSumPerMonth, paymentSumPerMounth);
							payments.Add(payment);

							//указываем дату нового платежа только когда произведен текущий
							//остаток по платежу меняется только когда произведен текущий платеж
							paymentDate = paymentDate.AddMonths(1);
							creditAmount -= paymentSumPerMounth;
							creditAmount = Math.Round(creditAmount, 2);
						}

						BindingSource bs = new BindingSource();
						bs.DataSource = serializePayment(payments);
						dataGridView1.DataSource = bs;
					}
					break;
			}
		}

		private DataTable serializePayment(List<Payment> payments)
		{
			DataTable returnTable = new DataTable("Table");
			returnTable.Columns.Add("Дата платежа");
			returnTable.Columns.Add("Остаток");
			returnTable.Columns.Add("Сумма платежа");
			returnTable.Columns.Add("Сумма процентов");
			returnTable.Columns.Add("Сумма в счет остатка");

			foreach (Payment payment in payments)
			{
				returnTable.AcceptChanges();
				DataRow row = returnTable.NewRow();

				returnTable.Rows.Add(row);
				row[0] = payment.paymentDate;
				row[1] = payment.creditAmount;
				row[2] = payment.sumPerMonth;
				row[3] = payment.percentsSumPerMonth;
				row[4] = payment.paymentSumPerMounth;
			}

			return returnTable;
		}
	}
}
