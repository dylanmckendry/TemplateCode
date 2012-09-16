using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateCode.Repository;

namespace TemplateCode.Business
{
    public class PersonBusiness : IPersonBusiness
    {
        private IUnitOfWork unitOfWork;

        public PersonBusiness(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
