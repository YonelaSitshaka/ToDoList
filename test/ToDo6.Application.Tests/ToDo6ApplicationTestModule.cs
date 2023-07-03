using Volo.Abp.Modularity;

namespace ToDo6;

[DependsOn(
    typeof(ToDo6ApplicationModule),
    typeof(ToDo6DomainTestModule)
    )]
public class ToDo6ApplicationTestModule : AbpModule
{

}
