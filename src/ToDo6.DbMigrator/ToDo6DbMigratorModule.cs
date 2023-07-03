using ToDo6.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ToDo6.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ToDo6EntityFrameworkCoreModule),
    typeof(ToDo6ApplicationContractsModule)
    )]
public class ToDo6DbMigratorModule : AbpModule
{

}
