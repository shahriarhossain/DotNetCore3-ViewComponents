using Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreV3.Interfaces.Services
{
    public interface IConferenceService
    {
        Task Add(Conference conference);
        Task<Conference> Get(int id);
        Task<IEnumerable<Conference>> GetAll();
        Task<Summary> GetSummary();
    }
}
