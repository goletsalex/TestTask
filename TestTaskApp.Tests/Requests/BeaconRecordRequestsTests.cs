using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace TestTaskApp.Requests.Tests
{
    [TestClass()]
    public class BeaconRecordRequestsTests
    {
        [TestMethod()]
        public void GetOutputValue_PositiveTest()
        {
            var expected = "1A13A30ED048D48603F062993C69648C0FBF56DB5FE13FA3817511FFCD6AD1E7C81C7F82055DB20E18993678E9C71BBC1C4228C29C8320CE477DF1CE9945AF1E";

            var actual = string.Empty;
            Task.Run(async () =>
            {
                actual = await Requests.BeaconRecordRequests.GetOutputValue(1545840420);
            }).GetAwaiter().GetResult();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetOutputValue_NegativeTest()
        {
            var expected = string.Empty;

            var actual = "---";
            Task.Run(async () =>
            {
                actual = await Requests.BeaconRecordRequests.GetOutputValue(999999999);
            }).GetAwaiter().GetResult();

            Assert.AreNotEqual(expected, actual);
        }
    }
}