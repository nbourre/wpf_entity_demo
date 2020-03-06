using System.Collections.Generic;

namespace Demo.Business
{
    public interface IDataService<T>
    {
        public IEnumerable<T> GetAll();

    }
}
