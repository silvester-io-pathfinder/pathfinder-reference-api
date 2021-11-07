using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OpportunisticGrapple : Template
    {
        public static readonly Guid ID = Guid.Parse("2cbf169b-067c-45e5-818d-a8773c796969");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Opportunistic Grapple",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your prey critically fails on a melee Strike's attack roll against you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c8a6bf3-a79a-4ba5-b02a-532c65ff0c9a"), Type = TextBlockType.Text, Text = "You attempt an Athletics check to (action: Grapple) your prey." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f5b91b7d-7e39-4ca4-9970-917e8f58df7f"), Feats.Instances.BountyHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2909982d-ad36-463d-85e3-5f60de51b7ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
