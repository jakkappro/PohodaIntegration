using System.Diagnostics;
using System.Net;
using System.Xml;

namespace PohodaIntegration.Pohoda
{
    internal class MServerStarter
    {
        public MServerStarter()
        {

        }

        public async Task<bool> startAsync(string serverName, string pathToServer, string serverUrl, string username, string password, short retryDelay, short amountOfRetries)
        {
            var mServerStartComand = $"cd \"{pathToServer}\" & pohoda.exe /http start {serverName}";

            var cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = false;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(mServerStartComand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            return await testConnectionAsync(serverUrl, username, password, retryDelay, amountOfRetries, serverName);
        }

        private async Task<bool> testConnectionAsync(string serverUrl, string username, string password, short retryDelay, short amountOfmServerRetries, string serverName)
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri(serverUrl) })
            {
                httpClient.DefaultRequestHeaders.Add("STW-Authorization", createAuthHeader(username, password));
                httpClient.DefaultRequestHeaders.Add("Accept", "text/xml");

                var responseCode = HttpStatusCode.BadRequest;

                while (responseCode != HttpStatusCode.OK && amountOfmServerRetries >= 0)
                {
                    amountOfmServerRetries--;

                    try
                    {
                        using (var response = await httpClient.GetAsync("/status"))
                        {
                            responseCode = response.StatusCode;
                            if (response.StatusCode != HttpStatusCode.OK)
                            {
                                Console.WriteLine("Error: Couldn't connect to mServer \nResponseCode" + response.StatusCode);
                                continue;   
                            }

                            var xmlDoc = new XmlDocument();
                            var responseString = await response.Content.ReadAsStringAsync();
                            xmlDoc.LoadXml(responseString);
                            try
                            {
                                var actualServerName = xmlDoc.GetElementsByTagName("name")[0].InnerText;

                                if (!actualServerName.Equals(serverName))
                                {
                                    return false;
                                }

                                Console.WriteLine("mServer is running on " + serverName);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error: Couldn't get mServer name");
                                return false;
                            }
                        }
                    }
                    catch (System.Net.Http.HttpRequestException)
                    {
                    }

                    await Task.Delay(retryDelay);
                }

                Console.WriteLine("Couldn't connect to the server");

                return false;
            }
        }

        private string createAuthHeader(string username, string password)
        {
            return "Basic " + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{username}:{password}"));
        }
    }
}
