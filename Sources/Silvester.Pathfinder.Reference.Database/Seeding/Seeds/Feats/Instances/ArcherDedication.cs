using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcherDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("76d95196-b492-4aa1-a8dd-a42d3d96f849");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Archer Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the archer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0209ec81-b04b-451a-8975-d6cd2e7fa098"), Type = TextBlockType.Text, Text = "You become trained in all simple and martial weapons in the bow weapon group. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency rank in all simple and martial weapons in the bow weapon group. If you are at least an expert in the bow you are using, you gain access to the critical specialization effect with that bow." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("816395c8-18da-415a-8d10-f9b15529a589"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
