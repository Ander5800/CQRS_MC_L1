using System;
using System.Collections.Generic;

namespace CQRSL1.Domain
{
    public interface IServiceInjector
    {
        object Get(Type type);
        T Get<T>();

        List<Type> GetTypes();
    }
}
