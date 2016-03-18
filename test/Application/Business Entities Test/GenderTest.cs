using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIS.Application.Entities;

namespace CIS.Application.BusinessEntities.Test
{
    [TestClass]
    public class GenderTest
    {
        private const int VALID_IDENTIFIER = 1;
        private const int ANOTHER_VALID_IDENTIFIER = 2;
        private const int ZERO_IDENTIFIER = 0;
        private const int NEGATIVE_IDENTIFIER = -1;

        private const string VALID_DESCRIPTION = "Male";
        private const string ANOTHER_VALID_DESCRIPTION = "Female";
        private const string INVALID_DESCRIPTION_CONTAINS_PUNCTUATION = "Male.";
        private const string INVALID_DESCRIPTION_CONTAINS_DIGIT = "Male1";
        private const string INVALID_DESCRIPTION_CONTAINS_ILEGAL_CHARACTERS = "Male!";
        private const string NULL_DESCRIPTION = null;
        private const string EMPTY_DESCRIPTION = "";

        #region Static Fields

        [TestMethod]
        public void AMaleGenderIsEqualsANewMaleGender()
        {
            var gender1 = Gender.MALE;
            var gender2 = new Gender(VALID_IDENTIFIER, VALID_DESCRIPTION);

            Assert.AreEqual(gender1, gender2);
        }

        [TestMethod]
        public void AMaleGenderIsNotEqualsANewMaleGenderWithDifferentIdentifier()
        {
            var gender1 = Gender.MALE;
            var gender2 = new Gender(ANOTHER_VALID_IDENTIFIER, VALID_DESCRIPTION);

            Assert.AreNotEqual(gender1, gender2);
        }

        #endregion

        #region Constructors

        [TestMethod]
        public void ConstructNewGenderWithMandatoryParameters()
        {
            var gender = new Gender(VALID_IDENTIFIER, VALID_DESCRIPTION);

            Assert.IsNotNull(gender);
        }

        [TestMethod]
        public void ContructNewGenderWithZeroIdentifier()
        {
            var gender = new Gender(ZERO_IDENTIFIER, VALID_DESCRIPTION);

            Assert.IsNotNull(gender);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructNewGenderWithInvalidIdentifierThrowsException()
        {
            var gender = new Gender(NEGATIVE_IDENTIFIER, VALID_DESCRIPTION);

            Assert.Fail("Its no posible create a new gender with negative identifier.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructNewGenderWithDescriptionThatContainsPunctuationThrowsException()
        {
            var gender = new Gender(VALID_IDENTIFIER, INVALID_DESCRIPTION_CONTAINS_PUNCTUATION);

            Assert.Fail("Its no posible construct a gender with description that contains puntuaction characters.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructNewGenderWithDescriptionThatContainsDigitThrowsException()
        {
            var gender = new Gender(VALID_IDENTIFIER, INVALID_DESCRIPTION_CONTAINS_DIGIT);

            Assert.Fail("Its no posible construct a gender with description that contains digits.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructNewGenderWithDescriptionThatContainsIlegalCharactersThrowsException()
        {
            var gender = new Gender(VALID_IDENTIFIER, INVALID_DESCRIPTION_CONTAINS_ILEGAL_CHARACTERS);

            Assert.Fail("Its no posible construct a gender with description that contains ilegal characters.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructNewGenderWithEmptyDescriptionThrowsException()
        {
            var gender = new Gender(VALID_IDENTIFIER, EMPTY_DESCRIPTION);

            Assert.Fail("Its no posible create a new gender with empty description.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CostructNewGenderWithNullDescriptionThrowsException()
        {
            var gender = new Gender(VALID_IDENTIFIER, NULL_DESCRIPTION);

            Assert.Fail("Its no posible create a new gender with empty description.");
        }

        #endregion

        #region Equality

        #region Value Equality

        [TestMethod]
        public void AMaleGenderIsEqualAAnotherMaleGender()
        {
            var gender1 = Gender.MALE;
            var gender2 = Gender.MALE;

            Assert.AreEqual(gender1, gender2);
        }

        [TestMethod]
        public void AMaleGenderIsNotEqualsAFemaleGender()
        {
            var gender1 = Gender.MALE;
            var gender2 = Gender.FEMALE;

            Assert.AreNotEqual(gender1, gender2);
        }

        [TestMethod]
        public void AMaleGenderIsNotEqualsAMaleGenderWithDifferentIdentifier()
        {
            var gender1 = Gender.MALE;
            var gender2 = new Gender(2, VALID_DESCRIPTION);

            Assert.AreNotEqual(gender1, gender2);
        }

        #endregion

        #region Reference Equality

        [TestMethod]
        public void AMaleGenderIsSameAMaleGender()
        {
            var gender1 = Gender.MALE;
            var gender2 = gender1;

            Assert.AreSame(gender1, gender2);
        }

        [TestMethod]
        public void AMaleGenderIsNotSameANull()
        {
            var gender1 = Gender.MALE;

            Assert.AreNotSame(gender1, null);
        }

        #endregion

        #endregion

        #region Identity

        #endregion
    }
}
