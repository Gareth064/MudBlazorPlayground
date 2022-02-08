namespace MudBlazorPlayground.Pages.Dashboard
{
    public class ForecastItem
    {
        public DateTime ForecastDate { get; set; }
        public string ResourceName { get; set; }
        public string ActivityName { get; set; }
        public double ForcastedHours { get; set; }

        public string GetInitials()
        {
                // StringSplitOptions.RemoveEmptyEntries excludes empty spaces returned by the Split method

                string[] nameSplit = ResourceName.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

                string initials = "";

            for (var i = 0; i < 2; i++)
                {
                    initials += nameSplit[i].Substring(0, 1).ToUpper();
                }

                return initials;
        }

    }
}