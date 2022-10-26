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
                string FirstName = "2";
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
           try
            {
                Patterns patterns = new Patterns();
                string LastName = "Mendhe";
                Assert.IsTrue(patterns.ValidLastName(LastName));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Emailvalidation()
        {
           try
            {
                Patterns patterns = new Patterns();
                string Email = "anurag.mendhe14@gmail.com";
                Assert.IsTrue(patterns.ValideEmailID(Email));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Emailvalidation1()
        {
           try
            {
                Patterns patterns = new Patterns();
                string Email = "aurag.mendhe14@gmail.com";
                Assert.IsTrue(patterns.ValideEmailID(Email));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Passwordvalidation()
        {
           try
            {
                Patterns patterns = new Patterns();
                string Password = "A106322@";
                Assert.IsTrue(patterns.ValidePassword(Password));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}