using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MarinersFire : Template
    {
        public static readonly Guid ID = Guid.Parse("d442f1a8-f964-40f5-ba25-9345ac701dfb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mariner's Fire",
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
            yield return new TextBlock { Id = Guid.Parse("db2d7a86-7e8c-476a-a39c-6a0b513a848a"), Type = TextBlockType.Text, Text = "You conjure uncanny orbs of spiritual flame that float above or below the water’s surface. You can cast the (spell: produce flame) cantrip as a primal innate spell at will, heightened to a spell level equal to half your level rounded up. You can cast this cantrip underwater." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e66e28a0-cc76-4e75-81a0-0045dbcb84ea"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
