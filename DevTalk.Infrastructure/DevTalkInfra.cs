using DevTalk.Core.Models;

namespace DevTalk.Infrastructure
{
    public class DevTalkInfra() : IDevTalkInfra
    {
        public async Task<CreateDevSpeakerResponse> CreateDevSpeaker(CreateDevSpeakerRequest request)
        {
            await Task.Delay(100);
            return new CreateDevSpeakerResponse { DevSpeakerId = 100 };
        }

        public async Task<DevSpeaker> GetDevSpeakerById(long id)
        {
            await Task.Delay(100);
            return new DevSpeaker { DevSpeakerId = id, Email = "jamiesavin@gmail.com", FirstName = "Jamie", LastName = "Savin", JobTitle = "Software Architect" };
        }
    }
}
