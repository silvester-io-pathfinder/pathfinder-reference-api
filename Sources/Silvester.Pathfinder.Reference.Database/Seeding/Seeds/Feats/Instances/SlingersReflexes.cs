using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SlingersReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("5e180e05-4c9d-4227-ba11-efa5ce970075");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slinger's Reflexes",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1636b200-69ae-4f70-af96-ca85f2498053"), Type = TextBlockType.Text, Text = "Your ability to react to unexpected circumstances is preternaturally sharp. At the start of each enemy’s turn, you gain an additional reaction you can use on only that turn to use a gunslinger reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55d3bdd6-4861-4ac3-880a-f42f6b3f1439"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
