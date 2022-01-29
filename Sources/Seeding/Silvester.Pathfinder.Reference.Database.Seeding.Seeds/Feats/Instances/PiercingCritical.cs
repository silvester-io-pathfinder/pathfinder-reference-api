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
    public class PiercingCritical : Template
    {
        public static readonly Guid ID = Guid.Parse("5bd905bd-d75c-41ec-a219-48b232e7ea70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Piercing Critical",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("318e5e4a-7751-4fc5-b7e3-bfa326e3edd1"), Type = TextBlockType.Text, Text = $"Your attacks with your preferred weapons deal especially devastating wounds. When you {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with a firearm or crossbow for which you have legendary proficiency, you critically succeed if you roll a 19 on the die, as long as that result is a success." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a3b88f60-a001-4462-aab8-43698db27468"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ffd4ccf-c27c-4415-90b1-daaf85a1a671"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
