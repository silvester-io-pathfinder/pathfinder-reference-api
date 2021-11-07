using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThaumaturgicRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("61a96fd1-98a7-4c1f-938c-88d4325da0cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thaumaturgic Ritualist",
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
            yield return new TextBlock { Id = Guid.Parse("f2d19cb5-3bec-4d98-bfd8-83ad33b593cc"), Type = TextBlockType.Text, Text = "Your studies into the supernatural have resulted in an especially strong knowledge of rituals. You gain a +2 circumstance bonus to all primary checks to perform a ritual. You learn two uncommon rituals with a level no higher than half your level; you must meet all prerequisites for casting the ritual to choose it. At 8th level and every 4 levels thereafter, you learn another uncommon ritual with a level no higher than half your level and for which you meet the prerequisites. You can cast these as the primary caster, but you can’t teach them to anyone else or allow someone else to serve as primary caster unless they know the ritual as well." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f4cd3c1-270f-47f2-ba5d-2d233e3c68ea"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
