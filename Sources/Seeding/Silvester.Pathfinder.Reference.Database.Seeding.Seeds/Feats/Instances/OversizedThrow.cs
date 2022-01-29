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
    public class OversizedThrow : Template
    {
        public static readonly Guid ID = Guid.Parse("1ed68eed-f8ce-469d-aee9-0ee234328336");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oversized Throw",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10c5d268-bb9a-458c-949c-5d9759219230"), Type = TextBlockType.Text, Text = $"With a great heave, you seize a piece of your surroundings, such as a boulder, log, table, wagon, or chunk of earth, and hurl it at your foes. The object must be your size or one size smaller than you, and it must not have too much Bulk for you to lift it in the first place. Make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the object; regardless of the result, the object takes the same amount of damage it would deal on a success. The object is a simple ranged weapon that deals 1d10 bludgeoning damage, has a range increment of 20 feet, and has the {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} weapon trait. The damage increases to 2d10 if you have weapon specialization in simple weapons, or 3d10 if you have greater weapon specialization." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Rage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f1b84d9-15ee-4fbc-86de-75e44f689194"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
