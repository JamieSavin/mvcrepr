using DevTalk.Core.Models;
using DevTalk.Infrastructure;
using MediatR;

namespace DevTalk.Contracts.Queries
{
    internal class GetDevSpeakerByIdHandler(IDevTalkInfra infra) : IRequestHandler<GetDevSpeakerByIdQuery, DevSpeaker>
    {
        public async Task<DevSpeaker> Handle(GetDevSpeakerByIdQuery request, CancellationToken cancellationToken)
        {
            return await infra.GetDevSpeakerById(request.GetDevSpeakerById.DevSpeakerId);
        }
    }
}
