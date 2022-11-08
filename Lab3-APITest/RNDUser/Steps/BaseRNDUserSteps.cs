using RestSharp;
using TechTalk.SpecFlow;

namespace Lab3.RNDUser.Steps
{
	[Binding]
	public class BaseRNDUserSteps
	{
		protected static RestClient client { get; set; }
		[BeforeFeature]
		public static void BeforeFeature()
		{
			client = new RestClient("https://randomuser.me/api/");
		}
	}
}