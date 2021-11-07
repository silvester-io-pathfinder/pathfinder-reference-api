using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedSeekerOfTruths : Template
    {
        public static readonly Guid ID = Guid.Parse("a0344a11-2d7b-4a01-825a-7b8707c6f4b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Seeker of Truths",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat up to three times, each time selecting a different advanced domain spell from a domain you selected with (feat: Seeker of Truths).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("52100670-06ea-43a4-ac32-3ef237e2efa6"), Type = TextBlockType.Text, Text = "You have unlocked deeper secrets to uncovering and hoarding lore. You gain an advanced domain spell from one domain you selected with (feat: Seeker of Truths). Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dea11299-95c6-4708-87dd-abc1e4ebf1d3"), Feats.Instances.SeekerOfTruths.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e11ba46a-aec6-433e-87ee-b056ae47f2ec"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
