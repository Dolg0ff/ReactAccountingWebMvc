using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReactAccountingWebMvc.Domain;

namespace DBTest
{
    [TestClass]
    public class DBTestBase
    {
        //OutsideDBContext db = new OutsideDBContext();
        protected static ApplicationContext db { get; set; }

        /// <summary>
        /// Executes once before the test run. (Optional)
        /// </summary>
        /// <param name="context"></param>
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            db = new ApplicationContext().CreateTestContext();
            db.Database.EnsureCreated();
        }
        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {

        }

        [TestInitialize]
        public void Setup()
        {

        }

        /// <summary>
        /// Executes once after the test run. (Optional)
        /// </summary>
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }

        /// <summary>
        /// Runs once after all tests in this class are executed. (Optional)
        /// Not guaranteed that it executes instantly after all tests from the class.
        /// </summary>
        [ClassCleanup]
        public static void TestFixtureTearDown()
        {


        }

        /// <summary>
        /// Runs after each test. (Optional)
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
            //don`t call! delete database instead of tables!
            //db.Database.EnsureDeleted();

        }

    }
}
