using NATKschedule.DTO;

namespace NATKschedule.Services
{
    public interface IScheduleService
    {
        Task<List<string>> GetAllGroups();
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
startDate, DateTime endDate);


      
    }
}
