using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testNuke.Tests
{
    [TestClass]
    public class TestBase
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        // ReSharper disable once MemberCanBePrivate.Global
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public TestContext TestContext { get; set; }

        #endregion

        [TestMethod]
        public void TestMethod()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}