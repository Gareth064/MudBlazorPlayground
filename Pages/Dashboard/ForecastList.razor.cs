namespace MudBlazorPlayground.Pages.Dashboard
{
    public partial class ForecastList
    {
        IEnumerable<IGrouping<DateTime, IGrouping<string, ForecastItem>>> mudListresults;
        IEnumerable<IGrouping<DateTime, ForecastItem>> mudTableresults;
        public string ListStyle_Radio { get; set; } = "MudTable";

        protected override Task OnInitializedAsync()
        {
            List<ForecastItem> forecasts = new List<ForecastItem>
            {
                new ForecastItem { ForecastDate = DateTime.Parse("2022-01-31"), ResourceName="Gareth Doherty", ActivityName="Project", ForcastedHours=9 },
                new ForecastItem { ForecastDate = DateTime.Parse("2022-02-01"), ResourceName="Gareth Doherty", ActivityName="Annual Leave", ForcastedHours=9 },
                new ForecastItem { ForecastDate = DateTime.Parse("2022-02-02"), ResourceName="Gareth Doherty", ActivityName="None", ForcastedHours=0 },
                new ForecastItem { ForecastDate = DateTime.Parse("2022-02-03"), ResourceName="Gareth Doherty", ActivityName="Project", ForcastedHours=5.5 },
                new ForecastItem { ForecastDate = DateTime.Parse("2022-02-03"), ResourceName="Gareth Doherty", ActivityName="IT - Admin", ForcastedHours=3.5 },
                new ForecastItem { ForecastDate = DateTime.Parse("2022-02-04"), ResourceName="Gareth Doherty", ActivityName="Env Refresh", ForcastedHours=9.0 },
                new ForecastItem { ForecastDate = DateTime.Parse("2022-02-05"), ResourceName="Gareth Doherty", ActivityName="Non-Working Day", ForcastedHours=9.0 }
            };

            mudListresults = from forecast in forecasts
                          group forecast by forecast.ForecastDate into dateGroup
                          from resourceGroup in
                              (from forecast in dateGroup
                               group forecast by forecast.ResourceName)
                          group resourceGroup by dateGroup.Key;

            mudTableresults =  forecasts.GroupBy(l => l.ForecastDate);

            return base.OnInitializedAsync();
        }
    }
}