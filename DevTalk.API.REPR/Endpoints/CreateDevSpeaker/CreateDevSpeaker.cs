using DevTalk.Contracts.Commands;
using DevTalk.Core.Models;
using FastEndpoints;
using MediatR;

namespace DevTalk.API.REPR.Endpoints.CreateDevSpeaker
{
    public class CreateDevSpeaker(IMediator mediator) : Endpoint<CreateDevSpeakerRequest, CreateDevSpeakerResponse>
    {
        public override void Configure()
        {
            
            Post("");
            Group<DevSpeakerGroup>();
            AllowAnonymous();
        }

        public override async Task<CreateDevSpeakerResponse> ExecuteAsync(CreateDevSpeakerRequest req, CancellationToken ct)
        {
            return await mediator.Send(new CreateDevSpeakerCommand(req), ct);
        }
    }
}
 