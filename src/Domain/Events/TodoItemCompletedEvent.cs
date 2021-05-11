using WargamingTool.Domain.Common;
using WargamingTool.Domain.Entities;

namespace WargamingTool.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
