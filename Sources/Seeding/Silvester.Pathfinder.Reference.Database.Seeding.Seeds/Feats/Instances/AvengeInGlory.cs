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
    public class AvengeInGlory : Template
    {
        public static readonly Guid ID = Guid.Parse("45fcade3-4871-4cff-99a8-ea50ce15eec4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Avenge in Glory",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet gains the dying condition.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8db7068-b7c1-45de-942d-7b87ed01cf09"), Type = TextBlockType.Text, Text = $"~ Access: mountain dwarf ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("2cc747d2-d9fc-48d6-895b-d44bf1c9e664"), Type = TextBlockType.Text, Text = $"You honor your ally's life, gaining temporary Hit Points equal to your level for 1 minute. As long as you have these temporary Hit Points, you gain a +1 circumstance bonus to attack and damage rolls." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("97b87150-a1be-4a8f-aaa8-ee4c628d9e04"), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcb53987-f5b6-4ce2-88af-cdf9f535eff0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
