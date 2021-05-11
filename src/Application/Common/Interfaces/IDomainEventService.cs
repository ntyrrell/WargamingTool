using WargamingTool.Domain.Common;
using System.Threading.Tasks;

namespace WargamingTool.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
