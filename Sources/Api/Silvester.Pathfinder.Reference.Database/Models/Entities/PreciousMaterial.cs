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

        public ICollection<PreciousMaterialVariant> Variants { get; set; } = new List<PreciousMaterialVariant>();

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
     
        public ICollection<PreciousMaterialItem> Items { get; set; } = new List<PreciousMaterialItem>();

        public Guid? WeaponId { get; set; }
        public PreciousMaterialWeapon? Weapon { get; set; } 

        public Guid? ArmorId { get; set; }
        public PreciousMaterialArmor? Armor { get; set; } 

        public Guid? ShieldId { get; set; }
        public PreciousMaterialShield? Shield { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PreciousMaterialVariant : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? NameAddendum { get; set; }

        public int Price { get; set; }

        public int ItemLevel { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid MaterialId { get; set; }
        public PreciousMaterial Material { get; set; } = default!;
    }

    public class PreciousMaterialItem : BaseEntity
    {
        public int Hardness { get; set; }
        public int HitPoints { get; set; }
        public int BrokenThreshold { get; set; }

        public Guid GradeId { get; set; }
        public ItemGrade Grade { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public PreciousMaterialItemCategory Category { get; set; } = default!;

        public Guid MaterialId { get; set; }
        public PreciousMaterial Material { get; set; } = default!;
    }

    public class PreciousMaterialItemCategory : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<PreciousMaterialItem> Items { get; set; } = new List<PreciousMaterialItem>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PreciousMaterialItemCategorySearchConfigurator : SearchableEntityConfigurator<PreciousMaterialItemCategory>
    {
        public override Expression<Func<PreciousMaterialItemCategory, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }

    public class PreciousMaterialConfigurator : EntityConfigurator<PreciousMaterial>
    {
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

    public class PreciousMaterialSearchConfigurator : SearchableEntityConfigurator<PreciousMaterial>
    {
        public override Expression<Func<PreciousMaterial, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
 