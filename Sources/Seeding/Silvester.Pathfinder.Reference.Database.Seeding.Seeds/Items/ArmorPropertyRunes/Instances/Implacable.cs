using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes.Instances
{
    public class Implacable : Template
    {
        public static readonly Guid ID = Guid.Parse("30d21f9b-2b0c-4e57-8a14-ce7732582c33");
        public static readonly Guid STANDARD_ID = Guid.Parse("fb5066c2-f5d9-4eb9-a03f-0f24ac0a5c15");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Implacable",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c27d531b-b86c-455a-9ddb-2cdfeabd590d"), "This substantial rune makes you difficult to hold back.");
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Implacable",
                Usage = "Etched onto medium or heavy armor.",
                Level = 11,
                Price = 120000,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d3723475-444a-4fa6-bfd4-7afc51bca7a3"), "Whenever you are affected by an effect that lasts until you Escape (for instance, from the Grapple action or a tanglefoot bag), you become quickened. You can use the extra action each round only to Step or Escape.")
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5dbe2869-d450-439f-8a3c-7d57e7114eac"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("90652e1f-fc57-45b7-b7a2-9adfb07ac2f1"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0a84f93-9157-4f9a-8abc-72009a7ffc9e"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 80
            };
        }
    }
}
