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
    public class CantorianRestoration : Template
    {
        public static readonly Guid ID = Guid.Parse("e1306310-2da6-4d4c-954d-e9105ca1e9e3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cantorian Restoration",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A living creature within 60 feet would die.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be93454b-2166-430d-a6cb-34d925ce1c59"), Type = TextBlockType.Text, Text = $"The energy that flows in your blood can save a life in the direst of times. The triggering creature receives the effects of {ToMarkdownLink<Models.Entities.Spell>("breath of life", Spells.Instances.BreathOfLife.ID)}, except they recover a number of Hit Points equal to 6d8 plus your Constitution modifier." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9291bfc7-fabe-4347-b6ef-40a69c32a543"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("1dcf3a0d-93a8-4c9a-bcb5-41d59e29c9a6"), Traits.Instances.Hobgoblin.ID);
            builder.Add(Guid.Parse("3a16dbc4-7f99-465b-8c04-28669c3cdd8a"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("0d539cf9-a202-4977-bc22-1215f00cd54a"), Traits.Instances.Positive.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fbc2fc06-fd61-4896-aed4-b413811ea79c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
