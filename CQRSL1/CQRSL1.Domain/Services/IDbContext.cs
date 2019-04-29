﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CQRSL1.Domain
{
    public interface IDbContext
    {
        void Add<T>(T element) where T : Aggregate;

        IQueryable<Teacher> Teachers(bool trackChanges = false);
        //IQueryable<Department> Departments(bool trackChanges = false);

        int SaveChanges();
    }
}
