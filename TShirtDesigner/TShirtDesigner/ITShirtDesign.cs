using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtDesigner
{
    public interface ITShirtDesign
    {
        String PersonName { get; }
        int NumberOfDays { get; }
        decimal BasicValue { get; }
        DateTime InitialDate { get; }

        decimal ValueForTheDay(int numOfDays);
        decimal TotalValue();
    }
}
