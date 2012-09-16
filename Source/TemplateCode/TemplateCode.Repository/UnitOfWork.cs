using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateCode.Model;

namespace TemplateCode.Repository
{
    class UnitOfWork : IUnitOfWork
    {
        private GenericRepository<Person> personRepository;

        private TemplateCodeContext context;

        private bool disposed = false;


        // should i DI this in??
        public UnitOfWork()
        {
            context = new TemplateCodeContext();
        }

        public GenericRepository<Person> PersonRepository
        {
            get
            {
                if (personRepository == null)
                {
                    personRepository = new GenericRepository<Person>(context);
                }
                return personRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }


        

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
