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
    public class Bitter : Template
    {
        public static readonly Guid ID = Guid.Parse("5edf1d27-5c3c-4a77-8888-1025fd475d38");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Bitter",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ad91e9e6-a2da-4856-8c62-974d64420a5f"), "Armor that is etched with a Bitter rune affects creatures that swallow the wearer.");
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("8c81b7dc-7621-4a5e-acf6-0a01066c29c4"),
                Name = "Bitter",
                Usage = "Etched onto armor.",
                Level = 9,
                Price = 13500,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("36b1400d-5462-4116-b037-6419e55cfa30"), "While you wear this acrid armor, any creature that Engulfs you or Swallows you Whole is sickened 1; if it spends an action retching to reduce the sickened condition, you can attempt to Escape as a reaction.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("50cf4c7f-0742-4d6c-aa7a-2b07713929ff"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("1ca8c68a-6ad3-4c5d-85f7-7b2160f8dfad"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("987dacfe-7754-4a95-bb75-575a0c3f6426"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62c0557b-1cdb-4114-93a7-01f93d11804e"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 18
            };
        }
    }
}
