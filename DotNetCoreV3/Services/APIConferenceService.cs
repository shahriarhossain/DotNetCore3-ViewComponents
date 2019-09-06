using DotNetCoreV3.Interfaces.Services;
using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNetCoreV3.Services
{
    public class APIConferenceService : IConferenceService
    {
        public Task Add(Conference conference)
        {
            throw new NotImplementedException();
        }

        public Task<Conference> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Conference>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Summary> GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}
