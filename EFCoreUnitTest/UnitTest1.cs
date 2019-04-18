using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Database;
using Mosiac.Services;
using System.Threading.Tasks;
using Mosiac.Repository;

namespace EFCoreUnitTest
{

   

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void SetUp()
        {

        }


        [TestMethod]
        public async Task TestMethod1()
        {
            using (var ctx = new DatabaseContext())
            {
                //PartRepository ser = new PartRepository(ctx);
                //System.Collections.Generic.IList<Database.Models.Part> x   =  await ser.GetAllAsync();
                //Assert.IsTrue(x.Count > 2000);
            }
        }
    }
}
