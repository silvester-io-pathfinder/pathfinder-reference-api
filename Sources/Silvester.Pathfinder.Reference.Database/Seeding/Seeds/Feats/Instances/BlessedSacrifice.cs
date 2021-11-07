using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlessedSacrifice : Template
    {
        public static readonly Guid ID = Guid.Parse("3f168684-9ad4-4670-9a8d-29c6f5921748");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed Sacrifice",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("068167b0-f2f5-4ca3-9c32-e462905ac2d1"), Type = TextBlockType.Text, Text = "You gain the (spell: protector’s sacrifice) domain spell as a devotion spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7286b50c-230f-4285-ab90-900a7dc806b5"), Feats.Instances.BlessedOneDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("628cfdf6-caa2-4594-a466-4ba2ebdc2f28"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
