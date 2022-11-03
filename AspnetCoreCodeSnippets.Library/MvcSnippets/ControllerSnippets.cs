using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspnetCoreCodeSnippets.Library.ControllersSnippets;
public static class ControllerSnippets
{
    public static List<SelectListItem> GetSelectList<TEnum>(this TEnum selectedEnumValue, bool isNotRest)
    {
        var listEnum = new List<SelectListItem>();

        foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
        {
            listEnum.Add(new SelectListItem
            {
                Text = Enum.GetName(typeof(TEnum), value),
                Value = value.ToString(),
                Selected = isNotRest == false && value.Equals(selectedEnumValue)
            });
        }
        return listEnum;
    }
}
