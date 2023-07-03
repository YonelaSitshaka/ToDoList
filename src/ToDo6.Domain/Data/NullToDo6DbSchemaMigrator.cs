using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ToDo6.Data;

/* This is used if database provider does't define
 * IToDo6DbSchemaMigrator implementation.
 */
public class NullToDo6DbSchemaMigrator : IToDo6DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
