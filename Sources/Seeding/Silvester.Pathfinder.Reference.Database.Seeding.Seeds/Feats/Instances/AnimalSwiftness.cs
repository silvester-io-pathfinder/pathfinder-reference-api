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
    public class AnimalSwiftness : Template
    {
        public static readonly Guid ID = Guid.Parse("1d8b4fda-8b2a-4f0b-b7eb-6bb0fb6f6bd3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Swiftness",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a567f44c-4bbb-4130-89f1-98ebd1fd1ea6"), Type = TextBlockType.Text, Text = $"You move like an animal. Your Speed increases by 5 feet. In addition, you gain one of the following Speeds available to your inherent animal: climb, fly, or swim. You gain this Speed only while in your hybrid shape." };
            yield return new TextBlock { Id = Guid.Parse("89737afd-0367-4754-ae98-4393e548ee82"), Type = TextBlockType.Text, Text = $"The new movement is as fast as your standard Speed; for example, if you have a 30-foot Speed, you can gain a 30-foot climb Speed. If your inherent animal doesn't typically have a specific type of Speed, you can't gain it with this feat. If your inherent animal doesn't typically have a climb, fly, or swim Speed, your Speed increases by 10 feet instead." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Beastkin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41cd41e5-cffa-4ea1-acdb-09fcfcd6e122"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
