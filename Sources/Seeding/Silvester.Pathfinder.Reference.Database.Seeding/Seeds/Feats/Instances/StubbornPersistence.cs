using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StubbornPersistence : Template
    {
        public static readonly Guid ID = Guid.Parse("d3eeb485-6599-46ef-8c30-a22393043a06");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stubborn Persistence",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f4a8c077-12bd-45a2-9d33-8a79706d283c"), Type = TextBlockType.Text, Text = "Humans are renowned for their ability to persist through the most grueling of trials. When you would become fatigued, attempt a DC 17 flat check. On a success, you aren’t fatigued. If the fatigued condition has an underlying cause that you don’t address, such as lack of rest, you must attempt the check again at an interval determined by the GM until you fail the flat check or address the underlying cause." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81fe8db8-c7e9-44da-bb1f-8f3ca1de2db0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
