using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TddDemo.Entities;

namespace TddDemo.Business.Tests
{
    [TestClass]
    public class EgnManagerTests
    {
        Mock<IEgnDal> _mockEgnDal;
        EgnPartsEntity _dbEgns;
        EgnEntity _dbEgn;
        IEgnDal egnService;
        public EgnManagerTests()
        {
            _mockEgnDal = new Mock<IEgnDal>();
            _dbEgns = new EgnPartsEntity { egn = "8011200561"};
            egnService = new EgnManager(_mockEgnDal.Object);
        }
        [TestInitialize]
        public void Start()
        {
            _mockEgnDal.Setup(m => m.AllDigitsIsValidate(_dbEgns).Equals(true)).Returns(true);
            _mockEgnDal.Setup(m=>m.LengthIsValid(_dbEgns).Equals(true)).Returns(true);
            _mockEgnDal.Setup(m => m.MonthsIsValid(_dbEgns).Equals(true)).Returns(true);
            _mockEgnDal.Setup(m => m.DayIsValid(_dbEgns).Equals(true)).Returns(true);
            _mockEgnDal.Setup(m => m.LastDigitIsValid(_dbEgns).Equals(true)).Returns(true); 
        }
        [TestMethod]
        public void TestMethod_Length_Is_Valid()
        {
            bool result = egnService.LengthIsValid( new EgnPartsEntity { egn = "1234567890" }).Success;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_Length_Is_InValid()
        {

            bool result = egnService.LengthIsValid(new EgnPartsEntity { egn = "123456789" }).Success;
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_AllDigits_IsValidate()
        {
            
            bool result = egnService.AllDigitsIsValidate(new EgnPartsEntity { egn = "1234567890" }).Success;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod_AllDigits_IsNo_Validate()
        {

            bool result = egnService.AllDigitsIsValidate(new EgnPartsEntity { egn = "1234p67890" }).Success;
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethod_Validate_Months()
        {
            bool result = egnService.MonthsIsValid(new EgnPartsEntity { egn = "1212567890"}).Success;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_Method_Validate_Months_Old()
        {
            bool result = egnService.MonthsIsValid(new EgnPartsEntity { egn = "1232567890" }).Success;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Test_Method_Validate_Months_Young()
        {
            bool result = egnService.MonthsIsValid(new EgnPartsEntity { egn = "1252567890" }).Success;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestMethod_Validate_Months_InValid()
        {
            bool result = egnService.MonthsIsValid(new EgnPartsEntity { egn = "1234567890" }).Success;
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod_Validate_Day()
        {
            bool result = egnService.DayIsValid(new EgnPartsEntity { egn = "1202297890" }).Success;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_Day_IsInValid()
        { 
            bool result = egnService.DayIsValid(new EgnPartsEntity { egn = "1245567890" }).Success;
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestMethod_LastDigit_Validate()
        {
            bool result = egnService.LastDigitIsValid(new EgnPartsEntity { egn = "8812102466" }).Success;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod_LastDigit_InValidate()
        {
            bool result = egnService.LastDigitIsValid(new EgnPartsEntity { egn = "8812102461" }).Success;
            Assert.IsFalse(result);
        }
        
    }
}
