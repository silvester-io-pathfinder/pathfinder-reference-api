using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Energizing : Template
    {
        public static readonly Guid ID = Guid.Parse("d8ab78d3-f2aa-466f-bf2b-3b883b74e4b4");

        public static readonly Guid STANDARD_ID = Guid.Parse("d0f9f1be-45f3-4f8e-99f2-2dc8b42d7dac");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Energizing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4e7b5ecb-b2a4-40c2-9351-52bb4fcd1a34"), "A weapon with this rune can absorb energy damage to empower it.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Energizing",
                Usage = "Etched onto a weapon.",
                Level = 6,
                Price = 25000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d14bf2e3-23fd-4d3d-839e-371f65b5da3c"), "")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e4086c30-d373-40d4-9f96-0695a57bad25"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                         action
                             .Kind("Envision")
                             .Trigger("You take acid, cold, electricity, fire, or sonic damage.")
                             .Details(effect =>
                             {
                                 effect.Text(Guid.Parse("921992f5-9034-4e4e-8f83-f831effcc93d"), "The weapon becomes imbued with the triggering energy type. It deals an additional 1d8 damage of the triggering type until the end of your next turn. As normal, if you use this reaction again during the duration, the damage doesn't combine; instead, change the 1d8 damage to the new triggering type of damage and change the duration to the end of your next turn.");
                             });
                    })
                    .Build()
                };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9fcad517-a6c8-479b-8f0b-3d581bf9dd7a"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("cdfeaab4-db82-4a2e-8c19-339c1e9afb7e"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddc70bef-21c8-45db-bb1e-6104a2d84e36"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 6
            };
        }
    }
}
