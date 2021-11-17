using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Criminal : Template
    {
        public static readonly Guid ID = Guid.Parse("608165d2-d3e3-41a6-9fb0-fed315dfe16a");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Criminal",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3f207a52-606b-4d01-8855-17a272617776"), Type = TextBlockType.Text, Text = "As an unscrupulous independent or as a member of an underworld organization, you lived a life of crime. You might have become an adventurer to seek redemption, to escape the law, or simply to get access to bigger and better loot." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("6d9c8712-d90c-4ecc-8674-38b689d3bf29"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("b81c12bb-0887-4869-b5b3-e54baeecb188"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("e536275c-fc1b-4b65-88e0-b86f630fa337"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("248ab1e2-8cf0-4eaa-8574-26eee1e4b1ff"));
            builder.GainSpecificSkillProficiency(Guid.Parse("8641b64b-b761-40e7-a81e-0fdd4a39034c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("4a28cb54-93bf-4211-b3bd-7cc459ef26ad"), Proficiencies.Instances.Trained.ID, Lores.Instances.Underworld.ID);
            builder.GainSpecificFeat(Guid.Parse("6dce847e-a060-4a83-b477-968bde696b04"), Feats.Instances.ExperiencedSmuggler.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32b3bc9c-bf7e-4b62-bd87-569a914b2c54"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
