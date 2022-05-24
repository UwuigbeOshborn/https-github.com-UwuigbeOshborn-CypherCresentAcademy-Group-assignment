using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Teacher
    {
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual School School { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual List<Subject> Subjects { get; set; }

    }
    public class TeacherMap : ClassMap<Teacher>
    {
        public TeacherMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            References(x => x.School).Cascade.All();
            References(x => x.ClassRoom);
            HasManyToMany(x => x.Subjects);
        }
    }
}
