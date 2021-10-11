using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SeerOfTheDead : Template
    {
        public static readonly Guid ID = Guid.Parse("d73a214a-0bd3-450c-8ec2-870bda06006d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Seer of the Dead",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ad1cb62f-8012-49c7-8da6-e5dd86d8db26"), Type = TextBlockType.Text, Text = "You have long been gifted with the ability to see and speak with the departed. This could have manifested at your birth or when a chance encounter linked you inextricably to the spirits of the dead. Their constant presence might feel like a curse, or it might provide you with welcome companionship." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("669f0194-59a6-4707-95cd-7cc25892ef47"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("def7fe70-b7f5-4534-8a3b-598323ae7980"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("2011a2d8-213b-4cb6-8d4a-ee639d5748cc"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("63dbb789-5088-498f-95e9-2d43d4d33c1c"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Religion.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("65eb89ca-d2f3-4cc8-964e-17a68957a547"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Undead.ID
            };

            yield return new SenseEffect
            {
                Id = Guid.Parse("33342e64-b1dd-4cb6-9732-a15f6b78a6be"),
                SenseId = Senses.Instances.SpiritSense.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ef83c6d-4d90-4d1b-8ad2-bbd3639fc43d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 31
            };
        }
    }
}
