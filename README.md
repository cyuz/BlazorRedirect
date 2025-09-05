# BlazorRedirect
Minimal example for Blazor redirect problem

The system route user to welcome page by checking flag.

modify App.razor
- use RoutesWithOnNaviagte, will see some flash.
- use RoutesWithLocationChanging, not work at first open url with browser.
- use RoutesWorkaround, final solution but complex.