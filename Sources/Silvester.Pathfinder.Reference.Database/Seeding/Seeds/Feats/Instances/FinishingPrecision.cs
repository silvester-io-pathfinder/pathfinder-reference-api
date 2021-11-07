using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinishingPrecision : Template
    {
        public static readonly Guid ID = Guid.Parse("2efa5107-32b7-4ae3-b222-a2e2c61ff477");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finishing Precision",
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
            yield return new TextBlock { Id = Guid.Parse("94b32829-cecf-4f8e-bf18-39482e57a0ee"), Type = TextBlockType.Text, Text = "You’ve learned how to land daring blows when you have panache. You gain the precise strike class feature but you deal 1 additional damage on a hit and 1d6 damage on a finisher. This damage doesn’t increase as you gain levels. In addition, you gain the (feat: Basic Finisher) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bd758dd2-e986-4929-a432-0656cb4af2c5"), Feats.Instances.SwashbucklerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d88e3a8f-588a-4cfb-b347-0ce65dc11b62"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
