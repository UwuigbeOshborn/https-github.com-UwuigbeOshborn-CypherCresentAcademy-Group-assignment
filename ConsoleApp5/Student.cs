using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Student
    {
        //
        //
        // Properties
        public virtual int Id { get; set; }
        public virtual string FullName { get; set; }
        public virtual School School { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual List<Subject> Subjects { get; set; }
    }
    public class StudentMap: ClassMap<Student>
    {
        public StudentMap()
        {
            Id(x => x.Id);
            Map(x => x.FullName);
            HasOne(x => x.School).Cascade.All();
            HasOne(x => x.ClassRoom);
            HasMany(x => x.Subjects);
        }
    }
}

