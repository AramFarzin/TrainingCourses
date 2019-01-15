namespace FacadeTest
{
    internal class MeetingMaker
    {
        private readonly IMeeting _dailyMeeting;
        private readonly IMeeting _planningMeeting;

        public MeetingMaker()
        {
            _dailyMeeting = new DailyMeeting();
            _planningMeeting = new PlanningMeeting();
        }

        public void SetDailyMeeting()
        {
            _dailyMeeting.SetMeeting();
        }
        public void SetPlanningMeeting()
        {
            _planningMeeting.SetMeeting();
        }
    }
}