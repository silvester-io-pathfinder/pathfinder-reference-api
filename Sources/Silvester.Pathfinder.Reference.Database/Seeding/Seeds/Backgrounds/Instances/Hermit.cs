using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Hermit : Template
    {
        public static readonly Guid ID = Guid.Parse("9fbb9f8d-d379-463b-8734-0926eb093cd1");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Hermit",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("536b8e63-6330-4103-a2c8-14d4c774bf61"), Type = TextBlockType.Text, Text = "In an isolated place'like a cave, remote oasis, or secluded mansion'you lived a life of solitude. Adventuring might represent your first foray out among other people in some time. This might be a welcome reprieve from solitude or an unwanted change, but in either case, you're likely still rough around the edges." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("f1bf58c5-e7f8-4b72-bdbb-e130395e0a23"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("3fc5304e-ea4c-48a8-8aed-df711a88927e"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("14db8411-f7cd-4b53-b1f2-722f8e1243d9"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("a69be068-752a-4a01-bd7b-af9e269c7332")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("605bbd0e-84bd-476e-b3b0-8996e5357d26"),
                Choices = new Effect[] 
                {
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("3817a1ff-2093-4d25-af68-2d08226a8278"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Nature.ID },
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("4f131ffd-e298-43fd-81c6-c2682b3f3af3"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID },
                }
            };

            yield return new GainSpecificLoreCategoryProficiencyEffect
            {
                Id = Guid.Parse("0492ebf1-9625-4eaa-8ebc-4cff713b958e"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Terrains.ID,
                Restrictions = "The chosen Lore skill must be related to the terrain you lived in as a hermit (such as Cave Lore or Deser Lore)."
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("b53daf8b-42a4-414a-b2b8-1722fc9844c4"),
                FeatId = Feats.General.DubiousKnowledgeFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34d2e37f-2ae5-468a-9433-841766891ebb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
