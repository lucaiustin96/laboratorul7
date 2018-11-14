using System;
using System.Collections.Generic;
using Fii.DataLayer;

namespace Fii.BusinessLayer
{
    public interface ICityRepository
    {
        void Create(City city);
        IReadOnlyList<City> GetAll();
        City GetByld(Guid id);
    }
}