using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using TableTennisShop.App.Abstract;
using TableTennisShop.App.Concrete;
using TableTennisShop.Domain.Common;
using TableTennisShop.Domain.Entity;

namespace TableTennisShop.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get; set; }

        public BaseService()
        {
            Items = new List<T>();
        }
        public int AddItem(T item)
        {
            Items.Add(item);
            return item.Id;
        }
        public T GetItemById(int id)   // Co tu sie dzieje?
        {
            if (Items.Any())
            {
                var tempItem = Items.FirstOrDefault(p => p.Id == id);
                return tempItem;
            }
            return null;
        }
        public List<T> GetAllItems()
        {
            return Items;
        }

        public void RemoveItem(T item)
        {
            foreach (var it in Items)
            {
                if (it.Id == item.Id)
                {
                    item = it;
                }
                Items.Remove(item);
            }
        }
        public int UpdateItem(T item)
        {
            foreach (var it in Items)
            {
                if (it.Id == item.Id)
                {
                    item = it;
                }
            }
            return item.Id;
        }
        public int GetLastId()
        {
            int lastId;
            if (Items.Any())
            {
                lastId = Items.OrderBy(p => p.Id).LastOrDefault().Id;
            }
            else
            {
                lastId = 0;
            }
            return lastId;
        }
        public void SaveXml(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            TextWriter writer = new StreamWriter(path);
            xmlSerializer.Serialize(writer, Items);
            
        }
        public IEnumerable<T> ReadXml (string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            if (!File.Exists(path))
            {
                return new List<T>();
            }
            var xmlRead = File.ReadAllText(path);
            var stringReader = new StringReader(xmlRead);
            var items = (List<T>)xmlSerializer.Deserialize(stringReader);
            return items;
        }
    }
}
