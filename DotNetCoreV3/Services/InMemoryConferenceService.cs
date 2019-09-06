using DotNetCoreV3.Interfaces.Services;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreV3.Services
{
    public class InMemoryConferenceService : IConferenceService
    {
        public List<Conference> conferences = new List<Conference>();
        public InMemoryConferenceService()
        {
            conferences.Add(new Conference() { Id = 1, Name = "Build", Location = "Redmond", TotalAttendee = 25 });
            conferences.Add(new Conference() { Id = 2, Name = "Evolve", Location = "Redmond", TotalAttendee = 30 });
        }
        public Task Add(Conference conference)
        {
            conference.Id = conferences.Max(c => c.Id) + 1;
            conferences.Add(conference);
            return Task.CompletedTask;
        }

        public Task<Conference> Get(int id)
        {
            return Task.Run(()=> conferences.Find(c => c.Id == id));
        }

        public Task<IEnumerable<Conference>> GetAll()
        {
            return Task.Run(() => conferences.AsEnumerable());
        }

        public Task<Summary> GetSummary()
        {
            return Task.Run(() => 
                new Summary() { 
                    Id = 1, 
                    Title = "Award Winning Summary", 
                    Description = "Loream Ipsum" 
                }
        );
        }
    }
}
