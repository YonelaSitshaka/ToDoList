using System.Collections.Generic;
using System.Threading.Tasks;


namespace ToDo6.Web.Pages;

public class IndexModel : ToDo6PageModel
{
    public List<TodoItemDto> TodoItems { get; set; }

    private readonly ITodoAppService _todoAppService;

    public IndexModel(ITodoAppService todoAppService)
    {
        _todoAppService = todoAppService;
    }

    public async Task OnGetAsync()
    {
        TodoItems = await _todoAppService.GetListAsync();
    }
    //public void OnGet()
    //{

    //}
}
