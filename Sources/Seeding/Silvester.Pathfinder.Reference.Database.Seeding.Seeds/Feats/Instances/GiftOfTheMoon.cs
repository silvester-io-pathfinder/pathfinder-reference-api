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
    public class GiftOfTheMoon : Template
    {
        public static readonly Guid ID = Guid.Parse("a438ce0b-ecf3-4f90-b83a-e6e345bb0a5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gift of the Moon",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8556b39a-ad74-4a50-959f-9fe670ae810d"), Type = TextBlockType.Text, Text = $"You can share your power with others, but they can't escape the werecreature's curse as easily as you can. You can cast a 5th-level {ToMarkdownLink<Models.Entities.Spell>("moon frenzy", Spells.Instances.MoonFrenzy.ID)} as a primal innate spell once per day. At 15th level, you cast a 6th-level {ToMarkdownLink<Models.Entities.Spell>("moon frenzy", Spells.Instances.MoonFrenzy.ID)} instead. At 17th level, your 6th-level {ToMarkdownLink<Models.Entities.Spell>("moon frenzy", Spells.Instances.MoonFrenzy.ID)} grants its standard effects, except the temporary Hit Points increase to 15 and the silver weakness increases to 15. At 20th level, you cast a 10th-level {ToMarkdownLink<Models.Entities.Spell>("moon frenzy", Spells.Instances.MoonFrenzy.ID)} instead. The spell uses your class DC or spell DC, whichever is higher." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1a0c6c4d-bc16-42a0-927b-fc5b04b32b3e"), Traits.Instances.Beastkin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ec919a4-43ff-4606-837d-a5861d72b0fd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
