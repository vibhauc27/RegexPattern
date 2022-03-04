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
        public void TestMethod1()
        {
            string fname = "Vba";

            //Act
            bool expected = true;
            bool result = user.validateFirstName(fname);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string lname = "Rao";

            //Act
            bool expected = true;
            bool result = user.validateLastName(lname);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string email = "Vbarao@gmail.com";

            //Act
            bool expected = true;
            bool result = user.validateEmail(email);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string phNo = "91 9876543210";

            //Act
            bool expected = true;
            bool result = user.validateMobileNumber(phNo);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
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
        public void TestMethod11()
        {
            string fname = "vba";

            //Act
            bool expected = false;
            bool result = user.validateFirstName(fname);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod21()
        {
            string lname = "rao";

            //Act
            bool expected = false;
            bool result = user.validateLastName(lname);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestMetho31()
        {
            string email = "vba.rao.com";

            //Act
            bool expected = false;
            bool result = user.validateEmail(email);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod41()
        {
            string phNo = "91 0084323110";

            //Act
            bool expected = false;
            bool result = user.validateMobileNumber(phNo);

            //Assert
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod51()
        {
            string password = "vba@123*";

            //Act
            bool expected = false;
            bool result = user.validatePaswordRule1(password);

            //Assert
            Assert.AreNotEqual(expected, result);
        }
    }
}