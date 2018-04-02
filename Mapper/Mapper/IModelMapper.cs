using System;

namespace Mapper
{
    public interface IModelMapper<TDto, TEntity>
    {
        TDto DtoFrom(TEntity domainEntity);

        
        TEntity EntityFrom(TDto dto);
    }
}
