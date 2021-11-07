using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PremonitionOfAvoidance : Template
    {
        public static readonly Guid ID = Guid.Parse("bc438044-1a24-49e9-948c-be06e6008979");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Premonition of Avoidance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a hazard, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4f3c9a73-19d9-411b-8271-322c3151e6a5"), Type = TextBlockType.Text, Text = "Your deity grants you limited foresight, warning you of dangers an instant before they occur. You gain a +2 circumstance bonus to the triggering saving throw." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec59ae44-7d99-4617-af83-56d04ed4b586"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
