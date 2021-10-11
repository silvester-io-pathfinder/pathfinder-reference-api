using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Effect : BaseEntity
    {
        public bool IsOptional { get; set; }

        public Guid BindingId { get; set; }
        public BaseEffectBinding Binding { get; set; } = default!;

        public ICollection<EffectIncrement> Increments { get; set; } = new List<EffectIncrement>();
    }

    public class BaseEffectBinding : BaseEntity
    {
        public Guid EffectId { get; set; }
        public Effect Effect { get; set; } = default!;
    }

    public class BaseEffectBindingConfigurator : EntityConfigurator<BaseEffectBinding>
    {
        public override void Configure(ModelBuilder builder)
        {
            base.Configure(builder);

            builder
                .Entity<BaseEffectBinding>()
                .HasOne(e => e.Effect)
                .WithOne(e => e.Binding)
                .HasForeignKey<BaseEffectBinding>(e => e.EffectId);
        }
    }

    public class BackgroundEffectBinding : BaseEffectBinding
    {
        public Guid BackgroundId { get; set; }
        public Background Background { get; set; } = default!;
    }

    public class ChoiceEffectBinding : BaseEffectBinding
    {
        public Guid ChoiceId { get; set; }
        public ChoiceEffect Choice { get; set; } = default!;
    }

    public class CombinedEffectBinding : BaseEffectBinding
    {
        public Guid CombinedId { get; set; }
        public CombinedEffect Combined { get; set; } = default!;
    }

    public class StatEffectBinding : BaseEffectBinding
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }

    public class FeatEffectBinding : BaseEffectBinding
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }

    public class ChoiceEffect : Effect
    {
        public string? Restrictions { get; set; }

        public ICollection<Effect> Choices { get; set; } = new List<Effect>();

        public ChoiceEffect()
        {

        }
    }

    public class CombinedEffect : Effect
    {
        public string? Restrictions { get; set; }

        public ICollection<Effect> Entries { get; set; } = new List<Effect>();
    }

    public class FreeAbilityBoostEffect : Effect
    {
        public bool IsChosenByGameMaster { get; set; } = false;
        public string? Restrictions { get; set; }
    }

    public class RestrictedAbilityBoostEffect : Effect
    {
        public ICollection<StatEffectBinding> RequiredStats { get; set; } = default!;
    }

    public class RestrictedSkillEffect : Effect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }

    public class HarrowEffect : Effect
    {

    }

    public class LoseAirBreathingEffect : Effect
    {

    }

    public class ProphecyEffect : Effect
    {

    }

    public class CurseEffect : Effect
    {

    }

    public class InfluenceEffect : Effect
    {

    }

    public class FreeSkillEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public class HeritageEffect : Effect
    {
        public Guid HeritageId { get; set; }
        public Heritage Heritage { get; set; } = default!;
    }

    public class HeritageRarityEffect : Effect
    {
        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;
    }

    public class FeatEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }

    public class SenseEffect : Effect
    {
        public string? Range { get; set; }

        public Guid SenseId { get; set; }
        public Sense Sense { get; set; } = default!;
    }

    public class FreeSenseEffect : Effect
    {
        public string? Range { get; set; }
    }

    public class LoreEffect : Effect
    {
        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreId { get; set; }
        public Lore Lore { get; set; } = default!;
    }

    public class FreeLoreEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public class LoreCategoryEffect : Effect
    {
        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreCategoryId { get; set; }
        public LoreCategory LoreCategory { get; set; } = default!;
    }

    public class TraitEffect : Effect
    {
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }

    public class DamageResistanceEffect : Effect
    {
        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public class AbilityEffect : Effect
    {
        public string? Range { get; set; }

        public Guid AbilityId { get; set; }
        public Ability Ability { get; set; } = default!;
    }
}
