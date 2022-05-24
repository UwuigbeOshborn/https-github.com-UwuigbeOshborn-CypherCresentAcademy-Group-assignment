using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Subject
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Teacher> Teachers { get; set; }

    }
    public class SubjectMap : ClassMap<Subject>
    {
        public SubjectMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasManyToMany(x => x.Teachers);
        }
    }
}
