using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class RuneMagic : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid InitialRuneSpellId { get; set; }
        public Spell InitialRuneSpell { get; set; } = default!;

        public Guid AdvancedRuneSpellId { get; set; }
        public Spell AdvancedRuneSpell { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BooleanEffect Effect { get; set; } = default!;

        public Guid MagicSchoolId{ get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;

        public ICollection<RuneMagicSchoolBinding> ProhibitedSchools { get; set; } = new List<RuneMagicSchoolBinding>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class RuneMagicSchoolBinding : BaseEntity
    {
        public Guid MagicSchoolId { get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;

        public Guid RuneMagicId { get; set; }
        public RuneMagic RuneMagic { get; set; } = default!;
    }

    public class RuneMagicConfigurator : EntityConfigurator<RuneMagic>
	{
		public RuneMagicConfigurator()
		{
			ConfigureEntitySearch<RuneMagic>(e => new {e.Name, e.Description});
        }

        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<RuneMagic>()
                .HasMany(e => e.ProhibitedSchools)
                .WithOne(e => e.RuneMagic)
                .HasForeignKey(e => e.RuneMagicId);

            builder
                .Entity<RuneMagic>()
                .HasOne(e => e.MagicSchool)
                .WithOne(e => e!.RuneMagicSchool!)
                .HasForeignKey<RuneMagic>(e => e!.MagicSchoolId);
        }
    }
}
