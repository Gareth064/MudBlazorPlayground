using MudBlazor.Extensions;

namespace MudBlazorPlayground.Pages.Dashboard.Components
{
    public partial class TimesheetHorizontalList
    {
        MudDatePicker weekpicker;
        public DateTime SelectedWeek;
        public List<DateTime> TableDateHeaders = new List<DateTime>();
        public List<ForeCastHeader> TimeSheets = new List<ForeCastHeader>();

        public void PreviousWeek()
        {
            var currentDate = weekpicker.Date.Value;
            var newDate = currentDate.AddDays(-7);
            weekpicker.Date = newDate;
            GenerateTableDateHeaders();
            //LoadTimeSheetHeaders(newDate, SelectedResourcesToFilterBy.ToList());
            this.StateHasChanged();
        }

        public void NextWeek()
        {
            var currentDate = weekpicker.Date.Value;
            var newDate = currentDate.AddDays(7);
            weekpicker.Date = newDate;
            GenerateTableDateHeaders();
            //LoadTimeSheetHeaders(newDate, SelectedResourcesToFilterBy.ToList());
            this.StateHasChanged();
        }

        public void HandleWeekChange()
        {
            SelectedWeek = weekpicker.Date.Value.StartOfWeek(DayOfWeek.Monday);
            weekpicker.Date = SelectedWeek;
            GenerateTableDateHeaders();
            //LoadTimeSheetHeaders(SelectedWeek, SelectedResourcesToFilterBy.ToList());
            this.StateHasChanged();
        }

        private void GenerateTableDateHeaders()
        {
            var startDate = SelectedWeek;
            TableDateHeaders.Clear();
            for (int i = 0; i < 7; i++)
            {
                TableDateHeaders.Add(startDate);
                startDate = startDate.AddDays(1);
            }
        }

        protected override Task OnInitializedAsync()
        {
            GenerateTableDateHeaders();

            ForeCastHeader fMonday = new ForeCastHeader
            {
                Id = 1,
                ResourceName = "Gareth Doherty",
                ForecastDate =  DateTime.Parse("2022-01-31"),
                Status = ForecastStatus.Complete
            };
            TimeSheets.Add(fMonday);

            ForeCastHeader fTuesday = new ForeCastHeader
            {
                Id = 1,
                ResourceName = "Gareth Doherty",
                ForecastDate =  DateTime.Parse("2022-02-01"),
                Status = ForecastStatus.Complete
            };
            TimeSheets.Add(fTuesday);

            ForeCastHeader fWednesday = new ForeCastHeader
            {
                Id = 1,
                ResourceName = "Gareth Doherty",
                ForecastDate =  DateTime.Parse("2022-02-02"),
                Status = ForecastStatus.Complete
            };
            TimeSheets.Add(fWednesday);

            ForeCastHeader fThursday = new ForeCastHeader
            {
                Id = 1,
                ResourceName = "Gareth Doherty",
                ForecastDate =  DateTime.Parse("2022-02-03"),
                Status = ForecastStatus.Draft
            };
            TimeSheets.Add(fThursday);  

            ForeCastHeader fFriday = new ForeCastHeader
            {
                Id = 0,
                ResourceName = "Gareth Doherty",
                ForecastDate =  DateTime.Parse("2022-02-04"),
                Status = ForecastStatus.Complete
            };
            TimeSheets.Add(fFriday);

            ForeCastHeader fSaturday = new ForeCastHeader
            {
                Id = 0,
                ResourceName = "Gareth Doherty",
                ForecastDate =  DateTime.Parse("2022-02-05"),
                Status = ForecastStatus.Complete
            };
            TimeSheets.Add(fSaturday);

            ForeCastHeader fSunday = new ForeCastHeader
            {
                Id = 0,
                ResourceName = "Gareth Doherty",
                ForecastDate =  DateTime.Parse("2022-02-06"),
                Status = ForecastStatus.Complete
            };
            TimeSheets.Add(fSunday);

            return base.OnInitializedAsync();
        }
    }

    public class TimsheetListLine
    {
        public ForeCastHeader Monday { get; set; }
        public ForeCastHeader Tuesday { get; set; }
        public ForeCastHeader Wednesday { get; set; }
        public ForeCastHeader Thursday { get; set; }
        public ForeCastHeader Friday { get; set; }
        public ForeCastHeader Saturday { get; set; }
        public ForeCastHeader Sunday { get; set; }
    }

}