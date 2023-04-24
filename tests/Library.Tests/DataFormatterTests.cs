using NUnit.Framework;
using TestDateFormat;

namespace TestDateFormat.Tests
{
    public class DateFormatterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFormatDate_US()
        {
            // Arrange
            var date = new DateTime(2023, 4, 24);
            var expected = "04/24/2023";

            // Act
            var result = DateFormatter.ChangeFormat(date, "US");

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestFormatDate_UK()
        {
            // Arrange
            var date = new DateTime(2023, 4, 24);
            var expected = "24/04/2023";

            // Act
            var result = DateFormatter.ChangeFormat(date, "UK");

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestFormatDate_InvalidFormat()
        {
            // Arrange
            var date = new DateTime(2023, 4, 24);
            var expected = "";

            // Act
            var result = DateFormatter.ChangeFormat(date, "invalid");

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
