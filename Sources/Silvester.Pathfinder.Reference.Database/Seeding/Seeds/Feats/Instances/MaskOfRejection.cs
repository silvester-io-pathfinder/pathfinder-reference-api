using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaskOfRejection : Template
    {
        public static readonly Guid ID = Guid.Parse("e9da89a4-bb47-4dce-b1f1-fd4d95c63f14");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mask of Rejection",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a saving throw against an effect from your warmask's magical tradition.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e627334a-2bed-46d9-bf25-65412268d8c8"), Type = TextBlockType.Text, Text = "Your warmask projects a white-hot fury that attempts to vaporize the offending magic. You reroll the triggering check with a +2 circumstance bonus, but you must use the new result, even if it’s worse than your first roll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2964a606-8138-44ef-9b19-82f845a5caa4"), Feats.Instances.OrcWarmask.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b7690017-a6df-4541-a504-7c8267abcaa8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
