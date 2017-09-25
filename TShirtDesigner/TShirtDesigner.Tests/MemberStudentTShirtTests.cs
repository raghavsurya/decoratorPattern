using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TShirtDesigner.Tests
{
    [TestClass]
    public class MemberStudentTShirtTests
    {
        TShirtFacadeService tShirtService;
        private List<ITShirtDesign> tshirtDesigns;

        [TestInitialize]
        public void Init()
        {

            tShirtService = new TShirtFacadeService();
            tshirtDesigns = new List<ITShirtDesign>();
        }

        [TestMethod]
        public void Check_Type_IsEqual_To_MemberTShirt()
        {
            ITShirtDesign tshirtDesign = tShirtService.CreateTShirtDesign("Raghav Surya", 7, 100,
                new ActiveDiscounts[] {ActiveDiscounts.MEMBER});
            Assert.AreEqual(tshirtDesign.GetType(), typeof(MemberTShirt));
        }


        [TestMethod]
        public void Check_Type_IsEqual_To_MemberTShirt_Then_StudentTShirt()
        {
            ITShirtDesign tshirtDesign = tShirtService.CreateTShirtDesign("Raghav Surya", 7, 100, new ActiveDiscounts[] { ActiveDiscounts.STUDENT, ActiveDiscounts.MEMBER });
            Assert.AreEqual(tshirtDesign.GetType(), typeof(MemberTShirt));
        }

        [TestMethod]
        public void Check_Type_IsEqual_To_StudentTShirt()
        {
            ITShirtDesign tshirtDesign = tShirtService.CreateTShirtDesign("Raghav Surya", 7, 100, new ActiveDiscounts[] { ActiveDiscounts.MEMBER, ActiveDiscounts.STUDENT });
            Assert.AreEqual(tshirtDesign.GetType(), typeof(StudentTShirt));
        }



    }
}
