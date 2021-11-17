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
            builder.AddOr(Guid.Parse("97b6014d-8cc9-4054-b207-9fd2301cb465"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("a3e50ea4-4a36-4db3-94b1-d982c281b597"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("cda02aac-2836-45c4-b134-70e1e20436e7"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("c21d1121-78ab-4add-9302-6f28c976417e"));
            builder.GainSpecificSkillProficiency(Guid.Parse("a0c87470-4810-4fb5-909d-5727aae703a5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("60af577e-6a15-48d2-93be-1d5b37cbc0a5"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Terrains.ID, "The chosen Lore skill must be related to one terrain you traveled in (such as Desert Lore or Swamp Lore).");
            builder.GainSpecificFeat(Guid.Parse("93a6e9bc-691f-4ef2-a3a4-aebb161182ee"), Feats.Instances.MightyRage.ID, "The Assurance skill feat should relate to the Survival skill.");
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
