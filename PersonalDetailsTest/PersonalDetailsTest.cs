using System;
using PersonalDetails.Classes;

namespace PersonalDetailsTest
{
    public class Tests
    {
        private string _fullName = "Ricky Melville";
        private DateTime _dOB;
        private List<string> TestFortnight = [];
        private int DaysBeforeBirthday;
        [SetUp]
        public void Setup()
        {
            DateTime CurrentDT = DateTime.Now;
        }

        [Test]
        public void GetVowelCountIsEqualTo4()
        {
            int vowelCount = ProcessDetails.GetVowelCount(_fullName);
            Assert.That(vowelCount, Is.EqualTo(4));
        }
        [Test]
        public void GetAgeTestAroundIncludingLapYear()
        {
            _dOB = DateTime.Now.AddDays(-1461);
            int age = ProcessDetails.GetAge(_dOB);
            Assert.That(age, Is.EqualTo(4));
            age--;
            Assert.That(age, Is.EqualTo(3));

        }

        [Test] //Get no of days before birthday
        public void GetNoOfDaysBeforeNextBirthday()
        {
            _dOB = DateTime.Now.AddDays(-12);
            int days = ProcessDetails.GetDaysUntilBirthday(_dOB);
            Assert.That(days, Is.EqualTo(353));
        }

        [Test]
        public void  GetFortnightBeforeBirthday()
        {
            List<string> days = ProcessDetails.Get14Days(_dOB);
            Assert.That(days, Is.EqualTo(TestFortnight));
        }

    }
}