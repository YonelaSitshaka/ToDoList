using System.Threading.Tasks;

namespace ToDo6.Data;

public interface IToDo6DbSchemaMigrator
{
    Task MigrateAsync();
}
