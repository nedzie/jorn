using jorn.Domain;

namespace jorn.Tests
{
    public  class JourneyBuilder
    {
        private Journey _journey;

        public static JourneyBuilder Create()
        {
            var builder = new JourneyBuilder();
            builder._journey = new Journey();
            return builder;
        }

        public JourneyBuilder WithEntry(string entry)
        {
            _journey.SetEntryTime(entry);
            return this;
        }

        public JourneyBuilder WithLunchStart(string lunchStart)
        {
            _journey.SetLunchStartTime(lunchStart);
            return this;
        }

        public JourneyBuilder WithLunchEnd(string lunchEnd)
        {
            _journey.SetLunchEndTime(lunchEnd);
            return this;
        }

        public Journey Build()
        {
            return _journey;
        }
    }
}
