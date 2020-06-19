using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace InstagramCommentScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var postCount = 19;
            ChromeDriver driver = null;
            var chromeOptions = new ChromeOptions();

            Log("Post count " + postCount);

            // chromeOptions.AddArguments("headless");
            chromeOptions.AddArgument("no-sandbox");

            driver = new ChromeDriver(chromeOptions);

            chromeOptions.AddArgument(@"user-data-dri=C:\Users\Administrator\AppData\Local\Google\Chrome\User Data\Profile 1\");

            while (true)
            {
                try
                {


                    Log("Starting chrome");

                    Log("Moving to url");

                    driver.Url = "https://www.instagram.com/modlium";

                    Log("url loaded");

                    var result = driver.ExecuteScript("return document.body.innerHTML;").ToString();

                    Log("dom retrieval done");

                    var json = result.Split("window._sharedData = ")[1].Split(";</script>")[0];

                    Log(json);

                    Log("Split done");

                    var items = JsonConvert.DeserializeObject<ExploreModel>(json);

                    Log("Deserialize done");

                    var posts = items.entry_data.ProfilePage[0].graphql.user.edge_owner_to_timeline_media;

                    Log("posts done");

                    if (posts.count > postCount)
                    {
                        try
                        {
                            Log("post count done " + postCount + " __ " + posts.count);

                            postCount = posts.count;

                            var latest = posts.edges[0];

                            Log("latests done " + latest);

                            var code = latest.node.shortcode;

                            Log(code);
                        }
                        catch (Exception e)
                        {
                            Log("Error" + e.Message);
                        }
                    }

                    //driver.Quit();
                }
                catch (Exception e)
                {
                    Log(e.Message);
                    //driver.Quit();
                }

                Thread.Sleep(1000 * 25);
            }
        }

        public static void RandomNumber(int min, int max)
        {
            Random random = new Random();
            var sleepTime = random.Next(min, max);
            Thread.Sleep(sleepTime);
        }

        public static void Log(string msg)
        {
            Console.WriteLine(msg);
        }


        static IWebProxy GetProxy()
        {
            Console.WriteLine("To enable your free eval account and get CUSTOMER, "
                + "YOURZONE and YOURPASS, please contact sales@luminati.io");
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            var client = new WebClient();
            client.Proxy = new WebProxy("zproxy.lum-superproxy.io:22225");
            client.Proxy.Credentials = new NetworkCredential("lum-customer-hl_eb9f8420-zone-static-ip-181.214.179.208", "29gqn7d916xf");
            Console.WriteLine(client.DownloadString("http://lumtest.com/myip.json"));
            return client.Proxy;
        }
    }
}
