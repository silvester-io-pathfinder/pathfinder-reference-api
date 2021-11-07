using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MightyBulwark : Template
    {
        public static readonly Guid ID = Guid.Parse("087e7973-4656-44db-9f06-8ee0872bf2f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mighty Bulwark",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc3a82c6-c779-4efc-95a1-f8519bd0ca29"), Type = TextBlockType.Text, Text = "Thanks to your incredible connection to your armor, you can use it to shrug off an incredible array of dangers. Your bonus from the (trait: bulwark) armor trait increases from +3 to +4, and it applies on all Reflex saves, not just damaging Reflex saves." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("78956a3d-9013-4754-9ca4-c9c172229da3"), Feats.Instances.SentinelDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4096b6e0-0b90-49a2-a832-5faa55ed99c1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
