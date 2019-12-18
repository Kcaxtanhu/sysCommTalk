using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Core;
using System.Text;
using Microsoft.Extensions.Logging;

namespace DS.SystemsCommunication.gRPCRegistration
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        public async override Task<RegistrationReply> RegisterApplications(RegistrationRequest request, ServerCallContext context)
        {
            var processed = (10).ToString();
            var cont = 0;

            while (cont <= 10)
            {
                cont++;

                //using var client = new HttpClient();
                //client.BaseAddress = new Uri("http://localhost:5011/api");
                //var content = new StringContent(request.RegistrationList, Encoding.ASCII, "application/json");

                //processed = await client.GetStringAsync("/seat");
            }

            return await Task.FromResult(new RegistrationReply
            {
                NoProcessed = processed
            });
        }
    }
}
