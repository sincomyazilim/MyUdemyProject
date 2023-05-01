using System.Collections.Generic;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        void BInsert(T t);
        void BDelete(T t);
        void BUpdate(T t);
        List<T> BGetList();
        T BGetById(int id);
    }
}
