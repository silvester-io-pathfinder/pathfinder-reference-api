using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnravelMysteries : Template
    {
        public static readonly Guid ID = Guid.Parse("13d71910-e43c-4152-ab71-2a1c35cf619d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unravel Mysteries",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae275b6d-27d0-456f-bcb0-03df1a5136f2"), Type = TextBlockType.Text, Text = "You can understand the true meaning of texts quickly, and even when you get lost or hit a dead end, you aren’t discouraged from making further attempts to get to the bottom of things. When you (action: Decipher Writing), you need only half as long as usual (reducing the time from about 1 minute to about half a minute per page), and if you fail, you don’t take the usual -2 circumstance penalty to further checks to decipher that text." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDecipherWritingProficiency(Guid.Parse("d45d1466-0d99-41a6-b3c1-e13a46158785"), Proficiencies.Instances.Master.ID);
            builder.HaveSpecificFeat(Guid.Parse("3b2430a3-e5c5-4eac-84da-18f56af039be"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53d210f1-3713-4f66-88b7-76e78217b23d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
