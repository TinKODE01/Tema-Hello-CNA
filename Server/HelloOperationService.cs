using Generated;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class HelloOperationService : Generated.HelloResponse.HelloResponseBase
    {
        public override Task<OperationResponse> SayHello(Generated.HelloRequest request, ServerCallContext context)
        {
            System.Console.WriteLine("Hello, " + request.Name + "!");
            var result = "";
            return Task.FromResult(new OperationResponse() { Message = result });
        }
    }
}
