using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShapedContaminant : Template
    {
        public static readonly Guid ID = Guid.Parse("a4965063-3fb2-4576-8fa7-dd5868bb6ce3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shaped Contaminant",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e5c8e8a-aaad-4b38-a972-4ffcb961bb46"), Type = TextBlockType.Text, Text = $"~ Access: elite member of the Poison Maker's Guild" };
            yield return new TextBlock { Id = Guid.Parse("34d220f3-a5b1-4434-a89c-6c5175ed48a1"), Type = TextBlockType.Text, Text = $"Through a combination of careful manipulation and precise breath control, you can deploy inhaled toxins precisely." };
            yield return new TextBlock { Id = Guid.Parse("8a781dbe-3ea6-472a-a3bf-d0b4c3f71ce1"), Type = TextBlockType.Text, Text = $"When you activate an inhaled poison, you can cause it to fill a 20-foot line that's 5 feet tall rather than a 10-foot cube. You gain a +3 status bonus to saving throws against inhaled poisons that you activate." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a0900f4-24b8-40fe-92c5-6774a2a09d02"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
