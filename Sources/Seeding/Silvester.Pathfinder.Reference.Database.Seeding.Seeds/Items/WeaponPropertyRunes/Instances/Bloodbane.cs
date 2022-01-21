using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Bloodbane : Template
    {
        public static readonly Guid ID = Guid.Parse("5bef5cb1-6cc2-4540-9224-6200bb40d217");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Bloodbane",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0c77fc3d-b181-4975-ba10-cafbbfbadd37"), "A bloodbane clan dagger is especially vicious against the ancestral enemies of the clan. When you damage an appropriate type of creature with the weapon, that creature takes 1 persistent bleed damage. The type of creature depends on the clan that made the dagger, but is typically drow, duergar, giant, or orc.");
            builder.Text(Guid.Parse("77e3597b-6ea4-4733-8920-04c4cebbd31a"), "In addition, whenever you inflict persistent bleed damage with a bloodbane weapon (whether from its innate ability or in some other way), the weapon leaves ragged wounds. The bleeding creature must succeed at a DC 25 Fortitude save or become sickened 1. The creature is then temporarily immune for 1 hour.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("5841519c-7f2e-4954-aa13-47b6fc1e7a62"),
                Name = "Bloodbane",
                Usage = "Etched onto a clan dagger.",
                Level = 8,
                Price = 47500,
                RarityId = Rarities.Instances.Uncommon.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("58601e5f-f93a-46fe-9e6e-2f4d63ed7f9f"),
                Name = "Bloodbane (Greater)",
                Usage = "Etched onto a clan dagger.",
                Level = 13,
                Price = 280000,
                RarityId = Rarities.Instances.Uncommon.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("318feeb1-4c1a-4ee7-a9d9-0735d4a43c13"), "The weapon deals 1d4 bleed damage to creatures designated as the clan's enemy, and the DC of the Fortitude save to avoid becoming sickened is 30.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("888bfa5e-b4c3-400c-98f9-01c7a9a81b5d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("27e2c774-6c3f-43e7-9970-5894e2ab422b"), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse("592a6cf9-c5a5-4a2c-8ebc-b4321e8fe608"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("7568606b-a5bc-40a4-900c-ff3429e0ad87"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bfa28f4-acd9-4830-a73c-2269824febb8"),
                SourceId = Sources.Instances.Pathfinder148.ID,
                Page = 75
            };
        }
    }
}
