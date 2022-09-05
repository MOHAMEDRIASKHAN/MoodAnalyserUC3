namespace MoodAnayls3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood()
        {
            string meassage = "I am in Sad Mood";
            MoodAnayls moodAnalyzer = new MoodAnayls(meassage);
            string ExpectedOutput = "SAD";

            string result = moodAnalyzer.AnalyseMood();

            Assert.AreEqual(result, ExpectedOutput);
        }
    }
}