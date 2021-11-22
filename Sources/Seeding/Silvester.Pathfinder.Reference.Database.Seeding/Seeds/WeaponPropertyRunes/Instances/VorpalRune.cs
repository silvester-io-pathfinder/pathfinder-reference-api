using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class VorpalRune : Template
    {
        public static readonly Guid ID = Guid.Parse("7f7dc195-f152-4e36-a6d3-db63888e3c58");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Vorpal",
                Usage = "Etched onto a slashing melee weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("60123526-a8c9-4fbb-a825-2f56b712a385"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Envision",
                Trigger = "You roll a natural 20 on a Strike with the weapon, critically succeed, and deal slashing damage. The target must have a head.",
                Effect = "The target must succeed at a DC 37 Fortitude save or be decapitated. This kills any creature except ones that don't require a head to live. For creatures with multiple heads, this usually kills the creature only if you sever its last head."
            };
        }

        protected override IEnumerable<Guid> GetActionTraits(WeaponPropertyRuneAction action)
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Incapacitation.ID;
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("fc4fd64f-3b91-43be-bc8a-f4d8c2c1f172"),
                ItemLevel = 17,
                Price = 1500000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("dbba7b53-ed42-4314-8b51-eb91c19ac5c0"), Type = TextBlockType.Text, Text = "Originally created as a means of slaying the legendary jabberwock, vorpal weapons prove equally effective against nearly any foe with a head."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5bd23f4-a281-4761-a73d-28f6ec9a8d42"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
