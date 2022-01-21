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
    public class Pacifying : Template
    {
        public static readonly Guid ID = Guid.Parse("89a71607-0a02-4f55-87d3-48f6bdff84e5");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Pacifying",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("da8995d1-7845-4efd-916a-37ac99058ed2"),
                Name = "Pacifying",
                Usage = "Etched onto a weapon.",
                Level = 5,
                Price = 15000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f32a3334-8cc1-4dd6-89dd-c89cc34f7d43"), "This rune turns weapons into instruments of peacemaking.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("be587d25-d395-4c0c-9601-6b81507b8bfa"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You damage a creature with a pacifying weapon.")
                            .Traits(traits =>
                            {
                                traits.Add(Guid.Parse("2d65dd4e-52bd-43e5-8bab-6b0217d22a64"), Traits.Instances.Mental.ID);
                            })
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("e271f903-7c6b-4bd9-a930-b39899b00552"), "The damaged creature must succeed at a DC 20 Will save or be pacified. A pacified creature takes a –2 penalty to attack rolls on any attacks that aren't nonlethal for 1 minute, and the creature also experiences a clear psychic warning that they should stop dealing lethal damage.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("5e0ef1fc-987a-4e95-bb53-a92ed3af2ef7"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("1432f624-21eb-4753-8a04-4c85201f78e7"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c7b9705-81b3-48e4-8f80-67dd8f724ee6"),
                SourceId = Sources.Instances.Pathfinder157.ID,
                Page = 78
            };
        }
    }
}
