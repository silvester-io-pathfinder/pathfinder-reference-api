using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LifeGivingMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("34150ea4-cdf1-44f1-800b-eed881130346");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Life-Giving Magic",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You cast an innate spell from a gnome heritage or ancestry feat.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95ce50f4-b9bd-4123-983f-e39d4ca71adb"), Type = TextBlockType.Text, Text = "The upwelling of innate magic refreshes your body. You gain a number of temporary Hit Points equal to half your level (minimum 1) that last until the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4639b786-c1ac-49fd-a0d6-87d9f0565c84"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
