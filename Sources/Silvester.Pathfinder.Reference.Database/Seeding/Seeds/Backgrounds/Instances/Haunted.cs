using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("21eeb443-207b-4734-a155-2f56bf35f31f"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("142d407b-93b4-44b9-9143-92e5b10a049e"), StatId = Stats.Instances.Wisdom.ID },
                    new StatEffectBinding{Id = Guid.Parse("92df0c52-3012-418a-9a93-aa064066ee30"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("8581b409-74c7-423c-b300-3070103760d2")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("1cd8dcc2-cfa7-42d4-a9da-6aca79c3db9b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new FreeSkillEffect
            {
                Id = Guid.Parse("d25eda5f-02d9-4e1d-98ff-cafbfa232c9c"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Restrictions = "The chosen skill must be one in which the haunting entity is well-versed, determined by the GM. Any timy ou attempt a skill check for the entity's skill, the GM can offer you a +1 circumstance bonus to the check, as though the entity were Aiding you. If you accept but fail the check, you are Frightened 2 (or Frightened 4 on a critical failure). The initial frightened value can't be reduced by effects that would reduce or prevent the condition (such as a fighter's bravery)."
            };
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
