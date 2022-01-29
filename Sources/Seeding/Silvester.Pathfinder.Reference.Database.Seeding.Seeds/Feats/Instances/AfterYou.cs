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
    public class AfterYou : Template
    {
        public static readonly Guid ID = Guid.Parse("1bea3c3b-3e95-4a57-8587-47e88d5c1d7b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "After You",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You're about to roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69a3c11e-ba1d-48c2-8521-d83fcb8c109f"), Type = TextBlockType.Text, Text = $"You allow your foes to make the first move in a show of incredible confidence. You don't roll initiative; instead you voluntarily go last. You gain panache. If more than one character uses this ability or another ability to go last, use the normal rules for resolving a tie: NPCs and monsters act before PCs, and within those groups, the creatures can choose whichever order they want." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("308bbeed-1aa9-4ecc-8b71-e5abe6d021e2"), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0bac7f88-e9d0-4356-a67c-001dbf1c8299"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
