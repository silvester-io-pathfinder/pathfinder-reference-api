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
    public class BountyHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("95f26485-e9e4-46a5-a702-7478f929ff73");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Bounty Hunter",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c371b7e4-21d0-434e-8d09-104f74d7f319"), Type = TextBlockType.Text, Text = "Bringing in lawbreakers lined your pockets. Maybe you had an altruistic motive and sought to bring in criminals to make the streets safer, or maybe the coin was motivation enough. Your techniques for hunting down criminals transfer easily to the life of an adventurer." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("2f59a845-b911-474a-ad4c-b2fd24a392eb"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("54fe9667-19c9-490a-aba6-15c931e987f1"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("874ef9fe-7a1d-4f36-acfb-a116a33341e1"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("9f2ee500-dd61-4e51-ab8f-6039cd4709f5"));
            builder.GainSpecificSkillProficiency(Guid.Parse("52e975fe-0801-4326-8f1b-fd4117ece110"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("af2cc1a5-ac18-4d8d-a181-3788b80a95dd"), Proficiencies.Instances.Trained.ID, Lores.Instances.Legal.ID);
            builder.GainSpecificFeat(Guid.Parse("e4439617-fa38-4bc3-9e0e-75369eff40ab"), Feats.Instances.ExperiencedTracker.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c58aa6ff-e500-4b03-bdd0-a056894b91f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
