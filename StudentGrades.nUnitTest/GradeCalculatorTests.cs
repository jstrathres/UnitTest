using BasicUnitTest;
using NUnit.Framework;

namespace StudentGrades.nUnitTest
{
    public class GradeCalculatorTests
    {

        private GradeCalculator _gradeCalculator { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(91)]
        [TestCase(96)]
        [TestCase(99)]
        [TestCase(100)]
        [TestCase(93)]
        [TestCase(94)]
        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            //ASSIGN
            //var percent = 99;

            //ACT
            var grade = _gradeCalculator.GetGradeCalculator(percentage);

            //ASSERT
            Assert.AreEqual("A", grade);    
        }

        [TestCase(12)]
        [TestCase(1)]
        [TestCase(56)]
        [TestCase(79)]
        [TestCase(89)]
        [TestCase(35)]
        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {
            //ASSIGN
            //var percent = 99;

            //ACT
            var grade = _gradeCalculator.GetGradeCalculator(percentage);

            //ASSERT
            Assert.AreNotEqual("A", grade);
        }
    }
}