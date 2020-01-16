// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegistrationService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace DS.SystemsCommunication.gRPCRegistration.Protos {
  public static partial class RegistrationService
  {
    static readonly string __ServiceName = "RegistrationService";

    static readonly grpc::Marshaller<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest> __Marshaller_RegistrationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult> __Marshaller_RegistrationResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult> __Marshaller_RegistrationTotalResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest> __Marshaller_RegistrationsPacketRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult> __Method_RegisterSingleApplication = new grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegisterSingleApplication",
        __Marshaller_RegistrationRequest,
        __Marshaller_RegistrationResult);

    static readonly grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult> __Method_RegisterApplicationsClientStream = new grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "RegisterApplicationsClientStream",
        __Marshaller_RegistrationRequest,
        __Marshaller_RegistrationTotalResult);

    static readonly grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult> __Method_RegisterApplicationsServerStream = new grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "RegisterApplicationsServerStream",
        __Marshaller_RegistrationsPacketRequest,
        __Marshaller_RegistrationResult);

    static readonly grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult> __Method_RegisterApplicationsBidiractionStream = new grpc::Method<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "RegisterApplicationsBidiractionStream",
        __Marshaller_RegistrationRequest,
        __Marshaller_RegistrationResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RegistrationService</summary>
    [grpc::BindServiceMethod(typeof(RegistrationService), "BindService")]
    public abstract partial class RegistrationServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult> RegisterSingleApplication(global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult> RegisterApplicationsClientStream(grpc::IAsyncStreamReader<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task RegisterApplicationsServerStream(global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest request, grpc::IServerStreamWriter<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task RegisterApplicationsBidiractionStream(grpc::IAsyncStreamReader<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest> requestStream, grpc::IServerStreamWriter<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RegistrationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterSingleApplication, serviceImpl.RegisterSingleApplication)
          .AddMethod(__Method_RegisterApplicationsClientStream, serviceImpl.RegisterApplicationsClientStream)
          .AddMethod(__Method_RegisterApplicationsServerStream, serviceImpl.RegisterApplicationsServerStream)
          .AddMethod(__Method_RegisterApplicationsBidiractionStream, serviceImpl.RegisterApplicationsBidiractionStream).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RegistrationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterSingleApplication, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult>(serviceImpl.RegisterSingleApplication));
      serviceBinder.AddMethod(__Method_RegisterApplicationsClientStream, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult>(serviceImpl.RegisterApplicationsClientStream));
      serviceBinder.AddMethod(__Method_RegisterApplicationsServerStream, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult>(serviceImpl.RegisterApplicationsServerStream));
      serviceBinder.AddMethod(__Method_RegisterApplicationsBidiractionStream, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult>(serviceImpl.RegisterApplicationsBidiractionStream));
    }

  }
}
#endregion