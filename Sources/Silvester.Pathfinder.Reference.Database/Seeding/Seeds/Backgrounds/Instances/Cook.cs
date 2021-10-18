using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Cook : Template
    {
        public static readonly Guid ID = Guid.Parse("905c8239-ef8e-480b-b45e-e75222d2af6c");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Cook",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("177d5826-30a3-4617-8751-eef030328d5f"), Type = TextBlockType.Text, Text = "You grew up in the kitchens of a tavern or other dining establishment and excelled there, becoming an exceptional cook. Baking, cooking, a little brewing on the side'you've spent lots of time out of sight. It's about time you went out into the world to catch some sights for yourself." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("5a150511-700f-4d84-8ebc-d87c6b236613"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("28d0c00b-c79e-4333-af9c-53004b021033"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("c6fa94fc-f438-4567-9a5d-8d3cd7fb764b"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("c8a7066e-7d9f-4fd5-bb05-ca2f99d1f155")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("545bc0b1-ed66-4588-b8c1-54d6e10de76a"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("af37f795-5cd3-45d0-8b27-0cfc4d81f5df"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Cooking.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("516aa925-7ed1-4248-a403-74fe9592738a"),
                FeatId = Feats.General.SeasonedFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("36aa989d-8094-4985-a688-250cf36bf70b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
