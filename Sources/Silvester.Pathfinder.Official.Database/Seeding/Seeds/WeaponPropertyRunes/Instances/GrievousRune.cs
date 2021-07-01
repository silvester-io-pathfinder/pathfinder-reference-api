using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class GrievousRune : Template
    {
        public static readonly Guid ID = Guid.Parse("01abc739-588b-4c41-9eda-660b0d4bf3cd");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Grievous",
                Usage = "Etched onto a weapon.",
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("d0409cb7-277d-4700-90b1-344123d3b827"),
                ItemLevel = 9,
                Price = 70000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("ff45ace5-d7f4-42bd-8dcd-298dd0e81bd0"), Type = TextBlockType.Text, Text = "When your attack roll with this weapon is a critical hit and gains the critical specialization effect, you gain an additional benefit depending on the weapon group."},
                    new TextBlock {Id = Guid.Parse("f1840b68-7c69-4daa-8967-ff8b464a8aca"), Type = TextBlockType.Enumeration, Text = "Axe - You can damage a third creature, with the same restrictions."},
                    new TextBlock {Id = Guid.Parse("a01f1855-ee53-4a05-a8df-6815537cd982"), Type = TextBlockType.Enumeration, Text = "Bow - The Athletics check to pull the missile free is DC 20."},
                    new TextBlock {Id = Guid.Parse("cd67c2b3-dfb9-436f-bfb2-4d2b9ffa99cb"), Type = TextBlockType.Enumeration, Text = "Brawling - The target takes a –4 circumstance penalty to its save."},
                    new TextBlock {Id = Guid.Parse("599a9463-1762-4b29-ac06-e33170e67683"), Type = TextBlockType.Enumeration, Text = "Club - You can knock the target up to 15 feet away."},
                    new TextBlock {Id = Guid.Parse("856c5687-33ec-487e-a7eb-7d4652b566b4"), Type = TextBlockType.Enumeration, Text = "Dart - The base persistent bleed damage increases to 2d6."},
                    new TextBlock {Id = Guid.Parse("9b9297c4-3560-437f-abb6-b8956fc1c407"), Type = TextBlockType.Enumeration, Text = "Flail - You move the target 5 feet. You can't move it away from you, but you can move it in another direction of your choice."},
                    new TextBlock {Id = Guid.Parse("1a5bff82-c11a-44b9-98cc-3bf9f40fab75"), Type = TextBlockType.Enumeration, Text = "Hammer - You can also knock the target 5 feet away from you."},
                    new TextBlock {Id = Guid.Parse("6477c63d-db7e-46d2-bf72-909ce094dd99"), Type = TextBlockType.Enumeration, Text = "Knife - The target takes a –5-foot status penalty to its Speed while it has the persistent bleed damage."},
                    new TextBlock {Id = Guid.Parse("673bb822-d06d-4a2e-a554-e2dd5498a7df"), Type = TextBlockType.Enumeration, Text = "Pick - The extra damage from the critical specialization effect increases to 4 per weapon damage die."},
                    new TextBlock {Id = Guid.Parse("b4ebc733-fb21-472f-981b-8cf1cba27f9e"), Type = TextBlockType.Enumeration, Text = "Polearm - You can move the target up to 10 feet."},
                    new TextBlock {Id = Guid.Parse("1373aa1b-fa84-4f3c-95d9-be6f309a3dd1"), Type = TextBlockType.Enumeration, Text = "Shield - You can knock the target up to 10 feet away."},
                    new TextBlock {Id = Guid.Parse("0e4f1eda-1a64-41b0-b0fc-6d0745cd2e28"), Type = TextBlockType.Enumeration, Text = "Sling - The target also takes a –10-foot status penalty to its Speed for 1 round if it fails the save."},
                    new TextBlock {Id = Guid.Parse("7854668c-239b-48d7-8fde-665c616dc95c"), Type = TextBlockType.Enumeration, Text = "Spear - The clumsy condition lasts for 2 rounds."},
                    new TextBlock {Id = Guid.Parse("d612d63e-e996-4b72-8832-f2ae5fc4fa7f"), Type = TextBlockType.Enumeration, Text = "Sword - The target is flat-footed until the end of your next turn."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af7e74e0-3c19-431e-a8d0-0efe38ac55cb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
