using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace ToDo6;

public class ToDo6WebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ToDo6WebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
