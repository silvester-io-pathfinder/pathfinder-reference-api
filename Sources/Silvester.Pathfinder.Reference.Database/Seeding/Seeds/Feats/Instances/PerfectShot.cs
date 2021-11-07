using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectShot : Template
    {
        public static readonly Guid ID = Guid.Parse("85a5b6e2-32cd-4740-a917-ef734d78fed3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Shot",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e96514bf-2c4c-4d8c-8889-f6b92702f1cd"), Type = TextBlockType.Text, Text = "After watching the motions of combat with incredible intensity and precision, you fire at your prey at the perfect moment to deliver maximum pain. Make a ranged (action: Strike) with the required weapon against your hunted prey. If you hit, the (action: Strike) deals maximum damage. After the (action: Strike), your turn ends." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bbf68c7-3e97-4b67-b54f-94ceb252ec5f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
