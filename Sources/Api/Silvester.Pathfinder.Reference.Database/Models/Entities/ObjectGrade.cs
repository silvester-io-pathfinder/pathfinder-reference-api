using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ObjectGrade : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<PreciousMaterialArmorVariant> ArmorVariants { get; set; } = new List<PreciousMaterialArmorVariant>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ObjectGradeConfigurator : EntityConfigurator<ObjectGrade>
	{
		public ObjectGradeConfigurator()
		{
			ConfigureEntitySearch<ObjectGrade>(e => new {e.Name});
		}
	}
}
 