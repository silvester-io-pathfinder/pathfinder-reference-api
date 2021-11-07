using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodInTheAir : Template
    {
        public static readonly Guid ID = Guid.Parse("1993b225-f199-4d21-958e-62af14c8a298");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blood in the Air",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("963bc714-1783-4b4f-9be2-0a0081a53d81"), Type = TextBlockType.Text, Text = "Once you’ve locked on to a target, little can obscure your aim. Make a ranged weapon (action: Strike) against the required target. This (action: Strike) ignores the target’s concealed condition and reduces the flat check for the hidden condition from 11 to 5." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94b34ad7-36e6-413a-85a0-fe57a8fdd89d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
