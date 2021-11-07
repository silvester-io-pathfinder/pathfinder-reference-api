using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AthleticMight : Template
    {
        public static readonly Guid ID = Guid.Parse("ed032a33-052d-48f5-89ce-fa87c2e7b521");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Athletic Might",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21ea9b9d-9a7a-47f2-aa96-e5bf72eb38c4"), Type = TextBlockType.Text, Text = "Surviving in hostile terrain has given you a great talent for mobility. Whenever you roll a success on an Athletics check to (action: Climb) or (action: Swim), you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4fc106cb-705d-4f61-87c1-d92c5db0c1b8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
