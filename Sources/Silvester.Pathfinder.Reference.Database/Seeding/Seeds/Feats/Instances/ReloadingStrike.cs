using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReloadingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("fe4c9737-64bf-4954-96c0-2ab8147ab24c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reloading Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f331ed03-00d2-4055-8774-665cbdba4f4d"), Type = TextBlockType.Text, Text = "You make a melee attack and then reload your gun in one fluid movement. (action: Strike) an opponent within reach with your one-handed melee weapon (or, if your other hand is empty, with an unarmed attack), and then (action: Interact) to reload. You don’t need a free hand to reload in this way." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d551290a-2466-4a23-bbe6-646457ece73f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
