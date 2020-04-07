﻿namespace OfficeService.Repository.Interfaces
{
    public interface ICreate<TEntity>
       where TEntity : class
    {
       TEntity Create(TEntity entity);
    }
}
