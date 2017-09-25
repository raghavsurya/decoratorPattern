using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtDesigner;

namespace TShirtDesignerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TShirtFacadeService tShirtService = new TShirtFacadeService();

            List<ITShirtDesign> tshirtDesigns = new List<ITShirtDesign>();
            tshirtDesigns.Add(tShirtService.CreateTShirtDesign("Raghav Surya", 7, 100, new ActiveDiscounts[] { }));
            tshirtDesigns.Add(tShirtService.CreateTShirtDesign("Raghav Surya Member Only", 7, 100, new ActiveDiscounts[] { ActiveDiscounts.MEMBER }));
            tshirtDesigns.Add(tShirtService.CreateTShirtDesign("Raghav Surya Student only", 7, 100, new ActiveDiscounts[] { ActiveDiscounts.STUDENT }));
          //  tshirtDesigns.Add(tShirtService.CreateTShirtDesign("Raghav Surya MEMBER and Student", 7, 100, new ActiveDiscounts[] { ActiveDiscounts.MEMBER, ActiveDiscounts.STUDENT, ActiveDiscounts.JULYOFFER }));
            tshirtDesigns.Add(tShirtService.CreateTShirtDesign("Raghav Surya MEMBER and Student", 7, 100, new ActiveDiscounts[] { ActiveDiscounts.MEMBER, ActiveDiscounts.STUDENT }));
            tshirtDesigns.Add(tShirtService.CreateTShirtDesign("Raghav Surya Student and Member", 7, 100,  new ActiveDiscounts[] { ActiveDiscounts.STUDENT, ActiveDiscounts.MEMBER }));

            foreach (ITShirtDesign tShirt in tshirtDesigns)
            {
                Console.WriteLine(tShirt);
                for (int i = 1; i <= tShirt.NumberOfDays; i++)
                {
                    Console.WriteLine("\t\tValue of the day {0} ({1}): {2:c}",
                        i,
                        tShirt.InitialDate.AddDays(i - 1).ToShortDateString(),
                        tShirt.ValueForTheDay(i), i);
                }

                Console.WriteLine("\tTotal Value of all days for the tshirt design: {0:c}\n", tShirt.TotalValue());
            }

            Console.ReadKey();
        }
    }
}
