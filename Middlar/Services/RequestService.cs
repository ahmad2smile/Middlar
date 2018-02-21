using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Middlar.Services
{
    public interface IRequestService
    {
        Task<string> PostRequest(string requestUrl, string requestPayload);
    }

    public class RequestService: IRequestService
    {
        private static readonly HttpClient Client = new HttpClient();


        public async Task<string> PostRequest(string requestUrl, string requestPayload)
        {
            try
            {

                var content = new StringContent(requestPayload, Encoding.UTF8, "application/json");
                           
                var response = await Client.PostAsync(requestUrl, content);

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            
        }
    }
}
