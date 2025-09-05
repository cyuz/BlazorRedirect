using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace BlazorApp1.Util
{
    public static class RedirectHandler
    {
        public static async Task<bool> VeirfySholudRedirectAsync(ProtectedSessionStorage protectedSessionStore)
        {
            var result = await protectedSessionStore.GetAsync<string>("FirstLogin");
            bool isFirstLogin = !result.Success || string.IsNullOrEmpty(result.Value);

            if (!isFirstLogin)
            {
                return false;
            }

            await protectedSessionStore.SetAsync("FirstLogin", false);

            return true;
        }

        public static async Task DeleteFlagAsync(ProtectedSessionStorage protectedSessionStore)
        {
            await protectedSessionStore.DeleteAsync("FirstLogin");
        }
    }
}
