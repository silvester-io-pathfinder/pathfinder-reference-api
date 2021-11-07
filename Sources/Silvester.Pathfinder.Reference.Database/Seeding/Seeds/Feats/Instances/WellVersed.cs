using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellVersed : Template
    {
        public static readonly Guid ID = Guid.Parse("bf9176b3-6bc5-4245-9736-694d7b9859e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Well-Versed",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0de51e35-5540-4ac0-8833-90e3eff9b19d"), Type = TextBlockType.Text, Text = "You’re resilient to performative influences that aren’t your own. You gain a +1 circumstance bonus to saving throws against effects with the (trait: auditory), (trait: illusion), (trait: linguistic), (trait: sonic), or (trait: visual) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e660885c-5520-4b1c-a8c8-9c7eadc7ae5e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
