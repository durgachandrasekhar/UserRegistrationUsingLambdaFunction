using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_Exceptions;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// FirstName UC1
        /// </summary>
        /// <param name="firstName"></param>
        [TestMethod]
        [DataRow("Durgachandrasekhar")]
        public void Given_InvalidInput_FirstName_ThrowExceptionCustomMessage_InvalidInput(string firstName)
        {
            UserInput userInput = new UserInput();
            Assert.ThrowsException<ExceptionHandling>(() => userInput.FirstName(firstName));
        }
        /// <summary>
        /// Last Name UC2
        /// </summary>
        /// <param name="lastName"></param>
        [TestMethod]
        [DataRow("Chintalapudi")]
        public void Given_InvalidInput_LastName_ThrowExceptionCustomMessage_InvalidInput(string lastName)
        {
            UserInput userInput = new UserInput();
            Assert.ThrowsException<ExceptionHandling>(() => userInput.LastName(lastName));
        }
        /// <summary>
        /// Email : UC3,9
        /// </summary>
        /// <param name="email"></param>
        [TestMethod]

        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void Given_InvalidInput_Email_ThrowExceptionCustomMessage_InvalidInput(string email)
        {
            UserInput userInput = new UserInput();
            Assert.ThrowsException<ExceptionHandling>(() => userInput.Email(email));
        }
        /// <summary>
        /// Mobile Number : UC4
        /// </summary>
        /// <param name="mobile"></param>
        [TestMethod]
        [DataRow("9490212578")]
        public void Given_InvalidInput_MobileNumber_ThrowExceptionCustomMessage_InvalidInput(string mobile)
        {
            UserInput userInput = new UserInput();
            Assert.ThrowsException<ExceptionHandling>(() => userInput.Mobile(mobile));
        }
        /// <summary>
        /// Password hav Minimum 8 characters,1UpperCase,1 Number, 1 Special Character : UC5,6,7,8
        /// </summary>
        /// <param name="password"></param>
        [TestMethod]
        [DataRow("jashdAhb")]
        public void Given_InvalidInput_Password_ThrowExceptionCustomMessage_InvalidInput(string password)
        {
            UserInput userInput = new UserInput();
            Assert.ThrowsException<ExceptionHandling>(() => userInput.Password(password));
        }
    }
}