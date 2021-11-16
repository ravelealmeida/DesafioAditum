using AutoMapper;
using RestaurantOH.Application.Interface;
using RestaurantOH.Domain.Interface;
using System.Collections.Generic;

namespace RestaurantOH.Application.Service
{
    public class BaseAppService<XEntity, TEntity> : IBaseAppService<XEntity> where XEntity : class where TEntity : class
    {
        private readonly IBaseService<TEntity> _baseService;
        private readonly IMapper _mapper;

        public BaseAppService(IBaseService<TEntity> baseService, IMapper mapper)
        {
            _baseService = baseService;
            _mapper = mapper;
        }

        public XEntity Add(XEntity obj)
        {
            var entity = _mapper.Map<TEntity>(obj);
            return _mapper.Map<XEntity>(_baseService.Add(entity));
        }

        public int Delete(int id)
        {
            return _baseService.Delete(id);
        }

        public XEntity Edit(XEntity obj)
        {
            var entity = _mapper.Map<TEntity>(obj);
            return _mapper.Map<XEntity>(_baseService.Edit(entity));
        }

        public IEnumerable<XEntity> GetAll()
        {
            return _mapper.Map<IEnumerable<XEntity>>(_baseService.GetAll());
        }

        public XEntity GetById(int id)
        {
            return _mapper.Map<XEntity>(_baseService.GetById(id));
        }
    }
}
