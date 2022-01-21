using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Creature : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;
        public int Level { get; set; }

        public string? PerceptionAddendum { get; set; }
        public string? FortitudeAddendum { get; set; }
        public string? ReflexAddendum { get; set; }
        public string? WillAddendum { get; set; }

        public int PerceptionModifier { get; set; }
        public int FortitudeModifier { get; set; }
        public int ReflexModifier { get; set; }
        public int WillModifier { get; set; }
        
        public int ArmorClass { get; set; }
        public int HitPoints { get; set; }
        public string? Resistances { get; set; }
        public string? WalkingSpeed { get; set; } = default!;
        public string? FlyingSpeed { get; set; } = default!;
        public string? BurrowingSpeed { get; set; } = default!;

        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int ConstitutionModifier { get; set; }
        public int IntelligenceModifier { get; set; }
        public int WisdomModifier { get; set; }
        public int CharismaModifier { get; set; }

        public string? LanguageAddendum { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? AlignmentId { get; set; }
        public Alignment? Alignment { get; set; }

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid SizeId { get; set; }
        public AncestrySize Size { get; set; } = default!;

        public Guid? AncestryId { get; set;}
        public Ancestry? Ancestry { get; set; } 

        public Guid? RecallKnowledgeId { get; set; }
        public CreatureRecallKnowledge? RecallKnowledge { get; set; } 

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<Immunity> Immunities { get; set; } = new List<Immunity>();
        public ICollection<Language> Languages { get; set; } = new List<Language>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        public ICollection<CreatureSense> Abilities { get; set; } = new List<CreatureSense>();
        public ICollection<CreatureSkill> Skills { get; set; } = new List<CreatureSkill>();
        public ICollection<Spell> SummonedBy { get; set; } = new List<Spell>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class CreatureFlavor : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
    }

    public class CreatureRecallKnowledge : BaseEntity
    {
        public int DifficultyCheck { get; set; }

        public Guid CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }

    public class CreatureSense : BaseEntity
    {
        public string? Addendum { get; set; }
        public string? Variant { get; set; }

        public Guid CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;

        public Guid SenseId { get; set; }
        public Sense Sense  { get; set; } = default!;
    }

    public class CreatureSkill : BaseEntity
    {
        public int Modifier { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid CreatureId { get; set; }
        public Creature Creature { get; set; } = default!;
    }

    public class CreatureConfigurator : EntityConfigurator<Creature>
	{
		public CreatureConfigurator()
		{
			ConfigureEntitySearch<Creature>(e => new {e.Name});
        }

        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<Creature>()
                .HasOne(e => e.RecallKnowledge)
                .WithOne(e => e!.Creature)
                .HasForeignKey<Creature>(e => e.RecallKnowledgeId);
        }
    }
}
