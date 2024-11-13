using DevTalk.Contracts.Commands;
using DevTalk.Contracts.Queries;
using DevTalk.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevTalk.API.MVC.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DevTalkController(IMediator mediator) : ControllerBase
    {
       
        // GET api/<DevTalkController>/5
        [HttpGet("{id}")]
        public async Task<DevSpeaker> Get(long id)
        {
            return await mediator.Send(new GetDevSpeakerByIdQuery(new GetDevSpeakerByIdRequest(id)));
        }

        // POST api/<DevTalkController>
        [HttpPost]
        public async Task<CreateDevSpeakerResponse> Post([FromBody] CreateDevSpeakerRequest value)
        {
            return await mediator.Send(new CreateDevSpeakerCommand(value));
        }

        
    }
}
