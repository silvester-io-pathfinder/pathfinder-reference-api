using NpgsqlTypes;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Deity : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public string Edicts { get; set; } = default!;
        public string Anathema { get; set; } = default!;
        public string? AreasOfConcern { get; set; }

        public Guid CategoryId { get; set; }
        public DeityCategory Category { get; set; } = default!;

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? FavoredMeleeWeaponId { get; set; }
        public MeleeWeapon? FavoredMeleeWeapon { get; set; }

        public Guid? FavoredRangedWeaponId { get; set; }
        public MeleeWeapon? FavoredRangedWeapon { get; set; }

        public Guid DevoteeEffectId { get; set; }
        public BooleanEffect DevoteeEffect { get;set;} = default!;

        public ICollection<Skill> DivineSkills { get; set; } = new List<Skill>();
        public ICollection<Stat> DivineStats { get; set; } = new List<Stat>();
        public ICollection<DivineFont> DivineFonts { get; set; } = new List<DivineFont>();
        public ICollection<Alignment> FollowerAlignments { get; set; } = new List<Alignment>();
        public ICollection<Domain> Domains { get; set; } = new List<Domain>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public Guid? DivineIntercessionId { get; set; }
        public DivineIntercession? DivineIntercession { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DivineIntercession : BaseEntity
    {
        public string Description { get; set; } = default!;

        public string MinorBoon { get; set; } = default!;
        public string ModerateBoon { get; set; } = default!;
        public string MajorBoon { get; set; } = default!;

        public string MinorCurse { get; set; } = default!;
        public string ModerateCurse { get; set; } = default!;
        public string MajorCurse { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;
    }
}
