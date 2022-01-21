using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Barkeep : Template
    {
        public static readonly Guid ID = Guid.Parse("22e6e5d5-2489-4d75-ab44-8eed23e5cf9b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Barkeep",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5c99fef7-4af0-4120-9fc2-f83c2565d5e4"), Type = TextBlockType.Text, Text = "You have five specialties: hefting barrels, drinking, polishing steins, drinking, and drinking. You worked in a bar, where you learned how to hold your liquor and rowdily socialize." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("a5115f22-a20f-4204-81e0-509295fc2bbf"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("6bc11173-991a-4365-ba82-804569dfbc13"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("8c3ffbf0-1809-4d36-8d11-d498a6bf8540"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("425030f0-e300-4490-a465-b636b9169761"));
            builder.GainSpecificSkillProficiency(Guid.Parse("958152f0-511a-4541-bbe7-da5773ba0306"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("65c1df69-b358-4ab7-b211-a8996d06b6b2"), Proficiencies.Instances.Trained.ID, Lores.Instances.Alcohol.ID);
            builder.GainSpecificFeat(Guid.Parse("7ab2f526-c8d6-4150-b782-a7f630f0da22"), Feats.Instances.Hobnobber.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90739f5b-2a98-4011-92d3-571d04dcabdb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
