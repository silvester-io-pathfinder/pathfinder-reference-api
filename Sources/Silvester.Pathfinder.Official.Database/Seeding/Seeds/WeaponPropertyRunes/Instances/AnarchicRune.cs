using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.WeaponPropertyRunes.Instances
{
    public class AnarchicRune : Template
    {
        public static readonly Guid ID = Guid.Parse("74492dda-e75d-4927-9e82-4fe95e9ca396");

        protected override WeaponPropertyRune GetRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Anarchic",
                Usage = "Etched onto a weapon without an axiomatic rune.",
                CraftingRequirements = "You are chaotic."
            };
        }

        protected override IEnumerable<WeaponPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new WeaponPropertyRunePotencyBinding
            {
                Id = Guid.Parse("f860a640-0e15-4a5c-afab-6d6db3a08f79"),
                ItemLevel = 11,
                Price = 140000,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Benefits = new[]
                {
                    new TextBlock {Id = Guid.Parse("8f72b0cc-7525-4564-9df2-b6a023da280a"), Type = TextBlockType.Text, Text = "An anarchic rune is jagged and asymmetrical, channeling chaotic energy. A weapon with this rune deals an additional 1d6 chaotic damage against lawful targets. If you are lawful, you are enfeebled 2 while carrying or wielding this weapon."},
                    new TextBlock {Id = Guid.Parse("eb05e944-f51c-4cc7-89c0-5f832b21620b"), Type = TextBlockType.Text, Text = "When you critically succeed at a Strike with this weapon against a lawful creature, roll 1d6. On a 1 or 2, you deal double minimum damage; on a 3 or 4, double your damage normally; on a 5 or 6, you deal double maximum damage."},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Chaotic.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0b8eb1f-9079-4686-9aca-5b2047cd28fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }
    }
}
