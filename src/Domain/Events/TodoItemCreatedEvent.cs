using WargamingTool.Domain.Common;
using WargamingTool.Domain.Entities;

namespace WargamingTool.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
