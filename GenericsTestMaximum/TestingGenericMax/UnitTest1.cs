namespace TestingGenericMax
{
    public class Tests
    {        
        [Test]
        public void MaxValueInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {
            int a = 25, b = 10, c = 15;
            GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>();
            var ActualResult = max.MaximumOfAll(a, b, c);
            Assert.AreEqual(a, ActualResult);
        }
        [Test]
        public void MaxValueInSecondPosition_CheckMaxNumber_ReturnMaxInSecondPosition()
        {
            int a = 25, b = 40, c = 15;
            GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>();
            var ActualResult = max.MaximumOfAll(a, b, c);
            Assert.AreEqual(b, ActualResult);
        }
        [Test]
        public void MaxValueInThirdPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {
            int a = 25, b = 20, c = 65;
            GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>();
            var ActualResult = max.MaximumOfAll(a, b, c);
            Assert.AreEqual(c, ActualResult);
        }
    }
}