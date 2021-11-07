using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Riftmarked : Template
    {
        public static readonly Guid ID = Guid.Parse("31e2409c-8068-4087-9a6d-140af4dbab69");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Riftmarked",
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
            yield return new TextBlock { Id = Guid.Parse("c95156c5-acc6-4a81-8dd4-e2d17aaba38c"), Type = TextBlockType.Text, Text = "Long ago, qlippoth marked someone in your lineage, most likely through their ancient runestones that dot Golarion’s surface. Yours is an old lineage, primordial and twisted, and you have a sense for similarly twisted things. You’re trained in Occultism. If you’re already trained in Occultism (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the (feat: Oddity Identification) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2adb0200-df1d-4d6a-b640-906439d0e83a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
