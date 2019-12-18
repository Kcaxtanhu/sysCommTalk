using System;
using DS.SystemsCommunication.Common.Models;
using DS.SystemsCommunication.Common.Enums;
using GraphQL.Types;

namespace DS.SystemsCommunication.GraphQL.ModelsTypes
{
    public class RegistrationType : ObjectGraphType<Registration>
    {
        public RegistrationType()
        {
            Name = "Registration";

            Field(x => x.RegistrationId).Description("Registration Identification");
            Field(x => x.Name).Description("Individual Name");
            Field(x => x.RegistrationDate).Description("Registration Date");
            Field(x => x.Email).Description("Individual Email");
            Field(x => x.MobileNo).Description("Mobilne Number");
            Field(x => x.Status).Description("Registration Status");
        }
    }

    public class StatusType : EnumerationGraphType<Status>
    {
        public StatusType()
        {
            Name = "Status";
            Description = "Registration Status";
            AddValue("Inserted", "Value Inserted", 1);
            AddValue("Confirmed", "Registration Confirmed", 2);
            AddValue("Waiting", "Pendig session", 3);
        }
    }
}