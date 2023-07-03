using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ToDo6.Web;

[Dependency(ReplaceServices = true)]
public class ToDo6BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ToDo6";
}
