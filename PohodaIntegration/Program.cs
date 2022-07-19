using System.Xml.Serialization;
using Microsoft.Extensions.Configuration;
using PohodaIntegration;
using PohodaIntegration.Models.Orders.Pohoda;
using PohodaIntegration.Pohoda;

// TODO: abstract serializing and deserializing of xml files and strings


var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();

#region Variables
var baseAddress = new Uri(configuration.GetSection("Expando:mockServerBaseAdress").Value);
var access_token = configuration.GetSection("Expando:apiKey").Value;
var days = 1;

string username = configuration.GetSection("Pohoda:mServer:username").Value ?? throw new ArgumentException("Missing Pohoda username.");
string password = configuration.GetSection("Pohoda:mServer:password").Value ?? throw new ArgumentException("Missing Pohoda password.");

var pohodaPort = 5336;
var pohodaHost = "http://127.0.0.1:" + pohodaPort;
var pohodamServerName = "test";
var pathToPohodamServer = "\"C:\\Program Files (x86)\\STORMWARE\\POHODA SK E1\"";
short amountOfmServerRetries = 3;
short delayBetweenRetries = 1000;
#endregion

// xml parsing test
var aha = PohodaOrderModel.Deserialize("C:\\Users\\Kubino\\Downloads\\xmlData\\pure\\pohodaObjednavkaRequest.xml");

// start mServer
var mServer = new MServerStarter("test", pathToPohodamServer, pohodaHost, username, password, delayBetweenRetries, amountOfmServerRetries);
mServer.StartServer();

Console.WriteLine(await mServer.IsConnectionAvailable());

return;

// get orders from mServer

// get orders from Expando
//using (var httpClient = new HttpClient { BaseAddress = baseAddress })
//{
//    using (var response = await httpClient.GetAsync("orderfeed?access_token=" + access_token + "&days=" + days))
//    {
//        var content = await response.Content.ReadAsStringAsync();
//        Console.WriteLine(content);
//    }
//}
