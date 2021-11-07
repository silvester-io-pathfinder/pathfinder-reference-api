using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoothingBallad : Template
    {
        public static readonly Guid ID = Guid.Parse("6ffa252b-3f8a-4abd-a0f4-4b15ca52b6bd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soothing Ballad",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73a47528-84c4-4e7a-83df-ba3148a9c4df"), Type = TextBlockType.Text, Text = "You soothe your allies’ wounds with the power of your performance. You learn the (spell: soothing ballad) composition spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("601413e3-e2f8-4dea-ba55-e6ba3be63288"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
