using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexPattern;

namespace RegexPatternTestCases
{
    [TestClass]
    public class UnitTest1
    {
        private Pattern user;


        [TestInitialize]
        public void InitClassObject()
        {
            //Arrange
            user = new Pattern();
            
        }
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string fname = "Vba";
            
            //Act
            bool expected = true;
            bool result = user.validateFirstName(fname);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            string lname = "Rao";

            //Act
            bool expected = true;
            bool result = user.validateLastName(lname);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            string email = "Vbarao@gmail.com";

            //Act
            bool expected = true;
            bool result = user.validateEmail(email);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            string phNo = "91 9876543210";

            //Act
            bool expected = true;
            bool result = user.validateMobileNumber(phNo);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange

            string password = "Qwertyyy";

            //Act
            bool expected = true;
            bool result = user.validatePaswordRule1(password);

            //Assert
            Assert.AreEqual(expected, result);
        }

        //Test Cases Fails The Entry

        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse()
        {
            string fname = "vba";

            //Act
            bool expected = false;
            bool result = user.validateFirstName(fname);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            string lname = "rao";

            //Act
            bool expected = false;
            bool result = user.validateLastName(lname);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            string email = "vba.rao.com";

            //Act
            bool expected = false;
            bool result = user.validateEmail(email);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            string phNo = "91 0084323110";

            //Act
            bool expected = false;
            bool result = user.validateMobileNumber(phNo);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            string password = "vba@123*";

            //Act
            bool expected = false;
            bool result = user.validatePaswordRule1(password);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]

        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId_forAllMailSamples(string email)
        {
            //string email = "Vbarao@gmail.com";

            //Act
            bool expected = false;
            bool result = user.validateEmail(email);

            //Assert
            Assert.AreEqual(expected, result);
           // Assert.IsTrue(user.validateEmail(email));
        }
    }
}