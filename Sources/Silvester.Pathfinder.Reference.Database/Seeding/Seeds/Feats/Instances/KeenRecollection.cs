using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KeenRecollection : Template
    {
        public static readonly Guid ID = Guid.Parse("e7a09852-3a8c-42b6-8577-c5bd7c08fe86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Keen Recollection",
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
            yield return new TextBlock { Id = Guid.Parse("3e8b545b-6566-4e87-8abc-81b971f5db96"), Type = TextBlockType.Text, Text = "You can recall all sorts of information. You gain the keen recollection class feature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3fdbb139-d77e-4299-8dbd-89d81ea9609f"), Feats.Instances.InvestigatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b3ebcf3-bdc9-430d-b698-c8c7bac84322"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
