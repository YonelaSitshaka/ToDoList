using Volo.Abp.Settings;

namespace ToDo6.Settings;

public class ToDo6SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ToDo6Settings.MySetting1));
    }
}
