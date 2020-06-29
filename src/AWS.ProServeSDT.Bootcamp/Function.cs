using System.Collections.Generic;
using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.SystemTextJson;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]

namespace AWS.ProServeSDT.Bootcamp
{
    public class Functions
    {
        /// <summary>
        /// A Lambda function to respond to HTTP Get methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The API Gateway response.</returns>
        public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        {
            context.Logger.LogLine("Get Request\n");

            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int) HttpStatusCode.OK,
                Body = "Get Method Response",
                Headers = new Dictionary<string, string> {{"Content-Type", "text/plain"}}
            };

            return response;
        }

        /// <summary>
        /// A Lambda function to respond to HTTP Post methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The API Gateway response.</returns>
        public APIGatewayProxyResponse Post(APIGatewayProxyRequest request, ILambdaContext context)
        {
            context.Logger.LogLine("Post Request\n");

            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int) HttpStatusCode.OK,
                Body = "Post Method Response",
                Headers = new Dictionary<string, string> {{"Content-Type", "text/plain"}}
            };

            return response;
        }
    }
}