using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTennisShop.App.Abstract;
using TableTennisShop.Domain.Common;

namespace TableTennisShop.App.Common
{
    public class BaseService<T> : IService<T> where T : BaseEntity
    {
        public List<T> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int AddItem(T item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(T item)
        {
            throw new NotImplementedException();
        }

        public int UpdateItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
