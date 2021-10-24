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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Terrains.ID, "The chosen Lore skill must be related to one terrain you traveled in (such as Desert Lore or Swamp Lore).");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.MightyRage.ID, "The Assurance skill feat should relate to the Survival skill.");
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
