using System.Diagnostics;
using System.Net;
using System.Xml;

namespace PohodaIntegration.Pohoda
{
    internal class MServerStarter : IServerStarter
    {
        #region Variables
        private readonly string serverName;
        private readonly string pathToServer;
        private readonly string serverUrl;
        private readonly string username;
        private readonly string password;
        private readonly short retryDelay;
        private short amountOfRetries;
        #endregion

        #region Constructor
        public MServerStarter(string serverName, string pathToServer, string serverUrl, string username, string password, short retryDelay, short amountOfRetries)
        {
            this.serverName = serverName;
            this.pathToServer = pathToServer;
            this.serverUrl = serverUrl;
            this.username = username;
            this.password = password;
            this.retryDelay = retryDelay;
            this.amountOfRetries = amountOfRetries;
        }
        #endregion

        public void StartServer()
        {
            // IDEA: maybe add check if connection is available in case the server is still running

            var mServerStartComand = $"cd \"{pathToServer}\" & pohoda.exe /http start {serverName}";

            CreateCommand(mServerStartComand);
        }

        public async Task<bool> IsConnectionAvailable()
        {
            using var httpClient = new HttpClient { BaseAddress = new Uri(serverUrl) };
            httpClient.DefaultRequestHeaders.Add("STW-Authorization", CreateAuthHeader());
            httpClient.DefaultRequestHeaders.Add("Accept", "text/xml");

            var responseCode = HttpStatusCode.BadRequest;

            while (responseCode != HttpStatusCode.OK && amountOfRetries >= 0)
            {
                amountOfRetries--;

                try
                {
                    using var response = await httpClient.GetAsync("/status");
                    responseCode = response.StatusCode;
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        Console.WriteLine("Error: Couldn't connect to mServer \nResponseCode" + response.StatusCode);
                        continue;
                    }

                    var xmlDoc = new XmlDocument();
                    var responseString = await response.Content.ReadAsStringAsync();
                    xmlDoc.LoadXml(responseString);
                    var actualServerName = xmlDoc.GetElementsByTagName("name")[0].InnerText;

                    if (!actualServerName.Equals(serverName))
                    {
                        return false;
                    }

                    Console.WriteLine("mServer is running on " + serverName);
                    return true;

                }
                catch (HttpRequestException)
                {
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Couldn't connect to server.");
                    return false;
                }

                await Task.Delay(retryDelay);
            }

            Console.WriteLine("Couldn't connect to the server");

            return false;
        }

        public void StopServer()
        {
            var mServerStopComand = $"cd \"{pathToServer}\" & pohoda.exe /http stop {serverName}";
            CreateCommand(mServerStopComand);
        }

        private void CreateCommand(string command)
        {
            var cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = false;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

        private string CreateAuthHeader()
        {
            return "Basic " + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{username}:{password}"));
        }
    }
}
