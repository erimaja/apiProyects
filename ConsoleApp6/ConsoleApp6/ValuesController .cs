using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;

namespace ConsoleApp6
{
    public class ValuesController : ApiController
    {
        // GET api/values 
        public IEnumerable<string> Get()
        {
            // Create HttpCient and make a request to api/values 
             string clientAddress = "http://localhost:9000/api/values";
             HttpClient client = new HttpClient();
             var response = client.GetAsync(clientAddress ).Result;

            //PostAsync
            // Console.WriteLine(response);
            // Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            //return new string[] { response };

            string resultContent = response.Content.ReadAsStringAsync().Result;
            
            return new string[] { resultContent };
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
