using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShootistsDraw : Template
    {
        public static readonly Guid ID = Guid.Parse("5df6d6dc-da5b-4059-93f5-034d7a723ae1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shootist's Draw",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cee23844-9613-4359-b2e4-a8a57bbca043"), Type = TextBlockType.Text, Text = "You (action: Interact) to draw a (item: hand crossbow) and (action: Strike) with it, or you (action: Strike) with a loaded (item: hand crossbow) you&#39;re already holding and then (action: Interact) to stow it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("237ac1fc-520f-4fe7-8ea4-35e3bf2965eb"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
