using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class School
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Student> Students { get; set; }
    }
    public class SchoolMap : ClassMap<School>
    {
        public SchoolMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.Teachers);
            HasMany(x => x.Students);
        }
    }
}
