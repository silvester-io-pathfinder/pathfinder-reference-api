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
    public class FarmHand : Template
    {
        public static readonly Guid ID = Guid.Parse("2df19a79-1c57-4780-910d-98bab87d5430");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Farm Hand",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("94f153aa-e76d-4c57-a2cd-ec4b032349e7"), Type = TextBlockType.Text, Text = "With a strong back and an understanding of seasonal cycles, you tilled the land and tended crops. Your farm could have been razed by invaders, you could have lost the family tying you to the land, or you might have simply tired of the drudgery, but at some point you became an adventurer." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("febf9970-5ff6-442f-9a24-672e327ed1f5"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("d47ed46e-2e92-4d3f-8bda-2b126deb84ef"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("e243fca8-4a51-472a-9cb7-1b2c36b36648"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("b5dec7c8-a845-420a-bc61-19987450556d"));
            builder.GainSpecificSkillProficiency(Guid.Parse("c6e97e29-fc36-4a04-a78a-c43e6a262bd8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("36e270c4-7922-45cb-a817-533d9c659a6f"), Proficiencies.Instances.Trained.ID, Lores.Instances.Farming.ID);
            builder.GainSpecificFeat(Guid.Parse("b25a2e64-8c58-4498-9b7d-d89170bf8372"), Feats.Instances.Assurance.ID, "The Assurance skill feat should relate to the Athletics skill.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e8ad112-4ff2-4e13-aade-3b63ace1e4c4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
