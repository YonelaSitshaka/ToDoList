using ToDo6.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ToDo6.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ToDo6Controller : AbpControllerBase
{
    protected ToDo6Controller()
    {
        LocalizationResource = typeof(ToDo6Resource);
    }
}
