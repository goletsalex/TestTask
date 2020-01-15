using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskApp.DataSources;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestTaskApp.DataSources.Tests
{
    [TestClass()]
    public class SymbolResultsTests
    {
        private const string outputValue = "AFA21";

        private List<Models.SymbolCount> GetExpectedList()
        {
            var expected = new List<Models.SymbolCount>();
            expected.Add(new Models.SymbolCount() { Symbol = "1", Count = "1" });
            expected.Add(new Models.SymbolCount() { Symbol = "2", Count = "1" });
            expected.Add(new Models.SymbolCount() { Symbol = "A", Count = "2" });
            expected.Add(new Models.SymbolCount() { Symbol = "F", Count = "1" });

            return expected;
        }

        [TestMethod()]
        public void GetSymbolResultsSource_PositiveTest()
        {
            var actual = SymbolResults.GetSymbolResultsSource(outputValue);

            Assert.IsInstanceOfType(actual, typeof(BindingSource));
        }

        [TestMethod()]
        public void GetSymbolResultsSource_NegativeTest()
        {
            var actual = SymbolResults.GetSymbolResultsSource("");

            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void CalculateChars_PositiveTest()
        {
            var expected = GetExpectedList();

            var actual = SymbolResults.CalculateChars(outputValue);

            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod()]
        public void CalculateChars_NegativeTest()
        {
            var expected = GetExpectedList();

            var actual = SymbolResults.CalculateChars("");

            Assert.AreNotEqual(expected.Count, actual.Count);
        }
    }
}