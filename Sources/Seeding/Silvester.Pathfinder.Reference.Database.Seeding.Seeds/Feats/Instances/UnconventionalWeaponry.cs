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
    public class UnconventionalWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("a2f5e623-990e-4cb6-b0ee-78afd194b604");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unconventional Weaponry",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34814f5b-0c17-4ad8-b423-33802d3ce80c"), Type = TextBlockType.Text, Text = $"You've familiarized yourself with a particular weapon, potentially from another ancestry or culture. Choose an uncommon simple or martial weapon with a trait corresponding to an ancestry (such as dwarf, goblin, or orc) or that is common in another culture. You gain access to that weapon, and for the purpose of determining your proficiency, that weapon is a simple weapon." };
            yield return new TextBlock { Id = Guid.Parse("5118a242-117b-4a90-8ec3-c2741a7d742b"), Type = TextBlockType.Text, Text = $"If you are trained in all martial weapons, you can choose an uncommon advanced weapon with such a trait. You gain access to that weapon, and for the purpose of determining your proficiency, that weapon is a martial weapon." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31f71c30-6ee4-441c-8307-f729fe3c7ca7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
