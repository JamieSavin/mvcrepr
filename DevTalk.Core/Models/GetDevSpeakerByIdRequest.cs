using MediatR;

namespace DevTalk.Core.Models
{
    public record GetDevSpeakerByIdRequest(long DevSpeakerId) : IRequest;


}
