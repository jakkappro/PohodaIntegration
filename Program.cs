using System;
using System.Net.Http;

var baseAddress = new Uri("https://private-anon-935b1c06cc-expandopublicapi.apiary-mock.com/api/v2/");
var access_token = "11w1QgSM7YR4tHyr4BR0BV";
var days = 1;


using (var httpClient = new HttpClient{ BaseAddress = baseAddress })
{

  using(var response = await httpClient.GetAsync("orderfeed?access_token=" + access_token + "&days=" + days))
  {
    var content = await response.Content.ReadAsStringAsync();
    Console.WriteLine(content);
  }
}

