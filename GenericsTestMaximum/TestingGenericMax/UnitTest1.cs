namespace TestingGenericMax
{
    public class Tests
    {     
        [Test]
        public void IntergerArray_CheckMaxNumber_ReturnMaxIntValue()
        {
            int[] array = { 25, 10, 15, 5, 60 };
            GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>(array);
            var ActualResult = max.MaxValue();
            Assert.AreEqual(60, ActualResult);
        }
        [Test]
        public void FloatArray_CheckMaxNumber_ReturnMaxFlaotValue()
        {
            float[] array = { 1.2f, 2.3f, 22.6f, 50.7f, 0.85f };
            GenericsTestMaximum.MaximumValue<float> max = new GenericsTestMaximum.MaximumValue<float>(array);
            var ActualResult = max.MaxValue();
            Assert.AreEqual(50.7f, ActualResult);
        }
        [Test]
        public void StringArray_CheckMaxNumber_ReturnMaxString()
        {
            string[] array = { "Red", "Blue", "Pink", "Orange" };
            GenericsTestMaximum.MaximumValue<string> max = new GenericsTestMaximum.MaximumValue<string>(array);
            var ActualResult = max.MaxValue();
            Assert.AreEqual("Red", ActualResult);
        }
    }
}