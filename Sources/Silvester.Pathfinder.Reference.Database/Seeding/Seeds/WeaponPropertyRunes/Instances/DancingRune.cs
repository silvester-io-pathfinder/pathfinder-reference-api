using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class DancingRune : Template
    {
        public static readonly Guid ID = Guid.Parse("db537aa1-ebec-4919-8e71-8a2172b1197a");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Dancing",
                Usage = "Etched onto a melee weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneAction> GetActions()
        {
            yield return new WeaponPropertyRuneAction
            {
                Id = Guid.Parse("f0ade3f8-bc90-41eb-aeef-24b11607bcc3"),
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                Name = "Command, Interact",
                Effect = "You Release the weapon and it dances through the air, fighting on its own against the last enemy you attacked, or the nearest enemy to it if your target has been defeated. At the end of your turn each round, the weapon can Fly up to its fly Speed of 40 feet, and then can either Fly again or Strike one creature within its reach."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("5befb651-cdaf-4afc-b893-6da19235a866"),
                ItemLevel = 13,
                Price = 270000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("67b40e55-6393-4b43-8be4-9d8a6a2cdf5d"), Type = TextBlockType.Text, Text = "A dancing weapon flies autonomously and strikes your foes."},
                    new TextBlock {Id = Guid.Parse("6cf96412-3272-43cb-83f2-41320ad6b139"), Type = TextBlockType.Text, Text = "The weapon has a space of 5 feet, but it doesn’t block or impede enemies attempting to move though that space, nor does it benefit from or provide flanking. The weapon can’t move through an enemy’s space. The weapon can’t use reactions, and its Fly actions don’t trigger reactions."},
                    new TextBlock {Id = Guid.Parse("27422f01-d52a-46bf-825b-1e4683594ac0"), Type = TextBlockType.Text, Text = "While it’s activated, a dancing weapon makes Strikes with an attack modifier of +24 plus its item bonus to attack rolls. It uses the weapon’s normal damage but has a +0 Strength modifier. The weapon’s abilities that automatically trigger on a hit or critical hit still function, but the weapon can’t be activated or benefit from any of your abilities while dancing."},
                    new TextBlock {Id = Guid.Parse("e16b5907-0caa-483c-84c1-5d1643ee91d9"), Type = TextBlockType.Text, Text = "Each round, when the weapon is finished using its actions, attempt a DC 6 flat check. On a failure, the activation ends and the weapon falls to the ground. You can’t activate the item again for 10 minutes."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c58f4345-9639-427b-a0fd-81b28876eab5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
