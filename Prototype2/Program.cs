using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Prototype2
{
    class Program
    {
        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }


        public static async Task<string> WriteWebRequestSizeAsync(string url)
        {
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    await webRequest.GetResponseAsync();
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        await reader.ReadToEndAsync();
                    return FormatBytes(text.Length);
                }
            }
            catch (WebException)
            {
                // ...
            }
            catch (IOException)
            {

                // ...
            }
            catch (NotSupportedException)
            {
                // ...
            }
            return "";
        }

        static void Main(string[] args)
        {
            string url = "http://www.IntelliTect.com";
            WebInfoFactory webInfoFactory = new WebInfoFactory();
            WebInfo webInfo = webInfoFactory.CreateWebInfo(url);
            System.Threading.Thread.Sleep(2000);
            webInfo.Timestamp = DateTime.Now;
            Console.WriteLine(webInfo);
            WebInfo webInfo2 = webInfoFactory.CreateWebInfo(url);
            Console.WriteLine(webInfo2);
            Console.WriteLine(webInfo2 == webInfo);
            Console.WriteLine(webInfoFactory.CreateWebInfo("https://www.google.com"));
            // ...
        }
    }
}