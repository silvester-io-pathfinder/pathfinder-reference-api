using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DirectedChannel : Template
    {
        public static readonly Guid ID = Guid.Parse("bfec8108-9f08-4ecd-8a8f-bc2f6dd1c3bd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Directed Channel",
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
            yield return new TextBlock { Id = Guid.Parse("0e9a2782-761c-4936-af73-c3ccef17b673"), Type = TextBlockType.Text, Text = "You can shape the energy you channel in a single direction, reaching farther and in a more directed fashion. When you cast a version of (spell: harm) or (spell: heal) that has an area, you can make its area a 60-foot cone instead of a 30-foot emanation." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94ef41ed-f722-4196-b920-ff6a24e8c1b4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
