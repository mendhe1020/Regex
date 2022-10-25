using Regexs;
using System.Xml.Linq;

namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFirstNameValidation()
        {
            Patterns patterns = new Patterns();
            string FirstName = "Anurag";
            Assert.IsTrue(patterns.ValidLastName(FirstName));
        }

        [TestMethod]
        public void CheckLastNameValidation()
        {
            Patterns patterns = new Patterns();
            string LastName = "Mendhe";
            Assert.IsTrue(patterns.ValidLastName(LastName));
        }

        [TestMethod]
        public void Emailvalidation()
        {
            Patterns patterns = new Patterns();
            string Email = "anurag.mendhe14@gmail.com";
            Assert.IsTrue(patterns.ValideEmailID(Email));;
        }


        [TestMethod]
        public void Emailvalidation1()
        {
            Patterns patterns = new Patterns();
            string Email = "aurag.mendhe14@gmail.com";
            Assert.IsTrue(patterns.ValideEmailID(Email));
        }

        [TestMethod]
        public void Passwordvalidation()
        {
            Patterns patterns = new Patterns();
            string Password = "A106322@";
            Assert.IsTrue(patterns.ValidePassword(Password));
        }
    }
}