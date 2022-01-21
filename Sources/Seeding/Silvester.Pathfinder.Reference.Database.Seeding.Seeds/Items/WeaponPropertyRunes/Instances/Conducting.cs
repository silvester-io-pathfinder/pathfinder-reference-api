using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Conducting : Template
    {
        public static readonly Guid ID = Guid.Parse("bf9f7ffc-b647-48f0-b818-557d23de1511");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Conducting",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("ece62494-d652-4ea8-96d9-3a1cb7348265"),
                Name = "Conducting",
                Usage = "Etched onto a weapon.",
                Level = 7,
                Price = 30000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("dbed857f-4af5-4a1c-8a71-d1bde6b1f7d1"), "A conducting weapon can channel energy through it. The weapon gains the resonant weapon trait, except that when you Conduct Energy, the weapon deals an additional 1d8 damage of the selected type instead of 1 additional damage per die; if the weapon already had the resonant weapon trait, it deals 1d8 damage plus 1 damage per die instead. On a critical hit, the weapon deals 1d8 persistent damage of the same type.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b20fb324-3598-429b-89b3-19fbd8b83f0c"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("e61d3a1a-fe20-4670-9310-d877964c507d"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86667daa-a9b2-40bf-9716-504bb98f8e8a"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 139
            };
        }
    }
}
