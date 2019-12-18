using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DS.SystemsCommunication.GraphQL.Queries;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DS.SystemsCommunication.GraphQL.Controllers
{
    [ApiController]
    [Route("graphql")]
    public class GraphQlController : ControllerBase
    {
        private readonly ILogger<GraphQlController> _logger;
        private readonly IDependencyResolver _dependecyResolver;

        public GraphQlController(ILogger<GraphQlController> logger, IDependencyResolver dependencyResolver)
        {
            _logger = logger;
            _dependecyResolver = dependencyResolver;

        }

        public async Task<IActionResult> Post([FromBody]GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();
            //var queryToExecute = query.Query;

            var schema = new Schema()
            {
                Query = new RegistrationQuery()
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
