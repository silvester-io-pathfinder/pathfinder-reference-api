using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GuidingRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("bdec8e97-e35d-48ce-9576-57d6f319a766");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guiding Riposte",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e6750c8-2a49-4509-863a-0ea7767b0576"), Type = TextBlockType.Text, Text = "By shifting your weight and angling your weapon, you guide your opponent to a more favorable position. When you use (feat: Dueling Riposte) to (action: Strike) and you hit, you can move the target up to 10 feet into a space in your reach. This follows the forced movement rules (page 475)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f307ab1c-0ab5-4b06-ad8c-12685a4e1d40"), Feats.Instances.DuelingRiposte.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1b7cfee-d8c8-43a1-9962-f58a23836b1f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
