using System.Collections.Generic;

namespace RestaurantOH.Application.Interface
{
    public interface IBaseAppService<XEntity> where XEntity : class
    {
        XEntity Add(XEntity obj);
        XEntity Edit(XEntity obj);
        int Delete(int id);
        XEntity GetById(int id);
        IEnumerable<XEntity> GetAll();
    }
}