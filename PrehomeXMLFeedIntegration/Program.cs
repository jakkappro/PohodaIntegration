using System.Net;
using Microsoft.Extensions.Configuration;
using PrehomeXMLFeedIntegration.Models.Prehome;
using PrehomeXMLFeedIntegration.Models.Pohoda;
using Serilog;


namespace PrehomeXMLFeedIntegration
{
    public class Program
    {
        public const decimal version = 2.0m;

        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                //.WriteTo.File()
                .CreateLogger();


            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            #region Pohoda Variables

            Log.Information("Loading data from appsettings.json");
            var username = "";
            var password = "";
            var pohodamServerName = "";
            try
            {
                username = configuration.GetSection("Pohoda:mServer:username").Value ??
                           throw new ArgumentException("Missing Pohoda username.");
                password = configuration.GetSection("Pohoda:mServer:password").Value ??
                           throw new ArgumentException("Missing Pohoda password.");
                pohodamServerName = configuration.GetSection("Pohoda:mServer:serverName").Value ??
                                    throw new ArgumentException("Missing Pohoda server name.");
            }
            catch (ArgumentException e)
            {
                Log.Error(e, "Error while loading data from appsettings.json");
            }

            const int pohodaPort = 5336;
            var pohodaHost = "http://127.0.0.1:" + pohodaPort;
            const string pathToPohodamServer = "\"C:\\Program Files (x86)\\STORMWARE\\POHODA SK E1\"";
            const short amountOfmServerRetries = 3;
            const short delayBetweenRetries = 1000;

            #endregion

            #region PrehomeVariables

            var xmlFeedBaseAddress = configuration.GetSection("feedBaseAddress").Value ??
                                     throw new ArgumentException("Missing feed address");

            #endregion

            Log.Information("Getting xml feed.");
            HttpResponseMessage response;
            try
            {
                using var httpClient = new HttpClient { BaseAddress = new Uri(xmlFeedBaseAddress) };
                response = await httpClient.GetAsync("");
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Log.Error($"Failed load xml feed. Response:{response.StatusCode}");
                    return;
                }
            }
            catch (Exception e)
            {
                Log.Error(e, $"Couldn't get xml feed. Address:{xmlFeedBaseAddress}");
                return;
            }

            Log.Information("Parsing xml feed");
            var shops = new PrehomeModel.SHOP();
            try
            {
                shops = PrehomeModel.ParseShopFromXML(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                Log.Error(e, "Couldn't parse shop items from xml feed.");
            }

            var dataPack = new PohodaCreateOrderModel.dataPack()
            {
                version = version,
                ico = 53870441,
                note = "Imported from xml",
                id = "zas001",
                application = "StwTest"
            };

            var items = new List<PohodaCreateOrderModel.dataPackDataPackItem>();

            using var client = new HttpClient();
            const string path = "C:\\dev\\customDev\\ecommerce\\PohodaIntegration\\pohoda\\obrazocky\\";

            foreach (var shopItem in shops.SHOPITEM)
            {
                Log.Information($"Creating item: {shopItem.PRODUCTNAME}");

                // Download image
                var pathToPicture = shopItem.IMGURL.Split('/').Last();
                try
                {
                    var fileBytes = await client.GetByteArrayAsync(new Uri(shopItem.IMGURL));
                    if (!File.Exists(path + pathToPicture))
                    {
                        await using var fs = File.Create(path + pathToPicture);
                        await fs.WriteAsync(fileBytes);
                        fs.Close();
                    }
                }
                catch (Exception e)
                {
                    Log.Error(e, $"Failed to download image for {shopItem.PRODUCTNAME}");
                }

                var dataPackItem = new PohodaCreateOrderModel.dataPackDataPackItem()
                {
                    version = version,
                    id = "ZAS001",
                    stock = new PohodaCreateOrderModel.stock()
                    {
                        version = version,
                        stockHeader = new PohodaCreateOrderModel.stockStockHeader
                        {
                            stockType = "card",
                            code = shopItem.ITEM_ID,
                            EAN = shopItem.EAN,
                            PLU = 0,
                            isSales = false,
                            isInternet = true,
                            isBatch = true,
                            purchasingRateVAT = "high",
                            sellingRateVAT = "high",
                            name = shopItem.PRODUCTNAME,
                            nameComplement = "ISO 9001",
                            unit = "ks",
                            storage = new PohodaCreateOrderModel.stockStockHeaderStorage()
                            {
                                ids = "GoNoow"
                            },
                            typePrice = new PohodaCreateOrderModel.stockStockHeaderTypePrice()
                            {
                                ids = "SK"
                            },
                            purchasingPrice = 0,
                            sellingPrice = shopItem.PRICE,
                            limitMin = 0,
                            limitMax = 1000,
                            mass = shopItem.WEIGHT,
                            supplier = new PohodaCreateOrderModel.stockStockHeaderSupplier()
                            {
                                id = 1
                            },
                            producer = shopItem.MANUFACTURER,
                            description = shopItem.DESCRIPTION,
                            pictures = new PohodaCreateOrderModel.stockStockHeaderPictures()
                            {
                                picture = new PohodaCreateOrderModel.stockStockHeaderPicturesPicture()
                                {
                                    @default = true,
                                    description = "obrazok produktu",
                                    filepath = pathToPicture
                                }
                            },
                            note = "Importovane z xml",
                            relatedLinks = new PohodaCreateOrderModel.stockStockHeaderRelatedLinks()
                            {
                                relatedLink = new PohodaCreateOrderModel.stockStockHeaderRelatedLinksRelatedLink
                                {
                                    addressURL = shopItem.URL,
                                    description = "odkaz na produkt",
                                    order = 1
                                }
                            },
                        }
                    }
                };
                Log.Information($"Created item {shopItem.PRODUCTNAME}");
                items.Add(dataPackItem);
            }

            dataPack.dataPackItem = items.ToArray();

            Console.WriteLine(PohodaCreateOrderModel.dataPack.Serialize(dataPack));
            Console.WriteLine();

            var mServer = new MServerStarter(pohodamServerName, pathToPohodamServer, pohodaHost, username, password,
                delayBetweenRetries, amountOfmServerRetries);

            await mServer.ModifyOrders(PohodaCreateOrderModel.dataPack.Serialize(dataPack));
        }
    }
}
