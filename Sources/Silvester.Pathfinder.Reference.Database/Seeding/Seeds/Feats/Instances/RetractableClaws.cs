using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RetractableClaws : Template
    {
        public static readonly Guid ID = Guid.Parse("d9bc72dd-53bc-46f8-bfc2-2b00f10f6e43");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Retractable Claws",
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
            yield return new TextBlock { Id = Guid.Parse("d5949ba5-401a-4c84-8826-75ca993a3b35"), Type = TextBlockType.Text, Text = "You gain a claw unarmed attack that deals 1d4 slashing damage. Your claws are in the brawling group and have the (trait: agile), (trait: finesse), and (trait: unarmed) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6e19579-731e-49b5-a2dd-e0245d554669"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
