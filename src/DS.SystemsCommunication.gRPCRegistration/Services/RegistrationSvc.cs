using DS.SystemsCommunication.gRPCRegistration.Protos;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS.SystemsCommunication.gRPCRegistration.Services
{
    public class RegistrationSvc : RegistrationService.RegistrationServiceBase
    {
        public override Task RegisterApplicationsBidiractionStream(IAsyncStreamReader<Protos.RegistrationRequest> requestStream, IServerStreamWriter<RegistrationResult> responseStream, ServerCallContext context)
        {
            //while (await requestStream.MoveNext())
            //{
            //    var request = requestStream.Current;
            //    await responseStream.WriteAsync(new RegistrationResult()
            //    {
            //        RegistrationId = request.RegistrationId,
            //        Status = RegistrationStatus.Sucess
            //    });
            //}

            return Task.CompletedTask;
        }

        public override async Task<RegistrationTotalResult> RegisterApplicationsClientStream(IAsyncStreamReader<Protos.RegistrationRequest> requestStream, ServerCallContext context)
        {
            var reply = new Protos.RegistrationTotalResult();

            while (await requestStream.MoveNext())
            {
                var request = requestStream.Current;
                reply.Status = RegistrationStatus.Sucess;
            }

            return await Task.FromResult(reply);
        }

        public override Task RegisterApplicationsServerStream(RegistrationsPacketRequest request, IServerStreamWriter<RegistrationResult> responseStream, ServerCallContext context)
        {
            foreach (var registration in request.Registrations)
            {
                responseStream.WriteAsync(new RegistrationResult()
                {
                    RegistrationId = registration.RegistrationId,
                    Status = RegistrationStatus.Sucess
                });
            }

            return Task.CompletedTask;
        }

        public async override Task<RegistrationResult> RegisterSingleApplication(Protos.RegistrationRequest request, ServerCallContext context)
        {
            return await Task.FromResult(
                new RegistrationResult
                {
                    RegistrationId = request.RegistrationId,
                    Status = RegistrationStatus.Sucess
                }
            );
        }
    }
}
