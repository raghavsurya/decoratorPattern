using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtDesigner
{
    public class MemberTShirt: TShirtDecorator
    {
        public MemberTShirt(ITShirtDesign tshirtDesign):base(tshirtDesign)
        {
            
        }

        public override decimal ValueForTheDay(int numberOfDays)
        {
          
            decimal valBase = base.ValueForTheDay(numberOfDays);

            if (NumberOfDays < 5 || numberOfDays == 1)
            {
                return valBase;
            }

            return valBase - (valBase * 0.10M);
        }

        public override string ToString()
        {
            return base.ToString() + "\n\t Member Discount applied";
        }
    }
}
