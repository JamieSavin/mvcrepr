using FastEndpoints;

namespace DevTalk.API.REPR.Endpoints
{
    public class DevSpeakerGroup : Group
    {
        public DevSpeakerGroup()
        {
            Configure("DevSpeakers", ep =>
            {
                ep.Description(x => x.Produces(200));
            });
        }

    }
}
