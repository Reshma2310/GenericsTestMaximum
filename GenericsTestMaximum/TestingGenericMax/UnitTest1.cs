namespace TestingGenericMax
{
    public class Tests
    {        
        [Test]
        public void MaxValueInFirstPosition_CheckMaxNumber_ReturnMaxInFirstPosition()
        {
            int a = 25, b = 10, c = 15;
            GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>();
            var ActualResult = max.MaximumOfInputs<int>(a, b, c);
            Assert.AreEqual(a, ActualResult);
        }
        [Test]
        public void MaxValueInSecondPosition_CheckMaxNumber_ReturnMaxInSecondPosition()
        {
            int a = 25, b = 40, c = 15;
            GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>();
            var ActualResult = max.MaximumOfInputs<int>(a, b, c);
            Assert.AreEqual(b, ActualResult);
        }
        [Test]
        public void MaxValueInThirdPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {
            int a = 25, b = 20, c = 65;
            GenericsTestMaximum.MaximumValue<int> max = new GenericsTestMaximum.MaximumValue<int>();
            var ActualResult = max.MaximumOfInputs<int>(a, b, c);
            Assert.AreEqual(c, ActualResult);
        }
        [Test]
        public void MaxFloatValueInFirstPosition_CheckMaxNumber_ReturnFloatMaxInFirstPosition()
        {
            float a = 25.08f, b = 10.56f, c = 15.92f;
            GenericsTestMaximum.MaximumValue<float> max = new GenericsTestMaximum.MaximumValue<float>();
            var ActualResult = max.MaximumOfInputs<float>(a, b, c);
            Assert.AreEqual(a, ActualResult);
        }
        [Test]
        public void MaxFloatValueInSecondPosition_CheckMaxNumber_ReturnFloatMaxInSecondPosition()
        {
            float a = 25.08f, b = 40.56f, c = 15.95f;
            GenericsTestMaximum.MaximumValue<float> max = new GenericsTestMaximum.MaximumValue<float>();
            var ActualResult = max.MaximumOfInputs<float>(a, b, c);
            Assert.AreEqual(b, ActualResult);
        }
        [Test]
        public void MaxFloatValueInThirdPosition_CheckMaxNumber_ReturnMaxInThirdPosition()
        {
            float a = 25.56f, b = 20.68f, c = 65.05f;
            GenericsTestMaximum.MaximumValue<float> max = new GenericsTestMaximum.MaximumValue<float>();
            var ActualResult = max.MaximumOfInputs<float>(a, b, c);
            Assert.AreEqual(c, ActualResult);
        }
        [Test]
        public void MaxStringtValueInFirstPosition_CheckMaxNumber_ReturnStringMaxInFirstPosition()
        {
            string a = "Yellow", b = "Black", c = "Pink";
            GenericsTestMaximum.MaximumValue<string> max = new GenericsTestMaximum.MaximumValue<string>();
            var ActualResult = max.MaximumOfInputs<string>(a, b, c);
            Assert.AreEqual(a, ActualResult);
        }
        [Test]
        public void MaxStringtValueInSecondPosition_CheckMaxNumber_ReturnStringMaxInSecondPosition()
        {
            string a = "Blue", b = "White", c = "Pink";
            GenericsTestMaximum.MaximumValue<string> max = new GenericsTestMaximum.MaximumValue<string>();
            var ActualResult = max.MaximumOfInputs<string>(a, b, c);
            Assert.AreEqual(b, ActualResult);
        }
        [Test]
        public void MaxStringtValueInThirdPosition_CheckMaxNumber_ReturnStringMaxInThirdPosition()
        {
            string a = "Orange", b = "Black", c = "Violet";
            GenericsTestMaximum.MaximumValue<string> max = new GenericsTestMaximum.MaximumValue<string>();
            var ActualResult = max.MaximumOfInputs<string>(a, b, c);
            Assert.AreEqual(c, ActualResult);
        }
    }
}