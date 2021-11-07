using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DesperatePrayer : Template
    {
        public static readonly Guid ID = Guid.Parse("ce16b2a1-1419-4a0b-a360-16359e93ddfe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Desperate Prayer",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You begin your turn and have no Focus Points in your pool.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8fd24514-fecd-4c4c-b5af-fb0f01603278"), Type = TextBlockType.Text, Text = "You call out to your deity in a plea for their aid. You instantly recover 1 Focus Point." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b8e44be-4652-4481-b3e6-d26b84eaf451"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
