using System;
using System.Collections.Generic;
using System.Text;
using ToDo6.Localization;
using Volo.Abp.Application.Services;

namespace ToDo6;

/* Inherit your application services from this class.
 */
public abstract class ToDo6AppService : ApplicationService
{
    protected ToDo6AppService()
    {
        LocalizationResource = typeof(ToDo6Resource);
    }
}
