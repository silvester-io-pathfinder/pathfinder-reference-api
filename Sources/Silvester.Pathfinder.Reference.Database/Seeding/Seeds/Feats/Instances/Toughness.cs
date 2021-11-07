using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Toughness : Template
    {
        public static readonly Guid ID = Guid.Parse("de3dcdd6-27ae-4a3a-aa2d-06ac4a942200");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Toughness",
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
            yield return new TextBlock { Id = Guid.Parse("ac7b6c11-3fd3-4562-ae68-987d4f008f55"), Type = TextBlockType.Text, Text = "You can withstand more punishment than most before succumbing. Increase your maximum Hit Points by your level. The DC of recovery checks is equal to 9 + your dying condition value." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("323fa937-074f-440c-8661-c8defee306fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
