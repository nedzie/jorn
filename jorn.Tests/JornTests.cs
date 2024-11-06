using FluentAssertions;

namespace jorn.Tests
{
    [TestClass]
    public class JornTests
    {
        [TestMethod]
        public void Jorn_Should_ReturnValidExitTime_When_ValidTimeIsProvided()
        {
            var journey = JourneyBuilder
                            .Create()
                            .WithEntry("0800")
                            .WithLunchStart("1200")
                            .WithLunchEnd("1300")
                            .Build();

            var exitTime = journey.GetExitTime();

            var rightExitTime = TimeSpan.Parse("17:00");

            exitTime.Should().Be(rightExitTime);
        }
    }
}