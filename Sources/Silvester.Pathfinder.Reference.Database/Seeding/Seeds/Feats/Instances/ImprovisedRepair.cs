using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovisedRepair : Template
    {
        public static readonly Guid ID = Guid.Parse("513858e3-ddd0-4ccd-8b47-bd617d5aedff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvised Repair",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6380ddc3-ad02-4a24-a0a6-9e1763fa751a"), Type = TextBlockType.Text, Text = "You are skilled at making quick fixes to damaged equipment, but your fixes aren’t meant to last forever. You make a quick repair to a broken non-magical item in your possession. Until the item takes damage again, you can still use it as a shoddy item of its type. This repair restores no Hit Points, so the item is easy to destroy. Once the item is (action: Repaired | Repair) normally such that it is no longer broken, it is also no longer shoddy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01acf957-9744-402b-96c7-6236e55ee998"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
