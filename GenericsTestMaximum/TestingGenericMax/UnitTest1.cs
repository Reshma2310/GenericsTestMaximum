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
    }
}