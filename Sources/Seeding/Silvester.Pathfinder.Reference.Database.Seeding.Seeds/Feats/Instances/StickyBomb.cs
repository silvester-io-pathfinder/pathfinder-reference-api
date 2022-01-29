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
    public class StickyBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("27e38f45-f809-4d2c-b382-bd58eb2f1bc8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sticky Bomb",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Quick Alchemy to craft an alchemical bomb, and that bomb's level is at least 2 levels lower than your Advanced Alchemy level.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e861330e-1f58-4e75-83a3-6643bad6a503"), Type = TextBlockType.Text, Text = $"You mix in an additive to make your bomb's contents adhere to the target and continue to deal damage. A creature that takes a direct hit from one of your sticky bombs also takes persistent damage equal to and of the same type as the bomb's splash damage. If the bomb already deals persistent damage, combine the two amounts." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Additive.ID, "2");
            builder.Add(Guid.Parse(""), Traits.Instances.Alchemist.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f58558fc-4d7a-43a6-ad31-0e0927db4513"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
