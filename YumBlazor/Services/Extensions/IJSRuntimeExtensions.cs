using Microsoft.JSInterop;

namespace YumBlazor.Services.Extensions
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime _JSRuntime, string message)
        {
            await _JSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async Task ToastrError(this IJSRuntime _JSRuntime, string message)
        {
            await _JSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        public static async Task ShowConfirmationModal(this IJSRuntime _JSRuntime)
        {
            await _JSRuntime.InvokeVoidAsync("ShowConfirmationModal");
        }

        public static async Task HideConfirmationModal(this IJSRuntime _JSRuntime)
        {
            await _JSRuntime.InvokeVoidAsync("HideConfirmationModal");
        }
    }
}