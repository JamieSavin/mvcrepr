using DevTalk.Core.Models;
using MediatR;

namespace DevTalk.Contracts.Commands
{
    public record CreateDevSpeakerCommand(CreateDevSpeakerRequest DevSpeakerRequest) : IRequest<CreateDevSpeakerResponse>;
}
