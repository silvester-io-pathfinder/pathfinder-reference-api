using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StubbornPersistence : Template
    {
        public static readonly Guid ID = Guid.Parse("a14dc27e-5e92-4e1d-8c8b-a806cc51a514");

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
            yield return new TextBlock { Id = Guid.Parse("de6aa53c-5f9e-4740-82ef-83c1cf85bc08"), Type = TextBlockType.Text, Text = "Humans are renowned for their ability to persist through the most grueling of trials. When you would become fatigued, attempt a DC 17 flat check. On a success, you aren’t fatigued. If the fatigued condition has an underlying cause that you don’t address, such as lack of rest, you must attempt the check again at an interval determined by the GM until you fail the flat check or address the underlying cause." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d91b37e3-58fe-4c00-9280-cb864ca7597c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
