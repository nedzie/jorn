using jorn.Extensions;

namespace jorn.Domain
{
    public class Journey
    {
        private TimeSpan EntryTime;
        private TimeSpan LunchStartTime;
        private TimeSpan LunchEndTime;
        private readonly TimeSpan FullDay = TimeSpan.Parse("08:00");

        public void SetEntryTime(string entryTime)
        {
            EntryTime = TimeSpan.Parse(entryTime.ToTimeSpanFormat());
        }

        public void SetLunchStartTime(string lunchStartTime)
        {
            LunchStartTime = TimeSpan.Parse(lunchStartTime.ToTimeSpanFormat());
        }

        public void SetLunchEndTime(string lunchEndTime)
        {
            LunchEndTime = TimeSpan.Parse(lunchEndTime.ToTimeSpanFormat());
        }

        public TimeSpan GetExitTime()
        {
            var timeWorked = LunchStartTime - EntryTime;
            var residualTime = FullDay - timeWorked;
            var exitTime = LunchEndTime + residualTime;
            return exitTime;
        }
    }
}
