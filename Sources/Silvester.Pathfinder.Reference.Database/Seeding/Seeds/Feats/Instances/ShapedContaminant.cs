using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShapedContaminant : Template
    {
        public static readonly Guid ID = Guid.Parse("e1c4abe3-df2c-4709-b145-80527f21e04d");

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
            yield return new TextBlock { Id = Guid.Parse("d6598745-13b5-4586-9165-59d2e9bcce54"), Type = TextBlockType.Text, Text = "~ Access: elite member of the Poison Maker’s Guild" };
            yield return new TextBlock { Id = Guid.Parse("44a68aff-5516-475c-b392-7cdc6456940b"), Type = TextBlockType.Text, Text = "Through a combination of careful manipulation and precise breath control, you can deploy inhaled toxins precisely." };
            yield return new TextBlock { Id = Guid.Parse("34e25903-555c-4e80-846d-39ee3a057b43"), Type = TextBlockType.Text, Text = "When you activate an inhaled poison, you can cause it to fill a 20-foot line that’s 5 feet tall rather than a 10-foot cube. You gain a +3 status bonus to saving throws against inhaled poisons that you activate." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bffde606-e55d-495e-98a4-afb250c71399"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
