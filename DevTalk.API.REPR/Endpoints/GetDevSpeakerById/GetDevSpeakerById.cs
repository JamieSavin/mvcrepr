using DevTalk.Contracts.Queries;
using DevTalk.Core.Models;
using FastEndpoints;
using MediatR;

namespace DevTalk.API.REPR.Endpoints.GetDevSpeakerById
{
    public class GetDevSpeakerById(IMediator mediator) : Endpoint<GetDevSpeakerByIdRequest, DevSpeaker>
    {
        public override void Configure()
        {
            Get("");
            Group<DevSpeakerGroup>();
            AllowAnonymous();
        }

        public override async Task<DevSpeaker> ExecuteAsync(GetDevSpeakerByIdRequest req, CancellationToken ct)
        {
            return await mediator.Send(new GetDevSpeakerByIdQuery(req), ct);
        }
    }
}
