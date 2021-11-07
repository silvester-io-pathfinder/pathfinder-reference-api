using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClearTheWay : Template
    {
        public static readonly Guid ID = Guid.Parse("03626594-980c-4092-9e58-ec6ac318f544");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clear the Way",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f636f910-350c-4476-897c-9fbfed9a9c51"), Type = TextBlockType.Text, Text = "You put your body behind your massive weapon and swing, shoving enemies to clear a wide path. You attempt to (action: Shove) up to five creatures adjacent to you, rolling a separate Athletics check for each target. Then (action: Stride) up to half your Speed. This movement doesn’t trigger reactions from any of the creatures you successfully (action: Shoved | Shove)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9dc340ab-248f-40e9-9490-2262db62cc6d"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34877ce2-22ef-47a7-aae7-56ef164e514a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
