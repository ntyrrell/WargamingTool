using WargamingTool.Application.Common.Mappings;
using WargamingTool.Domain.Entities;

namespace WargamingTool.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
