﻿using PMSEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSInterface
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        List<TEntity> GetAll();
        TEntity Get(long id);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
       
    }
}
