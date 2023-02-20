using System;
using System.Collections;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public interface IDbService
    {
        void Save(Climate climate);
        IEnumerable<Climate> GetAll();
        void Delete(Climate climate);
    }
}
