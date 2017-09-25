using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtDesigner
{
    public class TShirtFactory
    {
        public static ITShirtDesign CreateTShirtDesign(String clientName, int numofDays, decimal basicValue, ActiveDiscounts[] discounts)
        {
            ITShirtDesign tshirt = new BasicTShirtDesign(clientName, numofDays, basicValue);

            
            foreach (var promo in discounts)
            {
                switch (promo)
                {
                    case ActiveDiscounts.STUDENT: tshirt = new StudentTShirt(tshirt); break;
                    case ActiveDiscounts.MEMBER: tshirt = new MemberTShirt(tshirt); break;
                    case ActiveDiscounts.JULYOFFER: tshirt = new JulyOfferDecorator(tshirt); break;
                }
            }

            return tshirt;
        }
    }
}
