using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Gambler : Template
    {
        public static readonly Guid ID = Guid.Parse("a47cb440-1b8d-4025-ad21-b23a8d244e46");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Gambler",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ef36815d-013e-4e72-a807-b59b7209cd00"), Type = TextBlockType.Text, Text = "The thrill of the win drew you into games of chance. This might have been a lucrative sideline that paled in comparison to the real risks of adventuring, or you might have fallen on hard times due to your gambling and pursued adventuring as a way out of a spiral." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("2e5d17df-1470-4dc3-a078-b7e239498a64"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("21a1e713-56fd-4539-a039-d6f70529b3fd"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("30ad88eb-9b7b-4f0f-9aea-affd244cb6f8"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("89157879-eec3-4206-a70e-5a8fe21d7297")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("ce6974fc-5780-44fe-ab44-f5d036fa2fe0"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Deception.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("00c29374-91ed-48d8-87ff-5d1e5c3da5c9"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Games.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("c86d3b1b-c664-44ec-8131-b0ae01e197cb"),
                FeatId = Feats.General.LieToMeFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8214780f-8ad9-4657-acb8-9c7963461006"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
