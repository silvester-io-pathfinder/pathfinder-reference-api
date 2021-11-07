using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EternalWings : Template
    {
        public static readonly Guid ID = Guid.Parse("0c0efd98-5392-4949-b508-232c8c5b0645");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eternal Wings",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3841f5f-fdf0-4993-a2a2-dae15add8535"), Type = TextBlockType.Text, Text = "Your wings are now a permanent part of your body. You gain the effects of (feat: Wings of Air) at all times rather than just once per day for 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("414a6a05-116b-4850-bc08-a9267d2ffb9b"), Feats.Instances.WingsOfAir.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51b9631a-496f-44e2-af7b-f9545421939e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
