using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Transactions;
using BlueConsultingBusinessLogic;
namespace BusinessLogicUnitTesting
{
    [TestClass]
    class ReportTest
    {
        [TestMethod]
        public void testReportConstructorAndGetters()
        {
            string consultantID = "testPerson";
            string reportStatus = "Submitted";
            string filepath = "testFakeFilePath";
            Report report = new Report(consultantID, reportStatus, filepath);
            
            Assert.Equals(consultantID, report.ConsultantID);
            Assert.Equals(reportStatus, report.ReportStatus);
            Assert.IsNull(report.PDF);
        }

        [TestMethod]
        public void ;
    }
}
