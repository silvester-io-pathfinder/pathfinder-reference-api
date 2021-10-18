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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("4e275f7a-ce9a-4dfe-bb25-82193f130d86"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("90b8c505-518e-4b3f-a658-61cf42052588"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("2477b4da-f653-478e-b3d7-ff86120f1ac0"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("80b57e69-cb4b-4534-97cc-7ff57e598f0e")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("7af29e4a-98f9-4519-b249-722e70138126"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("fe744949-a59f-41f2-b85c-02c733c6b7b9"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Legal.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("c3aa750e-6904-490c-9dc1-3c2aa524ae79"),
                FeatId = Feats.General.ExperiencedTrackerFeat.ID
            };
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
