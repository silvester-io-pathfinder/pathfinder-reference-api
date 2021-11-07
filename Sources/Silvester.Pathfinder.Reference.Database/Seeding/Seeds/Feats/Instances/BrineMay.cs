using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrineMay : Template
    {
        public static readonly Guid ID = Guid.Parse("fc77dcde-c143-47a9-86da-23b01f394166");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brine May",
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
            yield return new TextBlock { Id = Guid.Parse("24c9348a-3e2d-405d-9ce9-6094571ad88d"), Type = TextBlockType.Text, Text = "Your mother was a sea hag, granting you one sea-green or blue eye. You find comfort both in the sea and on the shore. Whenever you roll a success on an Athletics check to (action: Swim), you get a critical success instead. If you end your turn in water without having succeeded at a (action: Swim) action that round, you don&#39;t sink (but you might still be moved by the current)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5c2751f-7eef-4fb1-8bc3-dcd212592cae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
