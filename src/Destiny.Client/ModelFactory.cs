using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Destiny.Client.Models;

namespace Destiny.Client
{
    public class ModelFactory
    {
        public static List<FeedItem> DeserializeFeed(string xmlString)
        {
            XDocument doc = XDocument.Parse(xmlString);
            var feedItems = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                            select new FeedItem
                            {
                                Description = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                Link = item.Elements().First(i => i.Name.LocalName == "link").Value,
                                PublishDate = item.Elements().First(i => i.Name.LocalName == "pubDate").Value,
                                Title = item.Elements().First(i => i.Name.LocalName == "title").Value
                            };
            var result = feedItems.ToList();
            return result;
        }

        private static DateTime ParseDate(string date)
        {
            DateTime result;
            if (DateTime.TryParse(date, out result))
                return result;
            else
                return DateTime.MinValue;
        }
    }
}
