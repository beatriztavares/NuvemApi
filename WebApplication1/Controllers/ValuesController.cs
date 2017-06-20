using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        //static CloudQueue cloudQueue;

        /*public void Connect()
        {
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=nuvempuc;AccountKey=5Xl8yKJmsI0Ud0+GiZEqhydILreQIXxOLJqhcrl81xp7PLIpQJK836/cb2DfTmPREDkkdxjNw9HJeuwFCDcF6Q==;EndpointSuffix=core.windows.net";

            CloudStorageAccount cloudStorageAccount;

            if (!CloudStorageAccount.TryParse(connectionString, out cloudStorageAccount))
            {
                Console.WriteLine("Expected connection string 'Azure Storage Account Demo Primary' to be a valid Azure Storage Connection String.");
            }

            var cloudQueueClient = cloudStorageAccount.CreateCloudQueueClient();
            cloudQueue = cloudQueueClient.GetQueueReference("queue1");

            // Note: Usually this statement can be executed once during application startup or maybe even never in the application.
            //       A queue in Azure Storage is often considered a persistent item which exists over a long time.
            //       Every time .CreateIfNotExists() is executed a storage transaction and a bit of latency for the call occurs.
            //cloudQueue.CreateIfNotExists();
        }

        public void SendMessage(string MessageText)
        {
            var message = new CloudQueueMessage(MessageText);

            cloudQueue.AddMessage(message);
        }
        */

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            //Connect();
            //SendMessage(value);
            return "Post done!";
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
