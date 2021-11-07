using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CantFallHere : Template
    {
        public static readonly Guid ID = Guid.Parse("1645d1c1-fc29-4f6d-a6ed-c50cf3018ec9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Can't Fall Here",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent and willing ally would be reduced to 0 HP but not killed.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("90948da7-2ad3-41ee-b9bc-5732503bf589"), Type = TextBlockType.Text, Text = "You physically help an ally remain standing and encourage them to push through their pain against dire odds. Your ally doesn’t fall unconscious and remains at 1 Hit Point. The ally also gains a number of temporary Hit Points equal to your level that last for 1 minute. Fighting onward with such an injury isn’t without consequence; your ally’s wounded condition increases by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec97159c-2770-4e52-a7b5-4e884fc86840"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
