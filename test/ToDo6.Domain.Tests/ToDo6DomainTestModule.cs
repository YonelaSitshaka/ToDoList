using ToDo6.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ToDo6;

[DependsOn(
    typeof(ToDo6EntityFrameworkCoreTestModule)
    )]
public class ToDo6DomainTestModule : AbpModule
{

}
