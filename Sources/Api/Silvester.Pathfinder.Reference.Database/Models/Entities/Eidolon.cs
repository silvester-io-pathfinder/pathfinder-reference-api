using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Eidolon : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;
        public string SuggestedAttacks { get; set; } = default!;
        public int Speed { get; set; }

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public ICollection<Alignment> RequiredAlignments { get; set; } = new List<Alignment>();

        public ICollection<EidolonVariant> Variants { get; set; } = new List<EidolonVariant>();

        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

        public ICollection<Sense> Senses { get; set; } = new List<Sense>();

        public ICollection<EidolonAbility> Abilities { get; set; } = new List<EidolonAbility>();

        public ICollection<EidolonHomePlane> HomePlanes { get; set; } = new List<EidolonHomePlane>();

        public ICollection<AncestrySize> Sizes { get; set; } = new List<AncestrySize>();

        public Guid EffectId { get; set; }
        public BooleanEffect Effect { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;
        
        public Guid MagicTraditionId { get; set; }
        public MagicTradition MagicTradition { get; set; } = default!;

        public Guid LanguageId{ get; set; }
        public Language Language { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class EidolonVariant : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid EidolonId { get; set; }
        public Eidolon Eidolon { get; set; } = default!;

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int ArmorClass { get; set; }
        public int DexterityCap { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class EidolonAbility : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public int Level { get; set; }

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public Guid EidolonId { get; set; }
        public Eidolon Eidolon { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class EidolonHomePlane : BaseEntity
    {
        public Guid PlaneId { get; set; }
        public Plane Plane { get; set; } = default!;

        public Guid EidolonId { get; set; }
        public Eidolon Eidolon { get; set; } = default!;

        public Guid? PrerequisiteId { get; set; }
        public BooleanPrerequisite? Prerequisite { get; set; }
    }

    public class EidolonSearchConfigurator : SearchableEntityConfigurator<Eidolon>
    {
        public override Expression<Func<Eidolon, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }

    public class EidolonAbilitySearchConfigurator : SearchableEntityConfigurator<EidolonAbility>
    {
        public override Expression<Func<EidolonAbility, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }

    public class EidolonVariantSearchConfigurator : SearchableEntityConfigurator<EidolonVariant>
    {
        public override Expression<Func<EidolonVariant, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
