using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MantelOfTheMagmaHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("869dd63e-95be-4502-9cd1-f8855d3c2e35");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mantel of the Magma Heart",
                Level = 5,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2effe2f6-7c41-45ab-a3aa-3b9ecc0fa0ca"), Type = TextBlockType.Text, Text = "You surround yourself in a mantle of blazing fire magic, and your skin and anything you�re wearing morphs into burning hot lava. The air around you swelters with heat, and tiny sparks of flame dance behind you as you pass. Upon casting this spell, pick two of the options below. As a single action, which has the concentrate trait, you can change one of your chosen abilities to a different option from the list." };
            yield return new TextBlock { Id = Guid.Parse("037841f9-7c8b-4ca3-a17f-a0922c18da13"), Type = TextBlockType.Enumeration, Text = "Enlarging Eruption - You erupt in lava, which clings to you and hardens, causing your body to swell and burst until you grow to size Large. You�re clumsy 1. Your reach increases by 5 feet (or by 10 feet if you started out Tiny), and you gain a +2 status bonus to melee damage. You can�t choose this option if you�re already Large or larger." };
            yield return new TextBlock { Id = Guid.Parse("c4bc8601-94c1-48c3-bff1-561896cc3036"), Type = TextBlockType.Enumeration, Text = "Fiery Grasp - Your hands swell and grow with lava. You gain a lava fist unarmed attack in the brawling weapon group. Your lava fists deal 1d8 bludgeoning damage as their base damage, plus an additional 2d6 fire damage and 1d6 persistent fire damage" };
            yield return new TextBlock { Id = Guid.Parse("8baeb871-b10c-4c7f-a6e7-b85c72e3e706"), Type = TextBlockType.Enumeration, Text = "Heart of Fire - Your body�s temperature becomes so hot that any creature that touches you, or that hits you with a melee unarmed attack or non-reach melee weapon attack, takes 2d6 fire damage." };
            yield return new TextBlock { Id = Guid.Parse("4222dec6-f765-479d-9411-81b1d46e4534"), Type = TextBlockType.Enumeration, Text = "Warming Flames - Flames flicker around you, warming away the cold while protecting you from the heat. You gain resistance 5 to cold and fire." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d4dfd9d-1486-4b19-a03e-ddb86fd75130"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 115
            };
        }
    }
}
