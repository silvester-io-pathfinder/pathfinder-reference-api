using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FledglingFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("522e7c69-b8c9-4ed7-bb12-18eb902af54e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fledgling Flight",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df10510b-1c4c-4c9f-86cd-fb6ec39f8c7b"), Type = TextBlockType.Text, Text = "You can fly through the air in short bursts at half your land Speed. If you don’t end your movement on solid ground, you fall at the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8edfb85f-6798-4092-9183-e6748b61021c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
