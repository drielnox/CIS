using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS.Data.Entities;
using CIS.Data.DataAccess;

namespace Data_Access_Test.Repository
{
    [TestClass]
    public class TitleRepositoryTest
    {
        [TestMethod]
        public void AddNewTitle()
        {
            TitleTable tbl = new TitleTable 
            { 
                Abbreviation = "MR",
                Description = "Mister"
            };

            TitleTable retriviedTbl;

            using(var context = new ClinicModel(null))
            {
                context.Titles.Add(tbl);
                context.SaveChanges();

                retriviedTbl = context.Titles
                    .Single(x => x.Abbreviation == "MR");
            }

            Assert.IsNotNull(retriviedTbl);
            Assert.AreEqual(1, retriviedTbl.Identifier);
            Assert.AreEqual(tbl.Abbreviation, retriviedTbl.Abbreviation);
            Assert.AreEqual(tbl.Description, retriviedTbl.Description);
        }
    }
}
