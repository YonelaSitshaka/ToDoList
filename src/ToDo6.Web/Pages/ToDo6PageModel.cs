using ToDo6.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ToDo6.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ToDo6PageModel : AbpPageModel
{
    protected ToDo6PageModel()
    {
        LocalizationResourceType = typeof(ToDo6Resource);
    }
}
