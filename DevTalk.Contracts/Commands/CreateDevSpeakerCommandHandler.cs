using DevTalk.Core.Models;
using DevTalk.Infrastructure;
using MediatR;

namespace DevTalk.Contracts.Commands
{
    internal class CreateDevSpeakerCommandHandler(IDevTalkInfra infra) : IRequestHandler<CreateDevSpeakerCommand, CreateDevSpeakerResponse>
    {
        public async Task<CreateDevSpeakerResponse> Handle(CreateDevSpeakerCommand request, CancellationToken cancellationToken)
        {
            return await infra.CreateDevSpeaker(request.DevSpeakerRequest);
        }
    }
}
