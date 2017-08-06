using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace dailyhelper
{
    static class PrepareInformations
    {
        public static BitmapImage getWeather()
        {
            var html = @"http://lodz.infometeo.pl/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            string hrefWeather = htmlDoc.GetElementbyId("icm60h-meteogram").GetAttributeValue("src", "");
            hrefWeather = hrefWeather.Replace("&amp;", "&");

            BitmapImage weatherValue = new BitmapImage();
            weatherValue.BeginInit();
            weatherValue.UriSource = new Uri(hrefWeather);
            weatherValue.EndInit();
            return weatherValue;
        }
    }
}
