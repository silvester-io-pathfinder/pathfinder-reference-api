using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Miner : Template
    {
        public static readonly Guid ID = Guid.Parse("d25af06a-9abc-4578-a688-6566d2c3669f");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Miner",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c3a359a6-00ba-4600-aa3a-e710f3c472c4"), Type = TextBlockType.Text, Text = "You earned a living wrenching precious minerals from the lightless depths of the earth. Adventuring might have seemed lucrative or glamorous compared to this backbreaking labor' and if you have to head back underground, this time you plan to do so armed with a real weapon instead of a miner's pick." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("5d88be42-998f-4ead-b3cc-57580617e901"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("8ff24d71-a941-4b9e-94ae-eb6a459013db"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("0fda3cfb-ef5a-42f6-afe4-7c14cfdecd7e"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("efe73217-0db4-43b2-aa6c-2f23dacaaa2c")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("c7ddcf04-ddd5-4473-a4ac-f8262e38f0d0"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("f01f0f6a-1c4e-4bd9-9d5b-ce15b58dc8a1"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Mining.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("783aa411-e63a-414c-a6cf-8a459ef1d4d5"),
                FeatId = Feats.General.TerrainExpertiseFeat.ID,
                Restrictions = "The chosen terrain should be 'underground'."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab7248b6-6526-4ee3-aa5e-e988852c8a14"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
