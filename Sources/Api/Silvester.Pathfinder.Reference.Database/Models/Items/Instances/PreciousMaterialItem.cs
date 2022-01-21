

using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class PreciousMaterialItem : BaseItem
    {

    }

    public class PreciousMaterialItemVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Level { get; set; }
        public int Price { get; set; }
        public string Usage { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PreciousMaterialGrade : BaseEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }
    }

    public class PreciousMaterialItemVariantConfigurator : EntityConfigurator<PreciousMaterialItemVariant>
	{
		public PreciousMaterialItemVariantConfigurator()
		{
			ConfigureEntitySearch<PreciousMaterialItemVariant>(e => new {e.Name, e.Usage});
		}
	}
}
