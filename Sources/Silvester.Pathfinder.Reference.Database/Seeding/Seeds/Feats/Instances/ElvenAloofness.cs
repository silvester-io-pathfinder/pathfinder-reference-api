using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElvenAloofness : Template
    {
        public static readonly Guid ID = Guid.Parse("480a7eb7-0e99-45bf-92a6-ad1f17c09f16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elven Aloofness",
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
            yield return new TextBlock { Id = Guid.Parse("edfce492-d42e-4d47-bd3e-adcbf33577f5"), Type = TextBlockType.Text, Text = "As much as you might care for them, you’ve come to terms with the ephemeral nature of non-elves, and it makes their threats feel less troublesome. If a non-elf rolls a failure on a check to (action: Coerce) you using Intimidation, it gets a critical failure instead (and thus can’t try to (action: Coerce) you again for 1 week). When a non-elf attempts to (action: Demoralize) you, you become temporarily immune for 1 day, instead of 10 minutes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69204a29-3672-4eaf-846a-5449eef1c89b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
