using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS.Application.Entities;

namespace CIS.Application.BusinessEntities.Test
{
    [TestClass]
    public class GenderTest
    {
        #region Constructors

        [TestMethod]
        public void ConstructNewGenderWithMandatoryParameters()
        {
            var gender = new Gender(1, "Male");

            Assert.IsNotNull(gender);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructNewGenderWithInvalidIdentifierThrowsException()
        {
            var gender = new Gender(-1, "Male");

            Assert.Fail("Its no posible create a new gender with negative identifier.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructNewGenderWithEmptyDescriptionThrowsException()
        {
            var gender = new Gender(1, string.Empty);

            Assert.Fail("Its no posible create a new gender with empty description.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CostructNewGenderWithNullDescriptionThrowsException()
        {
            var gender = new Gender(1, null);

            Assert.Fail("Its no posible create a new gender with empty description.");
        }

        #endregion
    }
}
