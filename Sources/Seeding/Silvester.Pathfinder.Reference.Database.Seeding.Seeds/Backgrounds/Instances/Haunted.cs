using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Haunted : Template
    {
        public static readonly Guid ID = Guid.Parse("fbdfc179-3fb3-4af0-b9ab-31876b0e22d0");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Haunted",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7eb6c019-629b-4ea1-820b-3d7a77f89e4f"), Type = TextBlockType.Text, Text = "You are followed by a spirit or entity, either from childhood or since a traumatic or momentous event. You may have seen this entity. Others may have seen it as well. You have studied esoteric subjects trying to understand your situation, but this presence in your life remains a mystery. Whatever this entity is or wants, it influences your life in subtle ways, not always good. Sometimes the entity helps you, but at other times, its influence is malevolent or harmful. The entity is most likely to surface in stressful situations." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("52e03e19-2624-4f88-aa88-ea2fe4b41ac4"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("89e0dd96-1afa-4a75-b746-ac339556ebf0"), Stats.Instances.Wisdom.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("e3469922-00f9-49da-8e79-ab78b00cf17f"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("c3ae93cb-1057-481b-b5f9-fe376fda603d"));
            builder.GainSpecificSkillProficiency(Guid.Parse("9ded3c41-3313-403a-8190-2e94b7d2d507"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainAnySkillProficiency(Guid.Parse("31702a83-5b8e-4360-b038-1f2bcf186464"), Proficiencies.Instances.Trained.ID, "The chosen skill must be one in which the haunting entity is well-versed, determined by the GM. Any timy ou attempt a skill check for the entity's skill, the GM can offer you a +1 circumstance bonus to the check, as though the entity were Aiding you. If you accept but fail the check, you are Frightened 2 (or Frightened 4 on a critical failure). The initial frightened value can't be reduced by effects that would reduce or prevent the condition (such as a fighter's bravery).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18828cd0-864d-41b0-9a6c-16ba54e55e52"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 51
            };
        }
    }
}
