using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspnetCoreCodeSnippets.Library.MvcSnippets;
public static class HtmlSnippets
{
    public const string CssActiveClass = "active";
    public static string IsSelected(this IHtmlHelper htmlHelper, string controller,
        params string[] actions)
    {
        string? currentAction = htmlHelper.ViewContext.RouteData.Values["action"] as string;
        string? currentController = htmlHelper.ViewContext.RouteData.Values["controller"] as string;

        if (actions.Contains(currentAction) && controller == currentController)
        {
            return CssActiveClass;
        }

        return String.Empty;
    }

    public static string IsSelectedAreaPage(this IHtmlHelper htmlHelper, string area,
        params string[] pages)
    {
        string? currentArea = htmlHelper.ViewContext.RouteData.Values["area"] as string;
        string? currentPage = htmlHelper.ViewContext.RouteData.Values["page"] as string;

        if (pages.Contains(currentPage) && area == currentArea)
        {
            return CssActiveClass;
        }

        return String.Empty;
    }

}
