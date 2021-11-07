using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HighQualityScrounger : Template
    {
        public static readonly Guid ID = Guid.Parse("b97f068d-c9e0-47a1-8c5f-ff43d6eff9f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "High-Quality Scrounger",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d498e868-6508-4e07-b6f4-e513b5df768e"), Type = TextBlockType.Text, Text = "When you (action: Craft) a temporary item using (feat: Scrounger Dedication), it can be an item of up to 3rd level (though the item must still be a weapon, armor, or a nonconsumable piece of adventuring gear)." };
            yield return new TextBlock { Id = Guid.Parse("9dda5323-b39b-42c7-b514-7a7be9006fce"), Type = TextBlockType.Text, Text = "You can instead (action: Craft) it for someone else’s use, allowing them to avoid taking the penalty for using a shoddy item when using it, but causing you to take the penalty if you use it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dc7303e4-08d9-4fd7-be3b-8d162068cdb7"), Feats.Instances.ScroungerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ae20a39-8536-4238-95ba-6d2dc9457c06"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
