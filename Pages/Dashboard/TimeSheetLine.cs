namespace MudBlazorPlayground.Pages.Dashboard
{
    public class TimeSheetLine
    {
        public ActivityType? Activity { get; set; }
        public ProjectType? Project { get; set; }
        public double Time { get; set; }
        public string Note { get; set; }
    }
}
