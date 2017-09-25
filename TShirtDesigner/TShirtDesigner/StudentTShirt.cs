using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtDesigner
{
    public class StudentTShirt : TShirtDecorator
    {
        public StudentTShirt(ITShirtDesign tshirtDesign) : base(tshirtDesign)
        {

        }

        public override decimal ValueForTheDay(int numberOfDays)
        {

            decimal valBase = base.ValueForTheDay(numberOfDays);

            return valBase - (valBase * 0.02M);
        }


        public override string ToString()
    {
        return base.ToString() + "\n\t Student Discount applied";
    }
}
}
