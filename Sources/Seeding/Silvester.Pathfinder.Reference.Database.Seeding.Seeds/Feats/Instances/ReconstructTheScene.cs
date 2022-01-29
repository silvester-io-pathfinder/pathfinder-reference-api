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
    public class ReconstructTheScene : Template
    {
        public static readonly Guid ID = Guid.Parse("566604db-8b88-41d5-bef6-600bea1cf695");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reconstruct the Scene",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("43c361ae-401b-4c64-bc01-6a8517ea179c"), Type = TextBlockType.Text, Text = $"You spend 1 minute surveying a small location (such as a single room) to get an impression of events that occurred there in the last day. This involves moving about the area and studying footprints, the placement of objects, spilled drinks or blood, and so forth. You get an indistinct mental impression of significant events that happened there. This gives you clues and details of the past, including the overall events and their time frame, but it's not a perfect record. This also isn't enough to identify who was involved in these events if you weren't already aware the person was there. As determined by the GM, you also pick out various seemingly small details that could serve as important clues, like a memorable weapon someone used for a murder or the type of cloak someone wore when passing through." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9c536d60-2893-4ec9-856d-f0d8fe86b6a3"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("a27b8362-c9d4-469c-aff0-ad1f921ff373"), Traits.Instances.Investigator.ID);
            builder.Add(Guid.Parse("b45778af-8487-4033-b37f-2683dd87d32c"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3750317-6940-4957-a2b0-7f3b2e7d3de4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
