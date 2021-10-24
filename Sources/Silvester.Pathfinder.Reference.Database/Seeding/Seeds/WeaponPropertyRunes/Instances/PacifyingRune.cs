using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class PacifyingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("89a71607-0a02-4f55-87d3-48f6bdff84e5");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Pacifying",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("be587d25-d395-4c0c-9601-6b81507b8bfa"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Command",
                Trigger = "You damage a creature with a pacifying weapon",
                Effect = "The damaged creature must succeed at a DC 20 Will save or be pacified. A pacified creature takes a –2 penalty to attack rolls on any attacks that aren't nonlethal for 1 minute, and the creature also experiences a clear psychic warning that they should stop dealing lethal damage."
            };
        }

        protected override IEnumerable<Guid> GetActionTraits(WeaponPropertyRuneAction action)
        {
            yield return Traits.Instances.Mental.ID;
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("da8995d1-7845-4efd-916a-37ac99058ed2"),
                ItemLevel = 5,
                Price = 15000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("f32a3334-8cc1-4dd6-89dd-c89cc34f7d43"), Type = TextBlockType.Text, Text = "This rune turns weapons into instruments of peacemaking."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Magical.ID;
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
