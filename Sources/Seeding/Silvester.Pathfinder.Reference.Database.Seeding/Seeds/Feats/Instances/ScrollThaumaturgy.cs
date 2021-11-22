using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollThaumaturgy : Template
    {
        public static readonly Guid ID = Guid.Parse("9de5b60a-df3c-4f70-a270-180a0e819f76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scroll Thaumaturgy",
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
            yield return new TextBlock { Id = Guid.Parse("a1675f04-b2a1-4624-874b-55b0d563bc6d"), Type = TextBlockType.Text, Text = "Your multidisciplinary study of magic means you know how to activate the magic in scrolls with ease. You can Activate scrolls of any magical tradition, using your thaumaturge class DC for the scroll's DC, rather than a particular spell DC. If a spell is on the spell list for multiple traditions, you choose which tradition to use at the time you Activate the scroll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eeafcd61-7637-4fc7-9a5e-f14d08501a66"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
