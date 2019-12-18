using DS.SystemsCommunication.Common.Models;
using DS.SystemsCommunication.GraphQL.ModelsTypes;
using GraphQL.Types;
using System;
using System.Linq;
using System.Collections.Generic;
using DS.SystemsCommunication.Common.Enums;

namespace DS.SystemsCommunication.GraphQL.Queries
{
    public  class RegistrationQuery : ObjectGraphType
    {
        private IEnumerable<Registration> _registrations;

        public RegistrationQuery()
        {
            _registrations = new List<Registration>()
            {
                new Registration() { Name = "Bruno Cardoso", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "bscardoso@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Bernardo Teixeira", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "bteixeira@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Luís Pires", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "lpires@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Hélio Rodrigues", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "htrodrigues@primeit.pt", MobileNo = "932333333" },
                new Registration() { Name = "Joana Correia", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "jscorreia@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Susana Agrela", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "sagrala@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Bruno Coimbra", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "bcoimbra@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Filipe Monterroso", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "fmonterroso@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Rita Oliveira", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "roliveira@primeit.pt", MobileNo = "932333333" },
                new Registration() { Name = "Vera Moreira", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "vcmoreira@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "David Ricardo", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "dricardo@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Joana Salvado", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "jsalvado@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Bruno Ferreira", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "bferreira@primeit.pt", MobileNo = "932222222" },
                new Registration() { Name = "Rita Silva", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "rsilva@primeit.pt", MobileNo = "932333333" },
                new Registration() { Name = "Beatriz Costa", RegistrationDate = DateTime.Parse("01-12-2019"), Email = "bcosta@primeit.pt", MobileNo = "932222222" }
            };

            Field<ListGraphType<RegistrationType>>("registration",
                arguments: new QueryArguments(new List<QueryArgument>
                {
                    new QueryArgument<IdGraphType> { Name = "registrationId" },
                    new QueryArgument<StringGraphType> {  Name = "name" },
                    new QueryArgument<DateGraphType> { Name = "registrationDate" },
                    new QueryArgument<StringGraphType> { Name = "email" },
                    new QueryArgument<StringGraphType> { Name = "mobileNo" },
                    new QueryArgument<StatusType> { Name = "status" }
                }),
                resolve: context =>
                {
                    var query = _registrations;

                    var reservationId = context.GetArgument<int?>("registrationId");
                    if (reservationId.HasValue)
                    {
                        return _registrations.Where(r => r.RegistrationId == reservationId.Value);
                    }

                    var name = context.GetArgument<string>("name");
                    if (!string.IsNullOrEmpty(name))
                    {
                        return _registrations
                            .Where(r => r.Name == name);
                    }

                    var registrationDate = context.GetArgument<DateTime?>("registrationDate");
                    if (registrationDate.HasValue)
                    {
                        return _registrations
                            .Where(r => r.RegistrationDate >= registrationDate.Value.Date);
                    }

                    var email = context.GetArgument<string>("email");
                    if (!string.IsNullOrEmpty(email))
                    {
                        return _registrations
                            .Where(r => r.Email == email);
                    }

                    var mobileNo = context.GetArgument<string>("mobileNo");
                    if (!string.IsNullOrEmpty(mobileNo))
                    {
                        return _registrations.Where(r => r.MobileNo == mobileNo);
                    }

                    var status = context.GetArgument<Status?>("status");
                    if (status.HasValue)
                    {
                        return _registrations.Where(r => r.Status == status.Value);
                    }

                    return query.ToList();
                }
            );
        }
    }
}