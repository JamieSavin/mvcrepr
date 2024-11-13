using DevTalk.Core.Models;
using MediatR;

namespace DevTalk.Contracts.Queries
{
    public record GetDevSpeakerByIdQuery(GetDevSpeakerByIdRequest GetDevSpeakerById) : IRequest<DevSpeaker>;
}
