using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class ClassRoom
    {
        //
        //
        // Properties
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual School School { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual List<Student> Students { get; set; }

    }
    public class ClassRoomMap : ClassMap<ClassRoom>
    {
        public ClassRoomMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.School);
            HasOne(x => x.Teacher);
            HasMany(x => x.Students);
        }
    }
}
