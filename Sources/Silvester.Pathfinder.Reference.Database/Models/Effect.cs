using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public abstract class Effect : BaseEntity
    {
        [NotMapped]
        public abstract string Description { get; }

        public bool IsOptional { get; set; }

        public Guid BindingId { get; set; }
        public BaseEffectBinding Binding { get; set; } = default!;

        public ICollection<EffectIncrement> Increments { get; set; } = new List<EffectIncrement>();
    }

    public abstract class BaseEffectBinding : BaseEntity
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
        public override string Description => $"You must make a choice between the following options.";

        public string? Restrictions { get; set; }

        public ICollection<Effect> Choices { get; set; } = new List<Effect>();
    }

    public class CombinedEffect : Effect
    {
        public override string Description => $"You gain all of the following options.";

        public string? Restrictions { get; set; }

        public ICollection<Effect> Entries { get; set; } = new List<Effect>();
    }

    public class FreeAbilityBoostEffect : Effect
    {
        public bool IsChosenByGameMaster { get; set; } = false;
        public override string Description => "Choose one free ability boost.";
        public string? Restrictions { get; set; }
    }

    public class RestrictedAbilityBoostEffect : Effect
    {
        public ICollection<StatEffectBinding> RequiredStats { get; set; } = default!;

        public override string Description => $"Choose one ability boost, confined to either {RequiredStats.Select(e => e.Stat.Name).JoinWithDifferentFinalSeparator(", ", " or ")}.";
    }

    public class RestrictedSkillEffect : Effect
    {
        public override string Description => $"You are {Proficiency.Name} in {Skill.Name}.";

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }

    public class HarrowEffect : Effect
    {
        public override string Description => $"Randomly determine two harrow suits tied to your character, each reflecting a specific ability score. You gain an ability boost in your aligned or misaligned ability score.";
    }

    public class LoseAirBreathingEffect : Effect
    {
        public override string Description => "You lose the ability to breathe air.";
    }

    public class ProphecyEffect : Effect
    {
        public override string Description => "You partake an active role in a prophecy.";
    }

    public class CurseEffect : Effect
    {
        public override string Description => "You are cursed. You and the GM should determine the full effects of the curse, though you've staved most of them off for now. The GM determines the curse's lingering manifestations on you, which usually include at least a constant or very frequent thematic effect and occasional more dangerous effects.";
    }

    public class InfluenceEffect : Effect
    {
        public override string Description => "You can influence commoners in your family's territory, as well as nobility anywhere. If you later gain the Connections skill feat, you automatically have common and noble connections within any community in your royal family's territory and have noble connections in large communities outside your territory.";
    }

    public class FreeSkillEffect : Effect
    {
        public override string Description => $"You are {Proficiency.Name} in a Skill of your choosing.";

        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public class HeritageEffect : Effect
    {
        public override string Description => $"You gain the {Heritage.Name} heritage.";

        public Guid HeritageId { get; set; }
        public Heritage Heritage { get; set; } = default!;
    }

    public class HeritageRarityEffect : Effect
    {
        public override string Description => $"You a {Rarity.Name} Heritage of your choosing..";

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;
    }

    public class FeatEffect : Effect
    {
        public override string Description => $"You gain the {Feat.Name} feat.";

        public string? Restrictions { get; set; }

        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }

    public class SenseEffect : Effect
    {
        public override string Description => $"You gain the {Sense.Name} sense.";

        public string? Range { get; set; }

        public Guid SenseId { get; set; }
        public Sense Sense { get; set; } = default!;
    }

    public class FreeSenseEffect : Effect
    {
        public override string Description => $"You gain a sense of you choosing.";

        public string? Range { get; set; }
    }

    public class LoreEffect : Effect
    {
        public override string Description => $"You are {Proficiency.Name} in {Lore.Name}.";

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreId { get; set; }
        public Lore Lore { get; set; } = default!;
    }

    public class FreeLoreEffect : Effect
    {
        public override string Description => $"You are {Proficiency.Name} in a Lore skill of your choice.";

        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public class LoreCategoryEffect : Effect
    {
        public override string Description => $"You are {Proficiency.Name} in a {LoreCategory.Description} ({LoreCategory.Examples}).";

        public string? Restrictions { get; set; }

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;

        public Guid LoreCategoryId { get; set; }
        public LoreCategory LoreCategory { get; set; } = default!;
    }

    public class TraitEffect : Effect
    {
        public override string Description => $"You gain the {Trait.Name} trait.";

        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }

    public class DamageResistanceEffect : Effect
    {
        public override string Description => $"You gain resistance to {DamageType.Name} damage equal to half your level (minimum 1).";

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;
    }

    public class AbilityEffect : Effect
    {
        public override string Description => $"You gain the {Ability.Name} ability.";

        public string? Range { get; set; }

        public Guid AbilityId { get; set; }
        public Ability Ability { get; set; } = default!;
    }
}
