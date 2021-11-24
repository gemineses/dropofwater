using Models.WorldForms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Util;

namespace Test.LifeFormsTests
{
    [TestFixture]
    public class LifeFormsBasicsTests
    {
        private TestingGeneratorModels _generator = new TestingGeneratorModels();
        private IUniverseModel _universeModel = null;

        [SetUp]
        public void SetUp() {
            _universeModel = _generator.GenerateUniverse();
        }

        [Test]
        [TestCase(TestName = "Life form has senses", Description = "Given it the form is a life form, it has to have at least one sense")]
        public void ValidateSenses() {

            //Asserts
            Assert.IsNotNull(_universeModel.lifeForms);
            Assert.IsTrue(_universeModel.lifeForms.Count > 0);
            
        }
    }
}
