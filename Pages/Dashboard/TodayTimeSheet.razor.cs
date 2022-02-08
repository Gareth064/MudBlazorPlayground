using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using MudBlazor;
using MudBlazorPlayground;
using MudBlazorPlayground.Shared;

namespace MudBlazorPlayground.Pages.Dashboard
{
    public partial class TodayTimeSheet
    {
        MudTable<TimeSheetLine> table;
        List<TimeSheetLine> TimeSheets { get; set; }
        List<ActivityType> ActivityTypes { get; set; } = new List<ActivityType>();
        List<ProjectType> ProjectTypes { get; set; } = new List<ProjectType>();
        TimeSheetLine selectedItem1 = null;
        TimeSheetLine timesheetBeforeEdit;

        private void BackupItem(object timesheet)
        {
            timesheetBeforeEdit = new()
            {
                Activity = ((TimeSheetLine)timesheet).Activity,
                Project = ((TimeSheetLine)timesheet)?.Project,
                Time = ((TimeSheetLine)timesheet).Time,
                Note = ((TimeSheetLine)timesheet).Note
            };
        }

        private async Task AddNewTimeSheet()
        {
            var newitem = new TimeSheetLine { Activity = new ActivityType() };
            TimeSheets.Add(newitem);
            await Task.Delay(25);
            table.SetEditingItem(newitem);            
            this.StateHasChanged();
        }

        private string TimeValidator(double arg)
        {
            if (arg == 0 || arg < 0)
                return "Input time";
            return null;
        }

        protected override Task OnInitializedAsync()
        {
            TimeSheets = new List<TimeSheetLine>();
            ActivityTypes.Add(new ActivityType { Name = "Activity 1" });
            ActivityTypes.Add(new ActivityType { Name = "Project" });
            ProjectTypes.Add(new ProjectType { Name = "Project 1" });
            ProjectTypes.Add(new ProjectType { Name = "Project 2" });

            return base.OnInitializedAsync();
        }
    }


}