using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("bfab7fee-4559-406e-8e13-7092899987e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Clarity",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail or critically fail an attack roll or Will save.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96ce2f32-9bc6-44f7-bd54-c9235550b4cc"), Type = TextBlockType.Text, Text = $"You burn out all of your rage to ensure that your attack lands and your mind remains free. Reroll the triggering attack roll or Will save with a +2 circumstance bonus, use the better result, and resolve the effect. You then immediately stop raging." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bf1b794a-1837-4423-af80-37b711432e24"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("51c3e925-763b-49d8-943a-4bfabfdc3e0c"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("2e40d761-4033-46ea-b81a-47fb4ea82794"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("0b4a6c93-c131-4c3b-ac4c-4098611a611c"), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d0d70b2-96d8-45fc-a12c-8a44c362eb71"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
