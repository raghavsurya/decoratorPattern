using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtDesigner
{
    public class TShirtFacadeService
    {
        public ITShirtDesign CreateTShirtDesign(String clientName,
                                                 int numOfDays,
                                                 decimal basicValue,
                                                 ActiveDiscounts[] descontos)
        {
            return TShirtFactory.CreateTShirtDesign(clientName, numOfDays, basicValue, descontos);
        }
    }
}
