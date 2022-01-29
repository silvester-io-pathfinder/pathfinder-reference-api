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
    public class TwinTakedown : Template
    {
        public static readonly Guid ID = Guid.Parse("435f3919-fa85-4eff-b935-171cead07ede");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Takedown",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a61070eb-e129-4d86-9c09-782ec9b69500"), Type = TextBlockType.Text, Text = $"You swiftly attack your hunted prey with both weapons. Make two {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against your hunted prey, one with each of the required weapons. If both hit the same hunted prey, combine their damage for the purpose of its resistances and weaknesses. Apply your multiple attack penalty to each {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} normally." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e945338a-cced-470f-8b20-1a1cc895a78d"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("ffbd5f20-9ca3-499b-aedf-b9b5fb133f6d"), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed154f54-91a8-44bf-b870-b53bff913b26"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
