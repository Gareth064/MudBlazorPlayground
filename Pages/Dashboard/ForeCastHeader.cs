namespace MudBlazorPlayground.Pages.Dashboard
{
    public class ForeCastHeader
    {
        public int Id { get; set; }
        public string ResourceName { get; set; }
        public DateTime ForecastDate { get; set; }
        public ForecastStatus Status { get; set; }
        public List<ForecastItem> Lines { get; set; }

        public double? GetCurrentActualHours()
        {
            double? hours = 0;

            if (this.Lines is not null && this.Lines.Count > 0)
            {
                foreach (var line in this.Lines)
                {
                        hours += line.ForcastedHours;
                }
            }

            return hours;

        }
    }



    public enum ForecastStatus
    {
        Draft,
        Complete
    }
}
