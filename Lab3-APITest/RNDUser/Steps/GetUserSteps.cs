using Lab3.RNDUser.Steps;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using TechTalk.SpecFlow;

namespace Lab3.RNDUser.Steps
{
	[Binding]
	public class GetUserSteps : BaseRNDUserSteps
	{
		private RestRequest request;
		private RestResponse response;
		[Given("request to get user")]
		public void GivenRequestToGetUser()
		{
			request = new RestRequest("?results", Method.Get);
			request.AddHeaders(new Dictionary<string, string> {
				{ "Accept", "application/json" },
				{ "Content-Type", "application/json" }
			});
		}
		[When("send request to get user")]
		public void WhenSendRequestToGetQuote()
		{
			response = client.Execute(request);
		}
		[Then("successful response with user")]
		public void ThenResponseIsSuccess()
		{
			Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
		}
	}
}