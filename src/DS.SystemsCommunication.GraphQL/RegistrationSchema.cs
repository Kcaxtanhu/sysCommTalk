using System;
using DS.SystemsCommunication.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;

namespace DS.SystemsCommunication.GraphQL
{
    public class RegistrationSchema : Schema
    {
        public RegistrationSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<RegistrationQuery>();
        }
    }
}