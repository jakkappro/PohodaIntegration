﻿using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net;

var baseAddress = new Uri("https://private-anon-935b1c06cc-expandopublicapi.apiary-mock.com/api/v2/");
var access_token = "11w1QgSM7YR4tHyr4BR0BV";
var days = 1;

var mServerAccess = "admin:acecom";
var pohodaPort = 5336;
var pohodaHost = "localhost:" + pohodaPort;
var pohodamServerName = "test";
var pathToPohodamServer = "\"C:\\Program Files (x86)\\STORMWARE\\POHODA SK E1\"";
var mServerStartCommand = $"cd {pathToPohodamServer} && pohoda.exe /http start {pohodamServerName}";
Console.WriteLine(mServerStartCommand);
var authHeader = "STW-Authorization: Basic " + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{mServerAccess}:"));
var mServerBaseAddress = new Uri(pohodaHost);


// start mServer
var cmd = new Process();
cmd.StartInfo.FileName = "cmd.exe";
cmd.StartInfo.RedirectStandardInput = true;
cmd.StartInfo.RedirectStandardOutput = true;
cmd.StartInfo.CreateNoWindow = true;
cmd.StartInfo.UseShellExecute = false;
cmd.Start();

cmd.StandardInput.WriteLine(mServerStartCommand);
cmd.StandardInput.Flush();
cmd.StandardInput.Close();
cmd.WaitForExit();

// test if mServer is running
using (var httpClient = new HttpClient{ BaseAddress = mServerBaseAddress }) 
{
  httpClient.DefaultRequestHeaders.Add("Authorization", authHeader);
  httpClient.DefaultRequestHeaders.Add("Accept", "text/xml");
  using (var response = await httpClient.GetAsync("/status")) 
  {
    var responseString = await response.Content.ReadAsStringAsync();
    Console.WriteLine(responseString);
    if (response.StatusCode != HttpStatusCode.OK) {
      Console.WriteLine("Error: Couldn't connect to mServer \nResponseCode" + response.StatusCode);
      return;
    }
  }
}

return;

// get orders from mServer

// get orders from Expando
using (var httpClient = new HttpClient{ BaseAddress = baseAddress })
{
  using(var response = await httpClient.GetAsync("orderfeed?access_token=" + access_token + "&days=" + days))
  {
    var content = await response.Content.ReadAsStringAsync();
    Console.WriteLine(content);
  }
}