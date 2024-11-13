using DevTalk.Core.Models;

namespace DevTalk.Infrastructure
{
    public interface IDevTalkInfra
    {
        Task<CreateDevSpeakerResponse> CreateDevSpeaker(CreateDevSpeakerRequest request);

        Task<DevSpeaker> GetDevSpeakerById(long id);
    }
}
