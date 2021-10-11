using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Nomad : Template
    {
        public static readonly Guid ID = Guid.Parse("8f7493a6-74cd-4734-bb3a-d94b3ae46cdd");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Nomad",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fee2c330-a8fe-48cb-8831-ea8a6b3e32bf"), Type = TextBlockType.Text, Text = "Traveling far and wide, you picked up basic tactics for surviving on the road and in unknown lands, getting by with few supplies and even fewer comforts. As an adventurer, you travel still, often into even more dangerous places." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("3e1e7301-3d4c-410a-a2f8-f766f3f56f19"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("98be99f2-5f70-4ec5-9796-7bd1f8bc0a7d"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("185cc6f4-8979-4cdc-8e67-05f8156a573b"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("2ee0d5ef-b3ab-43c9-91c4-b87de122cd29")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("2f37582b-77f3-4788-8df5-f8836c0b1369"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("a3f91c1a-c69c-4402-837f-57f7ba7f7450"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Terrains.ID,
                Restrictions = "The chosen Lore skill must be related to one terrain you traveled in (such as Desert Lore or Swamp Lore)."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("095c2a4e-c44f-4573-bc9e-c3e8c082140e"),
                FeatId = Feats.General.AssuranceFeat.ID,
                Restrictions = "The Assurance skill feat should relate to the Survival skill."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d29fe96-edcc-45a0-a3c2-6e1bbdfd3b5e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
