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
            try
            {
                Patterns patterns = new Patterns();
                string FirstName = Console.ReadLine();
                Assert.IsTrue(patterns.ValidLastName(FirstName));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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