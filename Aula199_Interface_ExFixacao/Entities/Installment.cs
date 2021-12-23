using System;
using System.Globalization;

namespace Aula199_Interface_ExFixacao.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment()
        {
        }

        public Installment(DateTime date, double amount)
        {
            DueDate = date;
            Amount = amount;
        }

        // Override
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
