using System.Security.Claims;

namespace API;

public static class ClaimsPrincipleExtensions
{
    public static string GetUserName(this ClaimsPrincipal principal)
    {
        return principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }
}
