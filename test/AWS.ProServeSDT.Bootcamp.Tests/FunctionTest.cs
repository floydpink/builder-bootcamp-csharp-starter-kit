using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using Xunit;

namespace AWS.ProServeSDT.Bootcamp.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestGetMethod()
        {
            TestLambdaContext context;
            APIGatewayProxyRequest request;
            APIGatewayProxyResponse response;

            var functions = new Functions();


            request = new APIGatewayProxyRequest();
            context = new TestLambdaContext();
            response = functions.Get(request, context);
            Assert.Equal(200, response.StatusCode);
            Assert.Equal("Get Method Response", response.Body);
        }

        [Fact]
        public void TestPostMethod()
        {
            TestLambdaContext context;
            APIGatewayProxyRequest request;
            APIGatewayProxyResponse response;

            var functions = new Functions();


            request = new APIGatewayProxyRequest();
            context = new TestLambdaContext();
            response = functions.Post(request, context);
            Assert.Equal(200, response.StatusCode);
            Assert.Equal("Post Method Response", response.Body);
        }
    }
}