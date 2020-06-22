using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services
{
    public class ConferenceMemoryService : IConferenceService
    {
        private readonly List<ConferenceModel> conferences = new List<ConferenceModel>();

        public ConferenceMemoryService()
        {
            conferences.Add(new ConferenceModel { Id = 1, Name = "Pluralsight Live!", Location = "Salt Lake City", Start = new DateTime(2017, 8, 12), AttendeeTotal = 2132 });
            conferences.Add(new ConferenceModel { Id = 2, Name = "GeekConf", Location = "San Francisco", Start = new DateTime(2017, 10, 18), AttendeeTotal = 3210 });
        }
        public Task Add(ConferenceModel model)
        {
            model.Id = conferences.Max(c => c.Id) + 1;
            conferences.Add(model);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<ConferenceModel>> GetAll()
        {
            return Task.Run(() => conferences.AsEnumerable());
        }

        public Task<ConferenceModel> GetById(int id)
        {
            return Task.Run(() => conferences.First(c => c.Id == id));
        }

        public Task<StatisticsModel> GetStatistics()
        {
            return Task.Run(() =>
            {
                return new StatisticsModel
                {
                    NumberOfAttendees = conferences.Sum(c => c.AttendeeTotal),
                    AverageConferenceAttendees = (int)conferences.Average(c => c.AttendeeTotal)
                };
            });
        }
    }
}

