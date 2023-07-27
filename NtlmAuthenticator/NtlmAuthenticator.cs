using System;
using System.Threading.Tasks;

namespace RestSharp.Authenticators.Ntlm 
{
	public class NtlmAuthenticator : IAuthenticator
	{
        public NtlmAuthenticator(string username, string password, string domain = "")
        {
            
        }
        public ValueTask Authenticate(RestClient client, RestRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
