using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtDesigner
{
    public class TShirtDecorator : ITShirtDesign
    {
        private ITShirtDesign _tshirtDesign;

        public TShirtDecorator(ITShirtDesign tshirtDesign)
        {
            _tshirtDesign = tshirtDesign;
        }

        public decimal BasicValue => _tshirtDesign.BasicValue;

        public DateTime InitialDate => _tshirtDesign.InitialDate;

        public int NumberOfDays => _tshirtDesign.NumberOfDays;

        public string PersonName => _tshirtDesign.PersonName;


        public virtual decimal ValueForTheDay(int numOfDays)
        {
            //Console.WriteLine("Going into Base decorator");
            return _tshirtDesign.ValueForTheDay(numOfDays);
        }

        public decimal TotalValue()
        {
            decimal totalValue = 0M;
            for (int d = 1; d <= NumberOfDays; d++)
            {
                totalValue += this.ValueForTheDay(d);
            }
            return totalValue;
        }


        public override string ToString()
        {
            return _tshirtDesign.ToString();
        }
    }
}
