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
    public class FortuneTeller : Template
    {
        public static readonly Guid ID = Guid.Parse("767109ae-2517-4a86-b871-aa6a45869a44");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Fortune Teller",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2814ad24-21f3-4620-af19-c1c2fe448924"), Type = TextBlockType.Text, Text = "The strands of fate are clear to you, as you have learned many traditional forms by which laypeople can divine the future. You might have used these skills to guide your community, or simply to make money. But even the slightest peek into these practices connects you to the occult mysteries of the universe." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("c0f951b3-46d2-4caf-97c4-5c1f0f262857"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("6ce0a418-6a65-4b4d-b838-0db82bc4c5ce"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("c932aed2-4948-49a7-8bab-93bda55e8e26"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("5146e174-2ec2-4a63-a9f2-887caee816eb"));
            builder.GainSpecificSkillProficiency(Guid.Parse("dad35b3a-8c7a-41b0-9738-aa5fa81ac0bf"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("32d631ff-8a61-419c-84de-f2ebf98716a7"), Proficiencies.Instances.Trained.ID, Lores.Instances.FortuneTelling.ID);
            builder.GainSpecificFeat(Guid.Parse("372dc5de-b186-4a79-8f4b-8676f85c6da0"), Feats.Instances.OddityIdentification.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc9677df-f829-4d5c-a881-0d2382666a61"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
