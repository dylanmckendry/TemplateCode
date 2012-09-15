using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TemplateCode.Model;

namespace TemplateCode.Repository
{
    public class TemplateCodeContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
