namespace MudBlazorPlayground.Helpers
{
    public static class StringHelper
    {
        public static string GetInitials(string name)
        {
            string[] nameSplit = name.Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            string initials = "";

            for (var i = 0; i < 2; i++)
            {
                initials += nameSplit[i].Substring(0, 1).ToUpper();
            }

            return initials;
        }
    }
}
