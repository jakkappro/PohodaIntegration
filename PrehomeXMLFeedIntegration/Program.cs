using System.Net;
using Microsoft.Extensions.Configuration;
using PrehomeXMLFeedIntegration.Models.Prehome;

namespace PrehomeXMLFeedIntegration
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            #region Pohoda Variables
            
            var username = configuration.GetSection("Pohoda:mServer:username").Value ?? throw new ArgumentException("Missing Pohoda username.");
            var password = configuration.GetSection("Pohoda:mServer:password").Value ?? throw new ArgumentException("Missing Pohoda password.");

            const int pohodaPort = 5336;
            var pohodaHost = "http://127.0.0.1:" + pohodaPort;
            var pohodamServerName = configuration.GetSection("Pohoda:mServer:serverName").Value ?? throw new ArgumentException("Missing Pohoda server name.");
            const string pathToPohodamServer = "\"C:\\Program Files (x86)\\STORMWARE\\POHODA SK E1\"";
            const short amountOfmServerRetries = 3;
            const short delayBetweenRetries = 1000;
            
            #endregion

            #region PrehomeVariables

            var xmlFeedBaseAddress = configuration.GetSection("feedBaseAddress").Value ?? throw new ArgumentException("Missing feed address");
            
            
            #endregion
            
            using var httpClient = new HttpClient { BaseAddress = new Uri(xmlFeedBaseAddress) };
            using var response = await httpClient.GetAsync("");
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine($"Error: {response.StatusCode}, couldn't get xml feed");
            }

            var shop = PrehomeModel.ParseShopFromXML(await response.Content.ReadAsStringAsync());

            var mServer = new MServerStarter(pohodamServerName, pathToPohodamServer, pohodaHost, username, password, delayBetweenRetries, amountOfmServerRetries);
        }
    }
}