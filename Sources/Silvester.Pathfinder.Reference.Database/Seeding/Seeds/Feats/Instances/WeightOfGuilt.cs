using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeightOfGuilt : Template
    {
        public static readonly Guid ID = Guid.Parse("ab30d293-d403-482e-a425-92f6d060aa51");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weight of Guilt",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21ac34af-2995-4311-9e3b-2acebd197be5"), Type = TextBlockType.Text, Text = "Guilt clouds the minds of those who ignore your (feat: Glimpse of Redemption). Instead of making the triggering creature enfeebled 2, you can make it stupefied 2 for the same duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("c91552c2-3cf9-4fe5-890b-7d32460234d8"), Causes.Instances.Redeemer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16c5c365-f19d-4077-b55d-0a1a40da879e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
