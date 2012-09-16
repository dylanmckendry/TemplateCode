using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateCode.Model;

namespace TemplateCode.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<Person> PersonRepository { get; }

        void Save();
    }
}
