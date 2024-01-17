using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Services;

namespace App.Components.Layouts;

public partial class MainLayout : LayoutComponentBase, IBrowserViewportObserver, IAsyncDisposable
{
    [Inject]
    private IBrowserViewportService BrowserViewportService { get; set; } = null!;

    protected Breakpoint Breakpoint;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
            await BrowserViewportService.SubscribeAsync(this);

        await base.OnAfterRenderAsync(firstRender);
    }

    Guid IBrowserViewportObserver.Id { get; } = Guid.NewGuid();

    ResizeOptions IBrowserViewportObserver.ResizeOptions { get; } =
        new() { ReportRate = 21, NotifyOnBreakpointOnly = true };

    Task IBrowserViewportObserver.NotifyBrowserViewportChangeAsync(BrowserViewportEventArgs args)
    {
        Breakpoint = args.Breakpoint;
        return InvokeAsync(StateHasChanged);
    }

    public async ValueTask DisposeAsync()
    {
        await BrowserViewportService.UnsubscribeAsync(this);
    }
}