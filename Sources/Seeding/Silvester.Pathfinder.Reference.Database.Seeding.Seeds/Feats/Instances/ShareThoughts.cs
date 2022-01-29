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
    public class ShareThoughts : Template
    {
        public static readonly Guid ID = Guid.Parse("e2380413-0877-417e-b417-d5cb9c1019a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Thoughts",
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
            yield return new TextBlock { Id = Guid.Parse("f87d285a-7b42-4d78-9318-23ad0ce2474d"), Type = TextBlockType.Text, Text = $"~ Access: Mualijae, Ilverani, or Vourinoi ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("021648db-5a99-44b2-8a29-8d7622e6ba6c"), Type = TextBlockType.Text, Text = $"You have an uncanny knack of communicating with other elves without speaking, though this habit that is often uncomfortable to observers. You can cast {ToMarkdownLink<Models.Entities.Spell>("mindlink", Spells.Instances.Mindlink.ID)} as an innate occult spell once per day, but you can target only other elves or half-elves." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7ebaa15d-6b51-42c2-969b-9a8bffa4fe32"), Traits.Instances.Elf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24b84995-74b3-406d-bcfe-4b9851de3310"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
