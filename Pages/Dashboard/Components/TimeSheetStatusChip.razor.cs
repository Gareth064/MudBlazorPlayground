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

namespace MudBlazorPlayground.Pages.Dashboard.Components
{
    public partial class TimeSheetStatusChip
    {
        [Parameter] public ForeCastHeader Sheet { get; set; }
        [Parameter] public EventCallback<ForeCastHeader> OnChipClicked { get; set; }

        private async Task HandleChipClicked()
        {
            await OnChipClicked.InvokeAsync(Sheet);
        }
    }
}