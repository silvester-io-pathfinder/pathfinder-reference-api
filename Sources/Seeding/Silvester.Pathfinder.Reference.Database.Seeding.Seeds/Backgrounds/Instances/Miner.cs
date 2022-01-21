using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("1522bc4d-07a7-4788-92f0-8e1a3a888f86"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("a02a8c6a-2f3b-40b8-8071-5747e1551da9"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("92a1a307-fb47-427f-bfa8-3fcabc7fac35"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("808ac5b6-e35e-456b-a24b-2541ad0781b6"));
            builder.GainSpecificSkillProficiency(Guid.Parse("947e573a-70db-42f9-9b94-ef70cf8bca7d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("6ed95958-cf6d-4f58-a812-ecad501886a3"), Proficiencies.Instances.Trained.ID, Lores.Instances.Mining.ID);
            builder.GainSpecificFeat(Guid.Parse("f74c43ff-100a-4d96-bb0c-1ad21be3adae"), Feats.Instances.TerrainExpertise.ID);
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
