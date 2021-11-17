using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class SpellStoringRune : Template
    {
        public static readonly Guid ID = Guid.Parse("294a6238-beb1-4b09-97c6-dc08d2f98185");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Spell-Storing",
                Usage = "Etched onto a melee weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("2d5e8f15-61cd-49f5-a621-0b6d2b32b5dc"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Command",
                Effect = "You unleash the stored spell, which uses the target of the triggering attack as the target of the spell. This empties the spell from the weapon and allows a spell to be cast into it again. If the spell requires a spell attack roll, the result of your attack roll with the weapon determines the degree of success of the spell, and if the spell requires a saving throw, the DC is 30.",
                Requirements = "On your previous action this turn, you hit and damaged a creature with this weapon.",
            };

            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("f2c2edc5-c720-4d5c-8376-eccdb3ee6ba0"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Command",
                Effect = "Harmlessly expend the stored spell. This frees the weapon to have a new spell cast into it."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("9968c8a7-4e09-4887-b62d-2e4ae3591aec"),
                ItemLevel = 13,
                Price = 270000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("ba1bd5b1-7d85-499c-9c30-9f4bb7e6a8e4"), Type = TextBlockType.Text, Text = "A spell-storing rune creates a reservoir of eldritch energy within the etched weapon. A spellcaster can spend 1 minute to cast a spell of 3rd level or lower into the weapon. The spell must have a casting of 2 actions or fewer and must be able to target a creature other than the caster. The spell has no immediate effect—it is instead stored for later. When you wield a spell-storing weapon, you immediately know the name and level of the stored spell. A spell-storing weapon found as treasure has a 50% chance of having a spell of the GM’s choice stored in it."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7769d72-1dce-4fb6-a0b6-c4c77949a356"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
