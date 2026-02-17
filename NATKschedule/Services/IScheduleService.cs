using NATKschedule.DTO;

namespace NATKschedule.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
startDate, DateTime endDate);
    }
}
