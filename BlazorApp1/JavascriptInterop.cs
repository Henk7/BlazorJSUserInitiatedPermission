using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1
{
    public static class JavascriptInterop
    {
        public async static Task CopyTextToClipboardAsync(this IJSRuntime runtime, string text)
        {
            await runtime.InvokeAsync<object>("JSInteropCS.CopyTextToClipboard", text);
        }
    }
}
