using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtDesigner
{
    public class BasicTShirtDesign : ITShirtDesign
    {
        public BasicTShirtDesign(string clientName, int noOfDays, decimal basicValue)
        {
            PersonName = clientName;
            NumberOfDays = noOfDays;
            BasicValue = basicValue;
            InitialDate = DateTime.Now.Date;
        }

        public decimal BasicValue { get; }

        public DateTime InitialDate { get; }

        public int NumberOfDays { get; }

        public string PersonName { get; }

        public decimal ValueForTheDay(int numOfDays)
        {
            decimal dayValue = BasicValue;

            for (int i = 0; i < numOfDays - 1; i++)
            {
                dayValue = dayValue - (dayValue * 0.2M);
            }
            return dayValue;
        }

        public decimal TotalValue()
        {
            decimal totalValue = 0;
            for (int d = 1; d <= NumberOfDays; d++)
            {
                totalValue += ValueForTheDay(d);
            }
            return totalValue;
        }

        public override string ToString()
        {
            return String.Format("Client: {0}\t Basic Value: {1} Number of days: {2}",
                PersonName,
                BasicValue,
                NumberOfDays);
        }
    }
}
