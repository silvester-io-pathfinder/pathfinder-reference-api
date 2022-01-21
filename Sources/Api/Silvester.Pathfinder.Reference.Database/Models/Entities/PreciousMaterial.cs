using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class PreciousMaterial : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<PreciousMaterialObjectInformation> ObjectInformations { get; set; } = new List<PreciousMaterialObjectInformation>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public Guid? WeaponId { get; set; }
        public PreciousMaterialWeapon? Weapon { get; set; } 

        public Guid? ArmorId { get; set; }
        public PreciousMaterialArmor? Armor { get; set; } 

        public Guid? ShieldId { get; set; }
        public PreciousMaterialShield? Shield { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PreciousMaterialObjectInformation : BaseEntity
    {
        public int Hardness { get; set; }
        public int HitPoints { get; set; }
        public int BrokenThreshold { get; set; }

        public Guid GradeId { get; set; }
        public ObjectGrade Grade { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public PreciousMaterialObjectCategory Category { get; set; } = default!;

        public Guid MaterialId { get; set; }
        public PreciousMaterial Material { get; set; } = default!;
    }

    public class PreciousMaterialObjectCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<PreciousMaterialObjectInformation> ObjectInformations { get; set; } = new List<PreciousMaterialObjectInformation>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PreciousMaterialObjectCategoryConfigurator : EntityConfigurator<PreciousMaterialObjectCategory>
	{
		public PreciousMaterialObjectCategoryConfigurator()
		{
			ConfigureEntitySearch<PreciousMaterialObjectCategory>(e => new {e.Name});
		}
	}

    public class PreciousMaterialConfigurator : EntityConfigurator<PreciousMaterial>
	{
		public PreciousMaterialConfigurator()
		{
			ConfigureEntitySearch<PreciousMaterial>(e => new {e.Name});
        }

        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<PreciousMaterial>()
                .HasOne(e => e.Weapon)
                .WithOne(e => e!.Material)
                .HasForeignKey<PreciousMaterial>(e => e.WeaponId);

            builder
                .Entity<PreciousMaterial>()
                .HasOne(e => e.Armor)
                .WithOne(e => e!.Material)
                .HasForeignKey<PreciousMaterial>(e => e.ArmorId);

            builder
                .Entity<PreciousMaterial>()
                .HasOne(e => e.Shield)
                .WithOne(e => e!.Material)
                .HasForeignKey<PreciousMaterial>(e => e.ShieldId);
        }
    }
}
 