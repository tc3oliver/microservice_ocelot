using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ocelot.Middleware;
using Ocelot.Multiplexer;

namespace ocelot_gateway
{
    public class FakeDefinedAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            var one = await responses[0].Items.DownstreamResponse().Content.ReadAsStringAsync();
            var two = await responses[1].Items.DownstreamResponse().Content.ReadAsStringAsync();

            var merge = $"{one}, {two}";
            var headers = responses.SelectMany(x => x.Items.DownstreamResponse().Headers).ToList();
            return new DownstreamResponse(new StringContent(merge), HttpStatusCode.OK, headers, "some reason");
        }

    }
    
}